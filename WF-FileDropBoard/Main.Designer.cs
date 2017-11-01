using System.Collections.Generic;

namespace WF_FileDropBoard
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DDLabel = new System.Windows.Forms.Label();
            this.MenuButtonProductionTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuPic = new System.Windows.Forms.PictureBox();
            this.MenuProductionTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.DragProductionTimer = new System.Windows.Forms.Timer(this.components);
            this.TileDragTimer = new System.Windows.Forms.Timer(this.components);
            this.DragUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoProductionTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.MainGRPBox = new System.Windows.Forms.PictureBox();
            this.DisposeBox = new System.Windows.Forms.PictureBox();
            this.NotiTLP = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGRPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisposeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DDLabel
            // 
            this.DDLabel.AutoSize = true;
            this.DDLabel.BackColor = System.Drawing.Color.Transparent;
            this.DDLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DDLabel.Location = new System.Drawing.Point(89, 116);
            this.DDLabel.Name = "DDLabel";
            this.DDLabel.Size = new System.Drawing.Size(92, 18);
            this.DDLabel.TabIndex = 0;
            this.DDLabel.Text = "ここにドロップ";
            this.DDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuButtonProductionTimer
            // 
            this.MenuButtonProductionTimer.Interval = 10;
            this.MenuButtonProductionTimer.Tick += new System.EventHandler(this.MenuButtonProductionTimer_Tick);
            // 
            // MenuPic
            // 
            this.MenuPic.BackColor = System.Drawing.Color.Transparent;
            this.MenuPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPic.Location = new System.Drawing.Point(12, 12);
            this.MenuPic.Name = "MenuPic";
            this.MenuPic.Size = new System.Drawing.Size(70, 70);
            this.MenuPic.TabIndex = 4;
            this.MenuPic.TabStop = false;
            this.MenuPic.Click += new System.EventHandler(this.MenuPic_Click);
            this.MenuPic.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPic_Paint);
            this.MenuPic.MouseEnter += new System.EventHandler(this.MenuPic_MouseEnter);
            this.MenuPic.MouseLeave += new System.EventHandler(this.MenuPic_MouseLeave);
            // 
            // MenuProductionTimer
            // 
            this.MenuProductionTimer.Interval = 10;
            this.MenuProductionTimer.Tick += new System.EventHandler(this.MenuProductionTimer_Tick);
            // 
            // MenuCloseTimer
            // 
            this.MenuCloseTimer.Tick += new System.EventHandler(this.MenuCloseTimer_Tick);
            // 
            // DragProductionTimer
            // 
            this.DragProductionTimer.Interval = 10;
            this.DragProductionTimer.Tick += new System.EventHandler(this.DragProductionTimer_Tick);
            // 
            // TileDragTimer
            // 
            this.TileDragTimer.Interval = 200;
            this.TileDragTimer.Tick += new System.EventHandler(this.TileDragTimer_Tick);
            // 
            // DragUpdateTimer
            // 
            this.DragUpdateTimer.Interval = 15;
            this.DragUpdateTimer.Tick += new System.EventHandler(this.DragUpdateTimer_Tick);
            // 
            // InfoProductionTimer
            // 
            this.InfoProductionTimer.Interval = 15;
            this.InfoProductionTimer.Tick += new System.EventHandler(this.InfoProductionTimer_Tick);
            // 
            // InfoCloseTimer
            // 
            this.InfoCloseTimer.Interval = 10000;
            this.InfoCloseTimer.Tick += new System.EventHandler(this.InfoCloseTimer_Tick);
            // 
            // MainGRPBox
            // 
            this.MainGRPBox.BackColor = System.Drawing.Color.White;
            this.MainGRPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGRPBox.Location = new System.Drawing.Point(0, 0);
            this.MainGRPBox.Name = "MainGRPBox";
            this.MainGRPBox.Size = new System.Drawing.Size(284, 261);
            this.MainGRPBox.TabIndex = 5;
            this.MainGRPBox.TabStop = false;
            this.MainGRPBox.Click += new System.EventHandler(this.MainGRPBox_Click);
            this.MainGRPBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainGRPBox_DragDrop);
            this.MainGRPBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGRPBox_Paint);
            this.MainGRPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainGRPBox_MouseDown);
            this.MainGRPBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainGRPBox_MouseUp);
            // 
            // DisposeBox
            // 
            this.DisposeBox.BackColor = System.Drawing.Color.Transparent;
            this.DisposeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisposeBox.Image = ((System.Drawing.Image)(resources.GetObject("DisposeBox.Image")));
            this.DisposeBox.Location = new System.Drawing.Point(64, 159);
            this.DisposeBox.Name = "DisposeBox";
            this.DisposeBox.Size = new System.Drawing.Size(50, 50);
            this.DisposeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisposeBox.TabIndex = 6;
            this.DisposeBox.TabStop = false;
            this.DisposeBox.Visible = false;
            // 
            // NotiTLP
            // 
            this.NotiTLP.ColumnCount = 2;
            this.NotiTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotiTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotiTLP.Location = new System.Drawing.Point(141, 12);
            this.NotiTLP.Name = "NotiTLP";
            this.NotiTLP.RowCount = 1;
            this.NotiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotiTLP.Size = new System.Drawing.Size(118, 50);
            this.NotiTLP.TabIndex = 7;
            this.NotiTLP.Visible = false;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NotiTLP);
            this.Controls.Add(this.DisposeBox);
            this.Controls.Add(this.MenuPic);
            this.Controls.Add(this.DDLabel);
            this.Controls.Add(this.MainGRPBox);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FileDropBoard";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Deactivate += new System.EventHandler(this.MainBox_Deactivate);
            this.Load += new System.EventHandler(this.MainBox_Load);
            this.LocationChanged += new System.EventHandler(this.MainBox_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainBox_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainBox_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainBox_DragEnter);
            this.DragLeave += new System.EventHandler(this.MainBox_DragLeave);
            this.MouseLeave += new System.EventHandler(this.MainBox_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGRPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisposeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DDLabel;
        private System.Windows.Forms.Timer MenuButtonProductionTimer;
        private System.Windows.Forms.PictureBox MenuPic;
        public System.Windows.Forms.Timer MenuProductionTimer;
        private System.Windows.Forms.Timer MenuCloseTimer;
        private System.Windows.Forms.Timer DragProductionTimer;
        private System.Windows.Forms.Timer TileDragTimer;
        private System.Windows.Forms.Timer DragUpdateTimer;
        private System.Windows.Forms.Timer InfoProductionTimer;
        public System.Windows.Forms.Timer InfoCloseTimer;
        public System.Windows.Forms.PictureBox MainGRPBox;
        private System.Windows.Forms.PictureBox DisposeBox;
        /*
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label InfoBackLabel;
        */
        public Dictionary<string,object> AdditionalControls = new Dictionary<string, object>();
        public System.Windows.Forms.TableLayoutPanel NotiTLP;
    }
}

