using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        ParseHelper parserHelper;
        PlayerView playerView;
        int left, succes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerView = new PlayerView();
            tableLayoutPanel1.Controls.Add(playerView, 1, 0);
        }

        private void btnRetrievePlayers_Click(object sender, EventArgs e)
        {
            //https://liquipedia.net/dota2/Players_(all)
            try
            {
                parserHelper = new ParseHelper(tbUrl.Text);
                parserHelper.OnPlayerProcessed += Parser_OnPlayerProcessed; ;
                tspbProgress.Maximum = parserHelper.PlayersLinksCount;
                left = parserHelper.PlayersLinksCount;
                succes = 0;
                tslLeft.Text = $"Left: {left}";
                tslSuccess.Text = $"Success: {succes}";
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecievePlayer(Player player)
        {
            tspbProgress.Increment(1);
            left--; succes++;
            tslLeft.Text = $"Left: {left}";
            tslSuccess.Text = $"Success: {succes}";
            lbPlayers.Items.Add(player.Nickname);
            playerView.Update(player);
            
        }

        private void Parser_OnPlayerProcessed(Player player)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Player>((p) => {
                    RecievePlayer(p);
                }), player);
            }
            else
            {
                RecievePlayer(player);
            }
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerView.Update(parserHelper.GetPlayerByNickname(lbPlayers.SelectedItem.ToString()));
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            parserHelper.Parse();
        }
    }
}
