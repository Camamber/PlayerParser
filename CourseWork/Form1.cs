using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        bool aborted = false;
        int left, succes, error;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUrl.Text = @"https://liquipedia.net/dota2/Players_(all)";
            playerView = new PlayerView();
            tableLayoutPanel1.Controls.Add(playerView, 1, 0);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbUrl.Text = openFileDialog1.FileName;
                btnBrowse.Visible = false;
            }
        }

        private void btnRetrievePlayers_Click(object sender, EventArgs e)
        {
            //https://liquipedia.net/dota2/Players_(all)
            try
            {
                if (File.Exists(tbUrl.Text))
                    parserHelper = new ParseHelper(tbUrl.Text);
                else
                    parserHelper = new ParseHelper(new Uri(tbUrl.Text));
                parserHelper.OnPlayerProcessed += Parser_OnPlayerProcessed;
                parserHelper.OnProcessed += ParserHelper_OnProcessed;
                tspbProgress.Maximum = parserHelper.PlayersLinksCount;
                left = parserHelper.PlayersLinksCount;
                succes = 0;
                error = 0;
                tslLeft.Text = $"Left: {left}";
                tslError.Text = $"Error: {error}";
                tslSuccess.Text = $"Success: {succes}";
                numStep.Maximum = numThreads.Maximum = parserHelper.PlayersLinksCount;
                panelParse.Enabled = true;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                panelParse.Enabled = false;
                tslStatus.Text = "Status: Error";
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            aborted = false;
            lbPlayers.Items.Clear();
            if (parserHelper != null)
            {
                parserHelper.Parse(slideSwitch.Value == 0 ? (int)numStep.Value : (int)numThreads.Value, slideSwitch.Value == 0);
                tslStatus.Text = "Status: Parsing";
                btnAbort.Visible = true;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            if (parserHelper != null)
            {
                aborted = true;
                parserHelper.Abort();
            }
        }

        private void RecievePlayer(Player player)
        {
            tspbProgress.Increment(1);
            left--; succes++;
            tslLeft.Text = $"Left: {left}";
            tslSuccess.Text = $"Success: {succes}";
            lbPlayers.Items.Add(player.Nickname);
            if (cbLive.Checked)
                playerView.Update(player, false);

        }

        private void Parser_OnPlayerProcessed(Player player, bool error)
        {
            if (!error)
                succes++;
            else
                this.error++;

            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Player>((p) =>
                {
                    RecievePlayer(p);
                }), player);
            }
            else
            {
                RecievePlayer(player);
            }
        }

        private void DoneParsing()
        {
            btnAbort.Visible = false;
            if (!aborted)
                tslStatus.Text = "Status: Success";
            else
                tslStatus.Text = "Status: Aborted";
        }

        private void ParserHelper_OnProcessed()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { DoneParsing(); }));
            }
            else
            {
                DoneParsing();
            }
           
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            btnBrowse.Visible = tbUrl.Text == "";
        }

        private void numStep_ValueChanged(object sender, EventArgs e)
        {
            tslThreads.Text = $"Threads:  {Math.Ceiling(parserHelper.PlayersLinksCount / numStep.Value).ToString()}";
        }

        private void numThreads_ValueChanged(object sender, EventArgs e)
        {
            tslThreads.Text = $"Threads:  {numThreads.Value.ToString()}";

        }

        private void slideSwitch_Scroll(object sender, EventArgs e)
        {
            tslThreads.Text = $"Threads:  { (slideSwitch.Value == 0 ? Math.Ceiling(parserHelper.PlayersLinksCount / numStep.Value).ToString() : numThreads.Value.ToString())}";
            panelStep.Enabled = slideSwitch.Value == 0;
            panelThread.Enabled = slideSwitch.Value == 1;
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerView.Update(parserHelper.GetPlayerByNickname(lbPlayers.SelectedItem.ToString()));
        }
    }
}
