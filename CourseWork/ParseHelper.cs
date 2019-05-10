using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace CourseWork
{
    class ParseHelper
    {
        List<string> links;
        List<Player> players;
        List<Parser> parsers;

        public delegate void OnPlayerProcessedHandler(Player player, bool error);
        public event OnPlayerProcessedHandler OnPlayerProcessed;

        public delegate void OnProcessedHandler();
        public event OnProcessedHandler OnProcessed;

        Object lockMe = new Object();
        public ParseHelper(string playersListFile)
        {   
            links = new List<string>(File.ReadAllLines(playersListFile));
        }

        public ParseHelper(Uri playersListUrl)
        {
            links = GetPlayersLinks(playersListUrl);
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
                ParallelLoopResult result = Parallel.For(1, trs.Count, (i, s) =>
                {
                    string link = trs[i].ChildNodes[3].FirstChild.Attributes["href"].Value;
                    lock (lockMe)
                    {
                        ls.Add(String.Format(@"{0}://{1}{2}", url.Scheme, url.Authority, link));
                    }
                });
            }
            else
            {
                throw new NullReferenceException("Cant find table. Wrong url was provided");
            }
            return ls;
        }

        public void Parse(int divider, bool byStep)
        {
            if (divider < 1)
                throw new Exception("Cant step by 0 or divide by 0 threads");

            players = new List<Player>();
            parsers = new List<Parser>();
            int id = 0;
            if (byStep)
            {
                for (int i = 0; i < 20; i += divider)
                {
                    Parser parser = new Parser(id++, links, i, i + divider > links.Count ? links.Count : i + divider);
                    parser.OnPlayerParsed += Player_OnPlayerParsed;
                    parser.OnParsed += Parser_OnParsed;
                    parser.Start();
                    parsers.Add(parser);
                }
            }
            else
            {
                int[] steps = GetSteps(6, divider);
                int start = 0;
                for (int i = 0; i < steps.Length; i++)
                {
                    Parser parser = new Parser(id++, links, start, start + steps[i]);
                    start += steps[i];
                    parser.OnPlayerParsed += Player_OnPlayerParsed;
                    parser.OnParsed += Parser_OnParsed;
                    parser.Start();
                    parsers.Add(parser);
                }
            }
        }



        public void Abort()
        {
            foreach(Parser parser in parsers)
            {
                parser.Abort();
            }
        }

        private int[] GetSteps(int count, int threads)
        {
            int[] steps = new int[threads];
            int i = 0;
            while (count > 0)
            {
                steps[i++] += 1;
                count--;
                if (i == threads)
                    i = 0;
            }
            return steps;
        }
           
        private void Player_OnPlayerParsed(Player player, bool error)
        {
            players.Add(player);
            OnPlayerProcessed(player,error);
        }

        private void Parser_OnParsed(Parser parser)
        {
            parsers.Remove(parser);
            if (parsers.Count == 0)
                OnProcessed();

        }
        public Player GetPlayerByNickname(string nickname)
        {
            return players.Find(p => p.Nickname == nickname);
        }

        public int PlayersLinksCount
        {
            get { return links.Count; }
        }
    }
}
