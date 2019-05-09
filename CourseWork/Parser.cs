using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CourseWork
{

    class Parser
    {

        List<string> links;
        Thread thread;
        int start, end;

        public delegate void OnPlayerParsedHandler(Player p);
        public event OnPlayerParsedHandler OnPlayerParsed;

        public Parser(List<string> playersLinks, int start = 0, int end = 0)
        {
            links = playersLinks;
            this.start = start;
            this.end = end > 0 ? end : playersLinks.Count;
            thread = new Thread(GetPlayer);
        }

        private string GetFullUrl(string baseUrl, string path)
        {
            return new Uri(new Uri(baseUrl), path).ToString();
        }

        private void GetPlayer()
        {
            for (int i = start; i < end; i++)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                HtmlWeb web = new HtmlWeb();
                HtmlDocument htmlDoc = web.Load(links[i]);
                Player player = new Player() { Url = links[i] };
                player.Nickname = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-header')]")[0].InnerText.Replace("[e][h] ", "");
                player.Photo = GetFullUrl(links[i], htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-image')]")[0].SelectSingleNode(".//img").Attributes["src"].Value);

                var infoDescription = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-description')]");
                foreach(var description in infoDescription)
                {
                    switch(description.InnerText)
                    {
                        case "Name:":
                            player.Name = description.ParentNode.ChildNodes[3].InnerText;
                            break;
                        case "Romanized Name:":
                            player.Name = description.ParentNode.ChildNodes[3].InnerText;
                            break;
                        case "Birth:":
                            string tmp = description.ParentNode.ChildNodes[3].InnerText;
                            player.Birth = DateTime.Parse(tmp.Remove(tmp.IndexOf("(")));
                            break;
                        case "Country:":
                            player.Country = description.ParentNode.ChildNodes[3].SelectSingleNode("./a").InnerText;
                            break;
                        case "Status:":
                            player.Status = description.ParentNode.ChildNodes[3].InnerText;
                            break;
                        case "Role(s):":
                            player.Role = description.ParentNode.ChildNodes[3].FirstChild.InnerText;
                            break;
                        case "Approx. Total Earnings:":
                            player.TotalEarnings = description.ParentNode.ChildNodes[3].InnerText;
                            break;
                    }
                }
                OnPlayerParsed(player);
            }
        }

        public void Start()
        {
            thread.Start();
        }

        public void Join()
        {
            thread.Join();
        }
    }
}