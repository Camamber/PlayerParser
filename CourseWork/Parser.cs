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
        WebProxy proxy;

        public delegate void OnPlayerParsedHandler(Player player, bool error);
        public event OnPlayerParsedHandler OnPlayerParsed;

        public delegate void OnParsedHandler(Parser parser);
        public event OnParsedHandler OnParsed;

        public Parser(string proxy, List<string> playersLinks, int start = 0, int end = 0)
        {
            this.proxy = CheckProxy(proxy);
            links = playersLinks;
            this.start = start;
            this.end = end > 0 ? end : playersLinks.Count;
            thread = new Thread(GetPlayer);
        }

        private WebProxy CheckProxy(string adress)
        {
            if (adress == null || adress == "")
                return null;

            WebProxy proxy = new WebProxy(adress);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://www.google.com");
            request.Proxy = proxy;
            request.Timeout = 10000;
            request.Method = "HEAD";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    return proxy;
            }
            catch
            {
                return null;
            }
        }

        private string GetFullUrl(string baseUrl, string path)
        {
            return new Uri(new Uri(baseUrl), path).ToString();
        }

        private void GetPlayer()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //HtmlWeb web = new HtmlWeb();  
            WebClient wc = new WebClient();
            wc.Proxy = this.proxy;

            for (int i = start; i < end; i++)
            {                            
                Player player = new Player() { Url = links[i] };
                try
                {
                    HtmlDocument htmlDoc = new HtmlDocument();//web.Load(links[i]);
                    htmlDoc.LoadHtml(wc.DownloadString(links[i]));
                    player.Nickname = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-header')]")[0].InnerText.Replace("[e][h] ", "");
                    player.Photo = GetFullUrl(links[i], htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-image')]")[0].SelectSingleNode(".//img").Attributes["src"].Value);

                    var infoDescription = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'infobox-description')]");
                    foreach (var description in infoDescription)
                    {
                        switch (description.InnerText)
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
                    OnPlayerParsed(player, false);
                }
                catch(Exception ex)
                {
                    OnPlayerParsed(player, true);
                }
            }
            wc.Dispose();
            OnParsed(this);
        }

        public void Start()
        {
            thread.Start();
        }

        public void Join()
        {
            thread.Join();
        }

        public void Abort()
        {
            if(thread.IsAlive)
                thread.Abort();
            OnParsed(this);
        }
    }
}