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
            List<string> links = new List<string>();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);
           
            var tbody = htmlDoc.DocumentNode.SelectSingleNode("/html/body//tbody");
            if (tbody != null && tbody.ChildNodes.Count>1)
            {
                var trs = tbody.SelectNodes("//tr");
                Stopwatch sw = new Stopwatch();
                sw.Start();
                ParallelLoopResult result = Parallel.For(1, trs.Count, (i, s) =>
                {
                    try
                    {
                        string link = trs[i].ChildNodes[3].FirstChild.Attributes["href"].Value;
                        links.Add($"{url.Scheme}://{url.Authority}{link}");
                    }
                    catch { }

                });
                sw.Stop();
            }
            else
            {
                throw new NullReferenceException("Cant find table. Wrong url was provided");
            }
            return links;
        }

        public string[] PlayersLinks
        {
            get{ return links.ToArray(); }
        }

        public void Parse()
        {
            int count = 100;
            for(int i = 0; i < links.Count; i+= count)
            {
                Parser p = new Parser(links, i, i + count > links.Count ? links.Count : i + count);
                p.Start();
            }        
        }
    }
}
