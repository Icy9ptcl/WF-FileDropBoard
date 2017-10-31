namespace WF_FileDropBoard {
    partial class Setting {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.SettingsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_PageControlTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_PageControl_L = new System.Windows.Forms.Label();
            this.Settings_PageControl_R = new System.Windows.Forms.Label();
            this.Settings_PageLabel = new System.Windows.Forms.Label();
            this.Settings_HeaderTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_DescLabel = new System.Windows.Forms.Label();
            this.Settings_UpdateLabel = new System.Windows.Forms.Label();
            this.SettingsTLP.SuspendLayout();
            this.Settings_PageControlTLP.SuspendLayout();
            this.Settings_HeaderTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTLP
            // 
            this.SettingsTLP.ColumnCount = 1;
            this.SettingsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsTLP.Controls.Add(this.Settings_PageControlTLP, 0, 2);
            this.SettingsTLP.Controls.Add(this.Settings_HeaderTLP, 0, 0);
            this.SettingsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTLP.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SettingsTLP.Location = new System.Drawing.Point(0, 0);
            this.SettingsTLP.Name = "SettingsTLP";
            this.SettingsTLP.RowCount = 3;
            this.SettingsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SettingsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsTLP.Size = new System.Drawing.Size(284, 261);
            this.SettingsTLP.TabIndex = 0;
            // 
            // Settings_PageControlTLP
            // 
            this.Settings_PageControlTLP.ColumnCount = 3;
            this.Settings_PageControlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Settings_PageControlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Settings_PageControlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Settings_PageControlTLP.Controls.Add(this.Settings_PageControl_L, 0, 0);
            this.Settings_PageControlTLP.Controls.Add(this.Settings_PageControl_R, 2, 0);
            this.Settings_PageControlTLP.Controls.Add(this.Settings_PageLabel, 1, 0);
            this.Settings_PageControlTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_PageControlTLP.Location = new System.Drawing.Point(0, 241);
            this.Settings_PageControlTLP.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_PageControlTLP.Name = "Settings_PageControlTLP";
            this.Settings_PageControlTLP.RowCount = 1;
            this.Settings_PageControlTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Settings_PageControlTLP.Size = new System.Drawing.Size(284, 20);
            this.Settings_PageControlTLP.TabIndex = 2;
            // 
            // Settings_PageControl_L
            // 
            this.Settings_PageControl_L.AutoSize = true;
            this.Settings_PageControl_L.BackColor = System.Drawing.Color.Silver;
            this.Settings_PageControl_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_PageControl_L.Location = new System.Drawing.Point(0, 0);
            this.Settings_PageControl_L.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_PageControl_L.Name = "Settings_PageControl_L";
            this.Settings_PageControl_L.Size = new System.Drawing.Size(80, 20);
            this.Settings_PageControl_L.TabIndex = 0;
            this.Settings_PageControl_L.Text = "←前ページ";
            this.Settings_PageControl_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_PageControl_L.Click += new System.EventHandler(this.Settings_PageControl_L_Click);
            this.Settings_PageControl_L.MouseEnter += new System.EventHandler(this.Settings_PageControl_L_MouseEnter);
            this.Settings_PageControl_L.MouseLeave += new System.EventHandler(this.Settings_PageControl_L_MouseLeave);
            // 
            // Settings_PageControl_R
            // 
            this.Settings_PageControl_R.AutoSize = true;
            this.Settings_PageControl_R.BackColor = System.Drawing.Color.Silver;
            this.Settings_PageControl_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_PageControl_R.Location = new System.Drawing.Point(204, 0);
            this.Settings_PageControl_R.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_PageControl_R.Name = "Settings_PageControl_R";
            this.Settings_PageControl_R.Size = new System.Drawing.Size(80, 20);
            this.Settings_PageControl_R.TabIndex = 1;
            this.Settings_PageControl_R.Text = "次ページ→";
            this.Settings_PageControl_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_PageControl_R.Click += new System.EventHandler(this.Settings_PageControl_R_Click);
            this.Settings_PageControl_R.MouseEnter += new System.EventHandler(this.Settings_PageControl_R_MouseEnter);
            this.Settings_PageControl_R.MouseLeave += new System.EventHandler(this.Settings_PageControl_R_MouseLeave);
            // 
            // Settings_PageLabel
            // 
            this.Settings_PageLabel.AutoSize = true;
            this.Settings_PageLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.Settings_PageLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Settings_PageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_PageLabel.Location = new System.Drawing.Point(80, 0);
            this.Settings_PageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_PageLabel.Name = "Settings_PageLabel";
            this.Settings_PageLabel.Size = new System.Drawing.Size(124, 20);
            this.Settings_PageLabel.TabIndex = 2;
            this.Settings_PageLabel.Text = "Page **/**";
            this.Settings_PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings_HeaderTLP
            // 
            this.Settings_HeaderTLP.ColumnCount = 2;
            this.Settings_HeaderTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Settings_HeaderTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Settings_HeaderTLP.Controls.Add(this.Settings_DescLabel, 0, 0);
            this.Settings_HeaderTLP.Controls.Add(this.Settings_UpdateLabel, 1, 0);
            this.Settings_HeaderTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_HeaderTLP.Location = new System.Drawing.Point(2, 2);
            this.Settings_HeaderTLP.Margin = new System.Windows.Forms.Padding(2);
            this.Settings_HeaderTLP.Name = "Settings_HeaderTLP";
            this.Settings_HeaderTLP.RowCount = 1;
            this.Settings_HeaderTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Settings_HeaderTLP.Size = new System.Drawing.Size(280, 28);
            this.Settings_HeaderTLP.TabIndex = 3;
            // 
            // Settings_DescLabel
            // 
            this.Settings_DescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_DescLabel.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Settings_DescLabel.Location = new System.Drawing.Point(0, 0);
            this.Settings_DescLabel.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_DescLabel.Name = "Settings_DescLabel";
            this.Settings_DescLabel.Size = new System.Drawing.Size(240, 28);
            this.Settings_DescLabel.TabIndex = 1;
            this.Settings_DescLabel.Text = "設定";
            this.Settings_DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings_UpdateLabel
            // 
            this.Settings_UpdateLabel.AutoSize = true;
            this.Settings_UpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_UpdateLabel.Location = new System.Drawing.Point(241, 1);
            this.Settings_UpdateLabel.Margin = new System.Windows.Forms.Padding(1);
            this.Settings_UpdateLabel.Name = "Settings_UpdateLabel";
            this.Settings_UpdateLabel.Size = new System.Drawing.Size(38, 26);
            this.Settings_UpdateLabel.TabIndex = 2;
            this.Settings_UpdateLabel.Text = "更新";
            this.Settings_UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Settings_UpdateLabel.Click += new System.EventHandler(this.Settings_UpdateLabel_Click);
            this.Settings_UpdateLabel.MouseEnter += new System.EventHandler(this.Settings_UpdateLabel_MouseEnter);
            this.Settings_UpdateLabel.MouseLeave += new System.EventHandler(this.Settings_UpdateLabel_MouseLeave);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SettingsTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SettingsTLP.ResumeLayout(false);
            this.Settings_PageControlTLP.ResumeLayout(false);
            this.Settings_PageControlTLP.PerformLayout();
            this.Settings_HeaderTLP.ResumeLayout(false);
            this.Settings_HeaderTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SettingsTLP;
        private System.Windows.Forms.Label Settings_DescLabel;
        private System.Windows.Forms.TableLayoutPanel Settings_PageControlTLP;
        private System.Windows.Forms.Label Settings_PageControl_L;
        private System.Windows.Forms.Label Settings_PageControl_R;
        private System.Windows.Forms.Label Settings_PageLabel;
        private System.Windows.Forms.TableLayoutPanel Settings_HeaderTLP;
        private System.Windows.Forms.Label Settings_UpdateLabel;
    }
}