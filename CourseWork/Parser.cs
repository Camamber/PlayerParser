using System;
using System.Collections.Generic;
using System.Linq;
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

        public Parser(List<string> playersLinks, int start=0, int end=0)
        {
            links = playersLinks;
            this.start = start;
            this.end = end > 0 ? end : playersLinks.Count;
            thread = new Thread(GetPlayer);
        }

        private void GetPlayer()
        {
            for (int i = start; i < end; i++)
            {
                Thread.Sleep(1);
                OnPlayerParsed(new Player(links[i]));
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
