using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class PlayerView : UserControl
    {
        string playerUrl;
        public PlayerView()
        {
            InitializeComponent();
        }

        public void Update(Player player, bool withPhoto = true)
        {
            playerUrl = player.Url;
            if (player != null)
            {
                lblNickname.Text = player.Nickname;

                pbPhoto.Image = withPhoto ? player.GetPhoto() : new Bitmap(Properties.Resources.post2);
                lblName.Text = player.Name;
                lblBirth.Text = player.Birth == new DateTime() ? "":player.Birth.ToString();
                lblCountry.Text = player.Country;
                lblStatus.Text = player.Status;
                lblRole.Text = player.Role;
                lblEarnings.Text = player.TotalEarnings;
            }
        }

        private void lblNickname_Click(object sender, EventArgs e)
        {
            if(playerUrl!=null  && playerUrl != "")
                System.Diagnostics.Process.Start(playerUrl);
        }
    }
}