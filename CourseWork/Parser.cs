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
        int start, end;
        public Parser(List<string> playersLinks, int start=0, int end=0)
        {
            links = playersLinks;
            this.start = start;
            this.end = end > 0 ? end : playersLinks.Count;
        }

        private void GetPlayer()
        {
            for (int i = start; i < end; i++)
            {
                Thread.Sleep(1000);
            }
        }

        public void Start()
        {

        }
    }
}
