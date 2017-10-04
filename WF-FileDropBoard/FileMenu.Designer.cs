namespace WF_FileDropBoard {
    partial class FileMenu {
        /// <summary>
        /// Required designer variable.
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
            this.FileMenu_ExitLabel = new System.Windows.Forms.Label();
            this.FileMenuTLP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuTLP
            // 
            this.FileMenuTLP.ColumnCount = 1;
            this.FileMenuTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileMenuTLP.Controls.Add(this.FileMenu_DescL, 0, 0);
            this.FileMenuTLP.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.FileMenuTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileMenuTLP.Location = new System.Drawing.Point(0, 0);
            this.FileMenuTLP.Margin = new System.Windows.Forms.Padding(0);
            this.FileMenuTLP.Name = "FileMenuTLP";
            this.FileMenuTLP.RowCount = 2;
            this.FileMenuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.tableLayoutPanel1.Controls.Add(this.FileMenu_ExitLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 280);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FileMenu_ExitLabel
            // 
            this.FileMenu_ExitLabel.AutoSize = true;
            this.FileMenu_ExitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileMenu_ExitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileMenu_ExitLabel.Location = new System.Drawing.Point(0, 250);
            this.FileMenu_ExitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FileMenu_ExitLabel.Name = "FileMenu_ExitLabel";
            this.FileMenu_ExitLabel.Size = new System.Drawing.Size(150, 30);
            this.FileMenu_ExitLabel.TabIndex = 0;
            this.FileMenu_ExitLabel.Text = "終了する";
            this.FileMenu_ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileMenu_ExitLabel.Click += new System.EventHandler(this.FileMenu_ExitLabel_Click);
            this.FileMenu_ExitLabel.MouseEnter += new System.EventHandler(this.FileMenu_ExitLabel_MouseEnter);
            this.FileMenu_ExitLabel.MouseLeave += new System.EventHandler(this.FileMenu_ExitLabel_MouseLeave);
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
            this.LocationChanged += new System.EventHandler(this.FileMenu_LocationChanged);
            this.FileMenuTLP.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FileMenuTLP;
        private System.Windows.Forms.Label FileMenu_DescL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FileMenu_ExitLabel;
    }
}