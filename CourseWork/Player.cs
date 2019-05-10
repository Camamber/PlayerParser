using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Player
    {
        private Image photo;
        public string Url { get; set; }
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string TotalEarnings { get; set; }

        public Image GetPhoto()
        {
            if(photo == null)
            {
                using (WebClient wc = new WebClient())
                {
                    photo = Image.FromStream(new MemoryStream(wc.DownloadData(Photo)));
                }
            }
            return photo;
        }

    }
}
