using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class FileMenu : Form {

        MainBox MB;

        public FileMenu(MainBox MB) {
            this.MB = MB;
            InitializeComponent();
        }

        private Color UnHoverCol = Color.FromArgb(224, 224, 224);
        private Color HoverCol = Color.FromArgb(128, 128, 128);

        private void FileMenu_Load(object sender, EventArgs e) {
            FM_ExitLabel.Font = this.Font;
            FM_AllRemoveLabel.Font = this.Font;

        }

        private void FileMenu_LocationChanged(object sender, EventArgs e) {
            //System.Diagnostics.Debug.Print("Load");
        }

        // E X I T (終了する)

        private void FM_ExitLabel_MouseEnter(object sender, EventArgs e) {
            //ファイルメニューの「終了する」に入ってきた
            FM_ExitLabel.BackColor = HoverCol;
        }

        private void FM_ExitLabel_MouseLeave(object sender, EventArgs e) {
            //ファイルメニューの「終了する」から出た
            FM_ExitLabel.BackColor = UnHoverCol;
        }

        //ファイルメニューの「終了する」がクリックされた
        private void FM_ExitLabel_Click(object sender, EventArgs e) {
            //ファイルメニューを閉じる
            MB.MenuProductionMode = MainBox.ProductionModeE.Leave;
            MB.MenuProductionTimer.Start();

            if (this.MB.InfoProductionMode == MainBox.ProductionModeE.None) { //通知が動いてなければ
                //コントロールの構成
                // --------------------------------
                // | DescLB               |ClickLB|
                // --------------------------------
                //イメージ的には......
                Label DescLB = new Label() {
                    Text = "終了しますか？",
                    AutoSize = false,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Name = "NT_ExitConfirmLabel",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                Label ClickLB = new Label() {
                    Text = "終了する",
                    AutoSize = false,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Name = "NT_ExitButtonLabel",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(3, 0, 3, 0)
                };
                //通知のパネルの背景色をいじる (これを白にすると見えなくて困る)
                this.MB.NotiTLP.BackColor = Color.FromArgb(150, 100, 100);
                //座標とサイズをいじる
                this.MB.NotiTLP.Location = new Point(0, this.Height);
                this.MB.NotiTLP.Size = new Size(Width, 30);
                //列を初期化して追加する
                this.MB.NotiTLP.ColumnStyles.Clear();
                this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                //コントロールを追加する
                this.MB.NotiTLP.Controls.Clear();
                this.MB.NotiTLP.Controls.Add(DescLB, 0, 0);
                this.MB.NotiTLP.Controls.Add(ClickLB, 1, 0);
                //「終了する」ボタンがクリック / マウスオンされたときの処理を追加
                //メソッドの名前がムダに長いけど気にしない
                ClickLB.Click += new System.EventHandler(FM_ExitButtonLabel_Clicked);
                ClickLB.MouseEnter += new System.EventHandler(FM_ExitButtonLabel_MouseEnter);
                ClickLB.MouseLeave += new System.EventHandler(FM_ExitButtonLabel_MouseLeave);
                /* "残骸"
                this.MB.AdditionalControls.Add("NT_RemoveConfirmLabel", DescLB);
                this.MB.AdditionalControls.Add("NT_RemoveButtonLabel", ClickLB);
                */
                //使用しているコントロールの名前を設定する
                //これがないとリソースを開放できない
                List<string> UseControls = new List<string> {
                    "NT_ExitConfirmLabel",
                    "NT_ExitButtonLabel"
                };
                //表示する準備
                this.MB.NotiTLP.BringToFront();
                this.MB.NotiTLP.Visible = true;
                //通知として初期化する
                this.MB.ShowInfo(this.MB.NotiTLP, UseControls, 5);
            }
        }

        //通知の「終了する」
        private void FM_ExitButtonLabel_Clicked(object sender, EventArgs e) {
            //クリックされたので終了
            Application.Exit();
        }

        private void FM_ExitButtonLabel_MouseEnter(object sender, EventArgs e) {
            //マウスが入ってきた
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_ExitButtonLabel"];
            ContLB.BackColor = Color.FromArgb(100 , 50, 50);
        }

        private void FM_ExitButtonLabel_MouseLeave(object sender, EventArgs e) {
            //マウスが出ていった
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_ExitButtonLabel"];
            ContLB.BackColor = Color.FromArgb(150, 100, 100);
        }


        //ファイルメニュー - 「全削除」
        private void FM_AllRemoveLabel_MouseEnter(object sender, EventArgs e) {
            //マウスが入ってきた
            FM_AllRemoveLabel.BackColor = HoverCol;
        }

        private void FM_AllRemoveLabel_MouseLeave(object sender, EventArgs e) {
            //マウスが出ていった
            FM_AllRemoveLabel.BackColor = UnHoverCol;
        }

        //クリックされた
        private void FM_AllRemoveLabel_Click(object sender, EventArgs e) {
            //ファイルメニューを閉じる
            MB.MenuProductionMode = MainBox.ProductionModeE.Leave;
            MB.MenuProductionTimer.Start();

            if (this.MB.InfoProductionMode == MainBox.ProductionModeE.None) { //通知が動いてなければ
                //コントロールの構成
                // --------------------------------
                // | DescLB               |ClickLB|
                // --------------------------------
                //イメージ的には......
                Label DescLB = new Label() {
                    Text = "すべて除外しますか？",
                    AutoSize = false,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Name = "NT_RemoveConfirmLabel",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                Label ClickLB = new Label() {
                    Text = "除外する",
                    AutoSize = false,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Name = "NT_RemoveButtonLabel",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(3, 0, 3, 0)
                };
                //通知のパネルの背景色をいじる (これを白にすると見えなくて困る)
                this.MB.NotiTLP.BackColor = Color.FromArgb(100, 150, 200);
                //座標とサイズをいじる
                this.MB.NotiTLP.Location = new Point(0, this.Height);
                this.MB.NotiTLP.Size = new Size(Width, 30);
                //列を初期化して追加する
                this.MB.NotiTLP.ColumnStyles.Clear();
                this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle (SizeType.Percent,100));
                this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle (SizeType.Absolute, 100));
                //コントロールを追加する
                this.MB.NotiTLP.Controls.Clear();
                this.MB.NotiTLP.Controls.Add(DescLB, 0, 0);
                this.MB.NotiTLP.Controls.Add(ClickLB, 1, 0);
                //「除外する」ボタンがクリック / マウスオンされたときの処理を追加
                //メソッドの名前がムダに長いけど気にしない
                ClickLB.Click += new System.EventHandler(FM_AllRemoveButtonLabel_Clicked);
                ClickLB.MouseEnter += new System.EventHandler(FM_AllRemoveButtonLabel_MouseEnter);
                ClickLB.MouseLeave += new System.EventHandler(FM_AllRemoveButtonLabel_MouseLeave);
                /* "残骸"
                this.MB.AdditionalControls.Add("NT_RemoveConfirmLabel", DescLB);
                this.MB.AdditionalControls.Add("NT_RemoveButtonLabel", ClickLB);
                */
                //使用しているコントロールの名前を設定する
                //これがないとリソースを開放できない
                List<string> UseControls = new List<string> {
                    "NT_RemoveConfirmLabel",
                    "NT_RemoveButtonLabel"
                };
                //表示する準備
                this.MB.NotiTLP.BringToFront();
                this.MB.NotiTLP.Visible = true;
                //通知として初期化する
                this.MB.ShowInfo(this.MB.NotiTLP, UseControls, 5);
            }
        }

        private void FM_AllRemoveButtonLabel_MouseEnter(object sender, EventArgs e) {
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_RemoveButtonLabel"];
            if (ContLB != null) {
                ContLB.BackColor = Color.FromArgb(50, 75, 100);
            }
        }

        private void FM_AllRemoveButtonLabel_MouseLeave(object sender, EventArgs e) {
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_RemoveButtonLabel"];
            if (ContLB != null) {
                ContLB.BackColor = Color.FromArgb(100, 150, 200);
            }
        }


        private void FM_AllRemoveButtonLabel_Clicked(object sender, EventArgs e) {
            //「除外する」がクリックされた
            this.MB.FileListS.Clear();
            //無理やり通知を閉じる
            MB.InfoCloseTimer.Stop();
            MB.InfoCloseTimer.Interval = 1;
            MB.InfoCloseTimer.Start();
            //描画してる領域を更新
            MB.MainGRPBox.Invalidate();

            //除外したことを伝える
            //コントロールの構成
            // --------------------------------
            // | DescLB                        |
            // --------------------------------
            //イメージ的には......
            Label DescLB = new Label() {
                Text = "すべて除外しました",
                AutoSize = false,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Name = "NT_RemoveCompletedDescLabel",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };
            //通知のパネルの背景色をいじる (これを白にすると見えなくて困る)
            this.MB.NotiTLP.BackColor = Color.FromArgb(100, 150, 200);
            //座標とサイズをいじる
            this.MB.NotiTLP.Location = new Point(0, this.Height);
            this.MB.NotiTLP.Size = new Size(Width, 30);
            //列を初期化して追加する
            this.MB.NotiTLP.ColumnStyles.Clear();
            this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            //コントロールを追加する
            this.MB.NotiTLP.Controls.Clear();
            this.MB.NotiTLP.Controls.Add(DescLB, 0, 0);
            //使用しているコントロールの名前を設定する
            //これがないとリソースを開放できない
            List<string> UseControls = new List<string> {
                    "NT_RemoveCompletedDescLabel",
            };
            //表示する準備
            this.MB.NotiTLP.BringToFront();
            this.MB.NotiTLP.Visible = true;
            //通知として初期化する
            this.MB.ShowInfo(this.MB.NotiTLP, UseControls, 3);
        }

    }
}
