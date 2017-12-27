//ファイルメニュー...なんだけどメニュー。
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FData;

namespace WF_FileDropBoard {
    public partial class FileMenu : Form {

        Main MB;

        public FileMenu(Main MB) {
            this.MB = MB;
            InitializeComponent();
        }

        private Color UnHoverCol = Color.FromArgb(255, 255, 255);
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
            FM_ExitLabel.BackColor = Color.FromArgb(200, 100, 100);
        }

        private void FM_ExitLabel_MouseLeave(object sender, EventArgs e) {
            //ファイルメニューの「終了する」から出た
            FM_ExitLabel.BackColor = Color.FromArgb(255, 150, 150);
        }

        //ファイルメニューの「終了する」がクリックされた
        private void FM_ExitLabel_Click(object sender, EventArgs e) {
            //ファイルメニューを閉じる
            MB.MenuProductionMode = Main.ProductionModeE.Leave;
            MB.MenuProductionTimer.Start();

            if (this.MB.InfoProductionMode == Main.ProductionModeE.None) { //通知が動いてなければ
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
                this.MB.NotiTLP.BackColor = MB.Noti_WarnColor;
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
                System.Media.SystemSounds.Question.Play();
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
            Color Nic = MB.Noti_WarnColor;
            ContLB.BackColor = Color.FromArgb(Nic.R / 2, Nic.G / 2, Nic.B / 2);
        }

        private void FM_ExitButtonLabel_MouseLeave(object sender, EventArgs e) {
            //マウスが出ていった
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_ExitButtonLabel"];
            ContLB.BackColor = MB.Noti_WarnColor;
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
            MB.MenuProductionMode = Main.ProductionModeE.Leave;
            MB.MenuProductionTimer.Start();

            if (this.MB.InfoProductionMode == Main.ProductionModeE.None) { //通知が動いてなければ
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
                this.MB.NotiTLP.BackColor = MB.Noti_InfoColor;
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
                System.Media.SystemSounds.Question.Play();
            }
        }

        private void FM_AllRemoveButtonLabel_MouseEnter(object sender, EventArgs e) {
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_RemoveButtonLabel"];
            if (ContLB != null) {
                Color Nic = MB.Noti_InfoColor;
                ContLB.BackColor = Color.FromArgb(Nic.R / 2, Nic.G / 2, Nic.B / 2);
            }
        }

        private void FM_AllRemoveButtonLabel_MouseLeave(object sender, EventArgs e) {
            Label ContLB = (Label)this.MB.NotiTLP.Controls["NT_RemoveButtonLabel"];
            if (ContLB != null) {
                ContLB.BackColor = MB.Noti_InfoColor;
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
            this.MB.NotiTLP.BackColor = MB.Noti_InfoColor;
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
            System.Media.SystemSounds.Asterisk.Play();
        }

        //設定を開く
        private void FM_GoSettingsLabel_Click(object sender, EventArgs e) {
            bool IsSettingsOpened = false;
            IsSettingsOpened = MB.OpenSettings(); // 設定を開く
            if (IsSettingsOpened == false) {
                //設定がすでに開いている
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
                    Text = "設定画面はすでに開かれています",
                    AutoSize = false,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Name = "NT_SettingsAlreadyOpenedDescLabel",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                //通知のパネルの背景色をいじる (これを白にすると見えなくて困る)
                this.MB.NotiTLP.BackColor = MB.Noti_InfoColor;
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
                    "NT_SettingsAlreadyOpenedDescLabel",
            };
                //表示する準備
                this.MB.NotiTLP.BringToFront();
                this.MB.NotiTLP.Visible = true;
                //通知として初期化する
                this.MB.ShowInfo(this.MB.NotiTLP, UseControls, 3);
                System.Media.SystemSounds.Question.Play();
            }
        }

        private void FM_GoSettingsLabel_MouseEnter(object sender, EventArgs e) {
            FM_GoSettingsLabel.BackColor = HoverCol;
        }

        private void FM_GoSettingsLabel_MouseLeave(object sender, EventArgs e) {
            FM_GoSettingsLabel.BackColor = UnHoverCol;
        }

        private void FM_FileOpenLabel_Click(object sender, EventArgs e) {
            FM_FileOpenDialog.ShowDialog();
        }

        private void FM_FileOpenLabel_MouseEnter(object sender, EventArgs e) {
            FM_FileOpenLabel.BackColor = HoverCol;
        }

        private void FM_FileOpenLabel_MouseHover(object sender, EventArgs e) {
            FM_FileOpenLabel.BackColor = UnHoverCol;
        }

        private void FM_FileOpenDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

            int Count = 0;　//カウント
            int FileAmount = FM_FileOpenDialog.FileNames.Length; //ファイルの数
            int WidthPadding = 10; //ウィンドウからの余白
            int AvaiableWidth = this.Width - WidthPadding * 2 - MB.TileWidth; //設置可能な枠のXサイズ
            int WidthPerFile = AvaiableWidth / FileAmount; //1ファイルあたりの余白

            foreach (string FileItemName in FM_FileOpenDialog.FileNames) {
                FileData TempFileData = new FileData {
                    FilePath = FileItemName,
                    PosX = (int)(WidthPadding + WidthPerFile * Count),
                    PosY = WidthPadding
                };
                //非同期にする必要が無いと見たので
                //await を入れていない
                MB.AddFile(TempFileData);
                Count++;
            }

            MB.MainGRPBox.Refresh();
        }
    }
}
