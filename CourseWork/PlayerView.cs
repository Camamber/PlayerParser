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

        public void Update(Player player, bool withPhoto = true)
        {
            if (player != null)
            {
                lblNickname.Text = player.Nickname;

                pbPhoto.Image = withPhoto?GetPhoto(player.Photo): new Bitmap(Properties.Resources.post2); ;
                lblName.Text = player.Name;
                lblBirth.Text = player.Birth == new DateTime() ? "<Empty>" : player.Birth.ToString();
                lblCountry.Text = player.Country;
                lblStatus.Text = player.Status;
                lblRole.Text = player.Role;
                lblEarnings.Text = player.TotalEarnings;
            }
        }

        private Image GetPhoto(string url)
        {
            Image img;
            using (WebClient wc = new WebClient())
            {
                img = Image.FromStream(new MemoryStream(wc.DownloadData(url)));
            }
            return img;
        }
    }
}