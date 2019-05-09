using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace CourseWork
{
    enum ParallelMethod { Threads, ParallelFor}


    class ParseHelper
    {
        List<string> links;
        List<Player> players;

        public delegate void OnPlayerProcessedHandler(Player p);
        public event OnPlayerProcessedHandler OnPlayerProcessed;

        Object lockMe = new Object();
        public ParseHelper(List<string> playersLinks, ParallelMethod method)
        {

        }

        public ParseHelper(string playersListUrl, ParallelMethod method)
        {
            if (String.IsNullOrEmpty(playersListUrl))
                throw new NullReferenceException("`playersListUrl` shouldn't be empty");

            links = GetPlayersLinks(new Uri(playersListUrl));
        }

        private List<string> GetPlayersLinks(Uri url)
        {
            List<string> ls = new List<string>();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);

            var tbody = htmlDoc.DocumentNode.SelectSingleNode("/html/body//tbody");
            if (tbody != null && tbody.ChildNodes.Count > 1)
            {
                var trs = tbody.SelectNodes("//tr");
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //for (int i = 1; i < trs.Count; i++)
                //{
                //    string link = trs[i].ChildNodes[3].FirstChild.Attributes["href"].Value;
                //    ls.Add(String.Format(@"{0}://{1}{2}", url.Scheme, url.Authority, link));
                //}

                ParallelLoopResult result = Parallel.For(1, trs.Count, (i, s) =>
                {
                   
                    string link = trs[i].ChildNodes[3].FirstChild.Attributes["href"].Value;
                    lock (lockMe)
                    {
                        ls.Add(String.Format(@"{0}://{1}{2}", url.Scheme, url.Authority, link));
                    }
                });

                sw.Stop();
            }
            else
            {
                throw new NullReferenceException("Cant find table. Wrong url was provided");
            }
            return ls;
        }

        public string[] PlayersLinks
        {
            get{ return links.ToArray(); }
        }
        public int PlayersLinksCount
        {
            get { return links.Count; }
        }
        
        public void Parse()
        {
            players = new List<Player>();
            int count = 1;
            for(int i = 0; i < 1; i+= count)
            {
                Parser p = new Parser(links, i, i + count > links.Count ? links.Count : i + count);
                p.OnPlayerParsed += Player_OnPlayerParsed;
                p.Start();
                //p.Join();
            }        
        }

        private void Player_OnPlayerParsed(Player p)
        {
            players.Add(p);         
            OnPlayerProcessed(p);
        }
    }
}
