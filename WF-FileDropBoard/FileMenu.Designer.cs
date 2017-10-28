namespace WF_FileDropBoard {
    partial class FileMenu {
        /// <summary>
        /// Required designer variable.
        /// But you CANNOT OPEN THIS FILE with windows form designer.
        /// If you're going to edit this file, you should edit without designer. JUST YOUR SKILL!
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.FileMenuTLP = new System.Windows.Forms.TableLayoutPanel();
            this.FileMenu_DescL = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FM_ExitLabel = new System.Windows.Forms.Label();
            this.FM_GoSettingsLabel = new System.Windows.Forms.Label();
            this.FM_FileOpenLabel = new System.Windows.Forms.Label();
            this.FM_AllRemoveLabel = new System.Windows.Forms.Label();
            this.FM_FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileMenuTLP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuTLP
            // 
            this.FileMenuTLP.ColumnCount = 1;
            this.FileMenuTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileMenuTLP.Controls.Add(this.FileMenu_DescL, 0, 0);
            this.FileMenuTLP.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.FileMenuTLP.Controls.Add(this.FM_FileOpenLabel, 0, 1);
            this.FileMenuTLP.Controls.Add(this.FM_AllRemoveLabel, 0, 2);
            this.FileMenuTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileMenuTLP.Location = new System.Drawing.Point(0, 0);
            this.FileMenuTLP.Margin = new System.Windows.Forms.Padding(0);
            this.FileMenuTLP.Name = "FileMenuTLP";
            this.FileMenuTLP.RowCount = 5;
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FileMenuTLP.Size = new System.Drawing.Size(150, 300);
            this.FileMenuTLP.TabIndex = 0;
            // 
            // FileMenu_DescL
            // 
            this.FileMenu_DescL.BackColor = System.Drawing.Color.Aqua;
            this.FileMenu_DescL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileMenu_DescL.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FileMenu_DescL.Location = new System.Drawing.Point(0, 0);
            this.FileMenu_DescL.Margin = new System.Windows.Forms.Padding(0);
            this.FileMenu_DescL.Name = "FileMenu_DescL";
            this.FileMenu_DescL.Size = new System.Drawing.Size(150, 20);
            this.FileMenu_DescL.TabIndex = 0;
            this.FileMenu_DescL.Text = "メニュー";
            this.FileMenu_DescL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FM_ExitLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FM_GoSettingsLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 190);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FM_ExitLabel
            // 
            this.FM_ExitLabel.AutoSize = true;
            this.FM_ExitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FM_ExitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FM_ExitLabel.Location = new System.Drawing.Point(0, 160);
            this.FM_ExitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FM_ExitLabel.Name = "FM_ExitLabel";
            this.FM_ExitLabel.Size = new System.Drawing.Size(150, 30);
            this.FM_ExitLabel.TabIndex = 0;
            this.FM_ExitLabel.Text = "終了する";
            this.FM_ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FM_ExitLabel.Click += new System.EventHandler(this.FM_ExitLabel_Click);
            this.FM_ExitLabel.MouseEnter += new System.EventHandler(this.FM_ExitLabel_MouseEnter);
            this.FM_ExitLabel.MouseLeave += new System.EventHandler(this.FM_ExitLabel_MouseLeave);
            // 
            // FM_GoSettingsLabel
            // 
            this.FM_GoSettingsLabel.AutoSize = true;
            this.FM_GoSettingsLabel.BackColor = System.Drawing.Color.White;
            this.FM_GoSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FM_GoSettingsLabel.Location = new System.Drawing.Point(0, 130);
            this.FM_GoSettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FM_GoSettingsLabel.Name = "FM_GoSettingsLabel";
            this.FM_GoSettingsLabel.Size = new System.Drawing.Size(150, 30);
            this.FM_GoSettingsLabel.TabIndex = 1;
            this.FM_GoSettingsLabel.Text = "設定";
            this.FM_GoSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FM_GoSettingsLabel.Click += new System.EventHandler(this.FM_GoSettingsLabel_Click);
            this.FM_GoSettingsLabel.MouseEnter += new System.EventHandler(this.FM_GoSettingsLabel_MouseEnter);
            this.FM_GoSettingsLabel.MouseLeave += new System.EventHandler(this.FM_GoSettingsLabel_MouseLeave);
            // 
            // FM_FileOpenLabel
            // 
            this.FM_FileOpenLabel.AutoSize = true;
            this.FM_FileOpenLabel.BackColor = System.Drawing.Color.White;
            this.FM_FileOpenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FM_FileOpenLabel.ForeColor = System.Drawing.Color.Black;
            this.FM_FileOpenLabel.Location = new System.Drawing.Point(0, 20);
            this.FM_FileOpenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FM_FileOpenLabel.Name = "FM_FileOpenLabel";
            this.FM_FileOpenLabel.Size = new System.Drawing.Size(150, 30);
            this.FM_FileOpenLabel.TabIndex = 3;
            this.FM_FileOpenLabel.Text = "開く";
            this.FM_FileOpenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FM_FileOpenLabel.Click += new System.EventHandler(this.FM_FileOpenLabel_Click);
            this.FM_FileOpenLabel.MouseEnter += new System.EventHandler(this.FM_FileOpenLabel_MouseEnter);
            this.FM_FileOpenLabel.MouseHover += new System.EventHandler(this.FM_FileOpenLabel_MouseHover);
            // 
            // FM_AllRemoveLabel
            // 
            this.FM_AllRemoveLabel.AutoSize = true;
            this.FM_AllRemoveLabel.BackColor = System.Drawing.Color.White;
            this.FM_AllRemoveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FM_AllRemoveLabel.Location = new System.Drawing.Point(0, 50);
            this.FM_AllRemoveLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FM_AllRemoveLabel.Name = "FM_AllRemoveLabel";
            this.FM_AllRemoveLabel.Size = new System.Drawing.Size(150, 30);
            this.FM_AllRemoveLabel.TabIndex = 2;
            this.FM_AllRemoveLabel.Text = "全削除";
            this.FM_AllRemoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FM_AllRemoveLabel.Click += new System.EventHandler(this.FM_AllRemoveLabel_Click);
            this.FM_AllRemoveLabel.MouseEnter += new System.EventHandler(this.FM_AllRemoveLabel_MouseEnter);
            this.FM_AllRemoveLabel.MouseLeave += new System.EventHandler(this.FM_AllRemoveLabel_MouseLeave);
            // 
            // FM_FileOpenDialog
            // 
            this.FM_FileOpenDialog.Multiselect = true;
            this.FM_FileOpenDialog.RestoreDirectory = true;
            this.FM_FileOpenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FM_FileOpenDialog_FileOk);
            // 
            // FileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(150, 300);
            this.Controls.Add(this.FileMenuTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileMenu";
            this.Text = "FileMenu";
            this.Load += new System.EventHandler(this.FileMenu_Load);
            this.LocationChanged += new System.EventHandler(this.FileMenu_LocationChanged);
            this.FileMenuTLP.ResumeLayout(false);
            this.FileMenuTLP.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FileMenuTLP;
        private System.Windows.Forms.Label FileMenu_DescL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FM_ExitLabel;
        private System.Windows.Forms.Label FM_AllRemoveLabel;
        private System.Windows.Forms.Label FM_GoSettingsLabel;
        private System.Windows.Forms.Label FM_FileOpenLabel;
        private System.Windows.Forms.OpenFileDialog FM_FileOpenDialog;
    }
}