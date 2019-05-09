using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CourseWork
{
    public partial class PlayerView : UserControl
    {
        public PlayerView()
        {
            InitializeComponent();
        }

        public void Update(Player p)
        {
            lblNickname.Text = p.Nickname;
            pbPhoto.Image = GetPhoto(p.Photo);
            lblName.Text = p.Name;
            lblBirth.Text = p.Birth.ToString();
            lblCountry.Text = p.Country;
            lblStatus.Text = p.Status;
            lblRole.Text = p.Status;
            lblEarnings.Text = p.TotalEarnings;
        }

        private Image GetPhoto(string url)
        {
            Image img;
            using(WebClient wc = new WebClient())
            {
               img = Image.FromStream(new MemoryStream(wc.DownloadData(url)));
            }
            return img; 
        }
    }
}
