namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnRetrievePlayers = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tslSuccess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnParse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.slideSwitch = new System.Windows.Forms.TrackBar();
            this.panelThread = new System.Windows.Forms.Panel();
            this.panelStep = new System.Windows.Forms.Panel();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.lblStep = new System.Windows.Forms.Label();
            this.panelParse = new System.Windows.Forms.Panel();
            this.cbLive = new System.Windows.Forms.CheckBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideSwitch)).BeginInit();
            this.panelThread.SuspendLayout();
            this.panelStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            this.panelParse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUrl.Location = new System.Drawing.Point(58, 9);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(391, 23);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUrl.Location = new System.Drawing.Point(12, 12);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(40, 17);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            // 
            // btnRetrievePlayers
            // 
            this.btnRetrievePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrievePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrievePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRetrievePlayers.Location = new System.Drawing.Point(457, 5);
            this.btnRetrievePlayers.Name = "btnRetrievePlayers";
            this.btnRetrievePlayers.Size = new System.Drawing.Size(75, 40);
            this.btnRetrievePlayers.TabIndex = 2;
            this.btnRetrievePlayers.Text = "Retrieve Players";
            this.btnRetrievePlayers.UseVisualStyleBackColor = true;
            this.btnRetrievePlayers.Click += new System.EventHandler(this.btnRetrievePlayers_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(3, 3);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(226, 390);
            this.lbPlayers.TabIndex = 3;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.lbPlayers_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus,
            this.tspbProgress,
            this.tslSuccess,
            this.tslError,
            this.tslLeft,
            this.tslThreads});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.AutoSize = false;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(100, 17);
            this.tslStatus.Text = "Status: None";
            this.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbProgress
            // 
            this.tspbProgress.Margin = new System.Windows.Forms.Padding(1, 3, 15, 3);
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tslSuccess
            // 
            this.tslSuccess.AutoSize = false;
            this.tslSuccess.ForeColor = System.Drawing.Color.Green;
            this.tslSuccess.Name = "tslSuccess";
            this.tslSuccess.Size = new System.Drawing.Size(80, 17);
            this.tslSuccess.Text = "Success: 0";
            this.tslSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslError
            // 
            this.tslError.AutoSize = false;
            this.tslError.ForeColor = System.Drawing.Color.Red;
            this.tslError.Name = "tslError";
            this.tslError.Size = new System.Drawing.Size(70, 17);
            this.tslError.Text = "Error: 0";
            this.tslError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslLeft
            // 
            this.tslLeft.AutoSize = false;
            this.tslLeft.ForeColor = System.Drawing.Color.Blue;
            this.tslLeft.Name = "tslLeft";
            this.tslLeft.Size = new System.Drawing.Size(70, 17);
            this.tslLeft.Text = "Left: 0";
            this.tslLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslThreads
            // 
            this.tslThreads.ForeColor = System.Drawing.Color.Indigo;
            this.tslThreads.Name = "tslThreads";
            this.tslThreads.Size = new System.Drawing.Size(61, 17);
            this.tslThreads.Text = "Threads: 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.79749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.20251F));
            this.tableLayoutPanel1.Controls.Add(this.lbPlayers, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 396);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParse.Location = new System.Drawing.Point(454, 4);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 30);
            this.btnParse.TabIndex = 7;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(457, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 40);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Divide by:";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThreads.Location = new System.Drawing.Point(6, 11);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(65, 17);
            this.lblThreads.TabIndex = 12;
            this.lblThreads.Text = "Threads:";
            // 
            // numThreads
            // 
            this.numThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numThreads.Location = new System.Drawing.Point(77, 9);
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(60, 23);
            this.numThreads.TabIndex = 14;
            this.numThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.ValueChanged += new System.EventHandler(this.numThreads_ValueChanged);
            // 
            // slideSwitch
            // 
            this.slideSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.slideSwitch.Location = new System.Drawing.Point(172, -4);
            this.slideSwitch.Maximum = 1;
            this.slideSwitch.Name = "slideSwitch";
            this.slideSwitch.Size = new System.Drawing.Size(112, 45);
            this.slideSwitch.TabIndex = 16;
            this.slideSwitch.Scroll += new System.EventHandler(this.slideSwitch_Scroll);
            // 
            // panelThread
            // 
            this.panelThread.Controls.Add(this.numThreads);
            this.panelThread.Controls.Add(this.lblThreads);
            this.panelThread.Enabled = false;
            this.panelThread.Location = new System.Drawing.Point(306, 0);
            this.panelThread.Name = "panelThread";
            this.panelThread.Size = new System.Drawing.Size(140, 39);
            this.panelThread.TabIndex = 17;
            // 
            // panelStep
            // 
            this.panelStep.Controls.Add(this.numStep);
            this.panelStep.Controls.Add(this.lblStep);
            this.panelStep.Location = new System.Drawing.Point(12, 0);
            this.panelStep.Name = "panelStep";
            this.panelStep.Size = new System.Drawing.Size(140, 39);
            this.panelStep.TabIndex = 18;
            // 
            // numStep
            // 
            this.numStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numStep.Location = new System.Drawing.Point(50, 9);
            this.numStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(60, 23);
            this.numStep.TabIndex = 14;
            this.numStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStep.ValueChanged += new System.EventHandler(this.numStep_ValueChanged);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep.Location = new System.Drawing.Point(3, 11);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(41, 17);
            this.lblStep.TabIndex = 12;
            this.lblStep.Text = "Step:";
            // 
            // panelParse
            // 
            this.panelParse.Controls.Add(this.btnAbort);
            this.panelParse.Controls.Add(this.label1);
            this.panelParse.Controls.Add(this.panelStep);
            this.panelParse.Controls.Add(this.btnParse);
            this.panelParse.Controls.Add(this.panelThread);
            this.panelParse.Controls.Add(this.slideSwitch);
            this.panelParse.Enabled = false;
            this.panelParse.Location = new System.Drawing.Point(3, 48);
            this.panelParse.Margin = new System.Windows.Forms.Padding(0);
            this.panelParse.Name = "panelParse";
            this.panelParse.Size = new System.Drawing.Size(541, 38);
            this.panelParse.TabIndex = 19;
            // 
            // cbLive
            // 
            this.cbLive.AutoSize = true;
            this.cbLive.Location = new System.Drawing.Point(363, 34);
            this.cbLive.Name = "cbLive";
            this.cbLive.Size = new System.Drawing.Size(86, 17);
            this.cbLive.TabIndex = 20;
            this.cbLive.Text = "Live preview";
            this.cbLive.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbort.Location = new System.Drawing.Point(454, 4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 30);
            this.btnAbort.TabIndex = 19;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 506);
            this.Controls.Add(this.cbLive);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRetrievePlayers);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.panelParse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Player Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideSwitch)).EndInit();
            this.panelThread.ResumeLayout(false);
            this.panelThread.PerformLayout();
            this.panelStep.ResumeLayout(false);
            this.panelStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            this.panelParse.ResumeLayout(false);
            this.panelParse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnRetrievePlayers;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripStatusLabel tslSuccess;
        private System.Windows.Forms.ToolStripStatusLabel tslError;
        private System.Windows.Forms.ToolStripStatusLabel tslLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.TrackBar slideSwitch;
        private System.Windows.Forms.Panel panelThread;
        private System.Windows.Forms.Panel panelStep;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Panel panelParse;
        private System.Windows.Forms.ToolStripStatusLabel tslThreads;
        private System.Windows.Forms.CheckBox cbLive;
        private System.Windows.Forms.Button btnAbort;
    }
}

