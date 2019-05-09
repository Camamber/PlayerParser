namespace CourseWork
{
    partial class PlayerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblDescName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescBirth = new System.Windows.Forms.Label();
            this.lblDescCountry = new System.Windows.Forms.Label();
            this.lblDescStatus = new System.Windows.Forms.Label();
            this.lblDescRole = new System.Windows.Forms.Label();
            this.lblDescEarnings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNickname
            // 
            this.lblNickname.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNickname.ForeColor = System.Drawing.Color.White;
            this.lblNickname.Location = new System.Drawing.Point(0, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(250, 42);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Nickname";
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescName
            // 
            this.lblDescName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescName.Location = new System.Drawing.Point(0, 0);
            this.lblDescName.Name = "lblDescName";
            this.lblDescName.Size = new System.Drawing.Size(122, 26);
            this.lblDescName.TabIndex = 2;
            this.lblDescName.Text = "Name:";
            this.lblDescName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescEarnings, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDescBirth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescCountry, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDescRole, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDescName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 219);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 158);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblDescBirth
            // 
            this.lblDescBirth.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescBirth.Location = new System.Drawing.Point(3, 26);
            this.lblDescBirth.Name = "lblDescBirth";
            this.lblDescBirth.Size = new System.Drawing.Size(51, 20);
            this.lblDescBirth.TabIndex = 3;
            this.lblDescBirth.Text = "Birth:";
            this.lblDescBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescCountry
            // 
            this.lblDescCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescCountry.Location = new System.Drawing.Point(3, 52);
            this.lblDescCountry.Name = "lblDescCountry";
            this.lblDescCountry.Size = new System.Drawing.Size(51, 20);
            this.lblDescCountry.TabIndex = 4;
            this.lblDescCountry.Text = "Country:";
            this.lblDescCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescStatus
            // 
            this.lblDescStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescStatus.Location = new System.Drawing.Point(3, 78);
            this.lblDescStatus.Name = "lblDescStatus";
            this.lblDescStatus.Size = new System.Drawing.Size(51, 20);
            this.lblDescStatus.TabIndex = 5;
            this.lblDescStatus.Text = "Status:";
            this.lblDescStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescRole
            // 
            this.lblDescRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescRole.Location = new System.Drawing.Point(3, 104);
            this.lblDescRole.Name = "lblDescRole";
            this.lblDescRole.Size = new System.Drawing.Size(51, 20);
            this.lblDescRole.TabIndex = 6;
            this.lblDescRole.Text = "Role:";
            this.lblDescRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescEarnings
            // 
            this.lblDescEarnings.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescEarnings.Location = new System.Drawing.Point(3, 130);
            this.lblDescEarnings.Name = "lblDescEarnings";
            this.lblDescEarnings.Size = new System.Drawing.Size(51, 20);
            this.lblDescEarnings.TabIndex = 7;
            this.lblDescEarnings.Text = "Total Earnings:";
            this.lblDescEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(250, 380);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblDescName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescBirth;
        private System.Windows.Forms.Label lblDescCountry;
        private System.Windows.Forms.Label lblDescEarnings;
        private System.Windows.Forms.Label lblDescStatus;
        private System.Windows.Forms.Label lblDescRole;
    }
}
