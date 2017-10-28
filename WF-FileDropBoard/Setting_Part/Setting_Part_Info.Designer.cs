namespace WF_FileDropBoard {
    partial class Setting_Part_Info {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Setting_TileTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_InfoDescLabel = new System.Windows.Forms.Label();
            this.Setting_Info_MainP = new System.Windows.Forms.Panel();
            this.Settings_Info_VerLabel = new System.Windows.Forms.Label();
            this.Settings_Info_ProdL = new System.Windows.Forms.Label();
            this.Settings_Info_ContactL = new System.Windows.Forms.LinkLabel();
            this.Setting_TileTLP.SuspendLayout();
            this.Setting_Info_MainP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_TileTLP
            // 
            this.Setting_TileTLP.ColumnCount = 1;
            this.Setting_TileTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_TileTLP.Controls.Add(this.Settings_InfoDescLabel, 0, 0);
            this.Setting_TileTLP.Controls.Add(this.Setting_Info_MainP, 0, 1);
            this.Setting_TileTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_TileTLP.Location = new System.Drawing.Point(0, 0);
            this.Setting_TileTLP.Name = "Setting_TileTLP";
            this.Setting_TileTLP.RowCount = 2;
            this.Setting_TileTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Setting_TileTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_TileTLP.Size = new System.Drawing.Size(284, 261);
            this.Setting_TileTLP.TabIndex = 0;
            // 
            // Settings_InfoDescLabel
            // 
            this.Settings_InfoDescLabel.AutoSize = true;
            this.Settings_InfoDescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_InfoDescLabel.Font = new System.Drawing.Font("メイリオ", 11F);
            this.Settings_InfoDescLabel.Location = new System.Drawing.Point(3, 0);
            this.Settings_InfoDescLabel.Name = "Settings_InfoDescLabel";
            this.Settings_InfoDescLabel.Size = new System.Drawing.Size(278, 28);
            this.Settings_InfoDescLabel.TabIndex = 1;
            this.Settings_InfoDescLabel.Text = "情報";
            this.Settings_InfoDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Setting_Info_MainP
            // 
            this.Setting_Info_MainP.Controls.Add(this.Settings_Info_VerLabel);
            this.Setting_Info_MainP.Controls.Add(this.Settings_Info_ProdL);
            this.Setting_Info_MainP.Controls.Add(this.Settings_Info_ContactL);
            this.Setting_Info_MainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Info_MainP.Location = new System.Drawing.Point(5, 33);
            this.Setting_Info_MainP.Margin = new System.Windows.Forms.Padding(5);
            this.Setting_Info_MainP.Name = "Setting_Info_MainP";
            this.Setting_Info_MainP.Size = new System.Drawing.Size(274, 223);
            this.Setting_Info_MainP.TabIndex = 2;
            // 
            // Settings_Info_VerLabel
            // 
            this.Settings_Info_VerLabel.AutoSize = true;
            this.Settings_Info_VerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Info_VerLabel.Location = new System.Drawing.Point(0, 24);
            this.Settings_Info_VerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.Settings_Info_VerLabel.Name = "Settings_Info_VerLabel";
            this.Settings_Info_VerLabel.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_Info_VerLabel.Size = new System.Drawing.Size(80, 18);
            this.Settings_Info_VerLabel.TabIndex = 4;
            this.Settings_Info_VerLabel.Text = "Version : Null";
            // 
            // Settings_Info_ProdL
            // 
            this.Settings_Info_ProdL.AutoSize = true;
            this.Settings_Info_ProdL.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Info_ProdL.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Settings_Info_ProdL.Location = new System.Drawing.Point(0, 0);
            this.Settings_Info_ProdL.Name = "Settings_Info_ProdL";
            this.Settings_Info_ProdL.Size = new System.Drawing.Size(122, 24);
            this.Settings_Info_ProdL.TabIndex = 2;
            this.Settings_Info_ProdL.Text = "FileDropBoard";
            // 
            // Settings_Info_ContactL
            // 
            this.Settings_Info_ContactL.ActiveLinkColor = System.Drawing.Color.Green;
            this.Settings_Info_ContactL.AutoSize = true;
            this.Settings_Info_ContactL.DisabledLinkColor = System.Drawing.Color.Gray;
            this.Settings_Info_ContactL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Info_ContactL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.Settings_Info_ContactL.Location = new System.Drawing.Point(0, 211);
            this.Settings_Info_ContactL.Name = "Settings_Info_ContactL";
            this.Settings_Info_ContactL.Size = new System.Drawing.Size(169, 12);
            this.Settings_Info_ContactL.TabIndex = 1;
            this.Settings_Info_ContactL.TabStop = true;
            this.Settings_Info_ContactL.Text = "製作者 : HiShis.yfmn@gmail.com";
            this.Settings_Info_ContactL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Settings_Info_ContactL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Settings_Info_ContactL_LinkClicked);
            // 
            // Setting_Part_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Setting_TileTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting_Part_Info";
            this.Text = "Setting_Part_Info";
            this.Load += new System.EventHandler(this.Setting_Part_Info_Load);
            this.Setting_TileTLP.ResumeLayout(false);
            this.Setting_TileTLP.PerformLayout();
            this.Setting_Info_MainP.ResumeLayout(false);
            this.Setting_Info_MainP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Setting_TileTLP;
        private System.Windows.Forms.Label Settings_InfoDescLabel;
        private System.Windows.Forms.Panel Setting_Info_MainP;
        private System.Windows.Forms.LinkLabel Settings_Info_ContactL;
        private System.Windows.Forms.Label Settings_Info_ProdL;
        private System.Windows.Forms.Label Settings_Info_VerLabel;
    }
}