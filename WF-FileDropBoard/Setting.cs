using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WF_FileDropBoard {
    public partial class Setting : Form {

        private Main MB;
        private Form OpeningSettingsForm;

        private Color HoverCol = Color.FromArgb(128, 128, 128);
        private Color UnHoverCol = Color.FromArgb(192, 192, 192);
        private Color DisabledCol = Color.FromArgb(64, 64, 64);

        private int SettingPage = 0;
        //設定として表示する Form の名前
        //"Setting_Part_"のあとに指定される
        private List<string> SettingFormsName = new List<string> {
            "Tile",
            "Extensions",
            "Info"
        };

        public Setting(Main MB) {
            this.MB = MB;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            SettingPage = 0;
            Settings_ChangePage(0);
            this.Text = "設定 - FileDropBoard";
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e) {

            //コントロールの構成
            // --------------------------------
            // | DescLB                        |
            // --------------------------------
            //イメージ的には......
            Label DescLB = new Label() {
                Text = "保存しています...",
                AutoSize = false,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Name = "NT_SavingDescLabel",
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
                    "NT_SavingDescLabel",
            };
            //表示する準備
            this.MB.NotiTLP.BringToFront();
            this.MB.NotiTLP.Visible = true;
            //通知として初期化する
            this.MB.ShowInfo(this.MB.NotiTLP, UseControls, 999);
            //保存開始
            MB.IsSettingsOpenB = false;
            Configuration CF = new Configuration(MB);
            DataIO dataIO = new DataIO();
            CF.ImportSettings();
            string SaveMessage = "設定を保存しました";
            //バックアップ
            try {
                File.Copy(MB.FilePath + MB.FileName, MB.FilePath + MB.FileName + ".old", true);
            } catch (Exception) {

            }

            try {
                DataIO.SaveSettings<Configuration>(MB.FilePath + MB.FileName, CF);
            } catch (Exception e3) {
                SaveMessage = String.Format("設定は保存されませんでした({0})", e3.Message);
            }

            //無理やり通知を閉じる
            MB.InfoCloseTimer.Stop();
            MB.InfoCloseTimer.Interval = 1;
            MB.InfoCloseTimer.Start();
            DescLB.Dispose();

            //コントロールの構成
            // --------------------------------
            // | DescLB                        |
            // --------------------------------
            //イメージ的には......
            Label DescLB2 = new Label() {
                Text = SaveMessage,
                AutoSize = false,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Name = "NT_SavedDescLabel",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };
            //通知のパネルの背景色をいじる (これを白にすると見えなくて困る)
            this.MB.NotiTLP.BackColor = MB.Noti_SuccColor;
            //座標とサイズをいじる
            this.MB.NotiTLP.Location = new Point(0, this.Height);
            this.MB.NotiTLP.Size = new Size(Width, 30);
            //列を初期化して追加する
            this.MB.NotiTLP.ColumnStyles.Clear();
            this.MB.NotiTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            //コントロールを追加する
            this.MB.NotiTLP.Controls.Clear();
            this.MB.NotiTLP.Controls.Add(DescLB2, 0, 0);
            //使用しているコントロールの名前を設定する
            //これがないとリソースを開放できない
            List<string> UseControls2 = new List<string> {
                    "NT_SavedDescLabel",
            };
            //表示する準備
            this.MB.NotiTLP.BringToFront();
            this.MB.NotiTLP.Visible = true;
            //通知として初期化する
            this.MB.ShowInfo(this.MB.NotiTLP, UseControls2, 3);
            System.Media.SystemSounds.Asterisk.Play();
            DescLB.Dispose();

        }

        /// <summary>
        /// 「設定」内でのページを切り替えます。
        /// 範囲外だった場合は何もしません。
        /// </summary>
        /// <param name="ToPage">移動先のページ。</param>
        private void Settings_ChangePage(int ToPage) {
            Type tp = Type.GetType("WF_FileDropBoard.Setting_Part_" + SettingFormsName[ToPage]);
            if (tp != null) {
                this.SettingsTLP.Controls.Remove(OpeningSettingsForm);
                OpeningSettingsForm = (System.Windows.Forms.Form)Activator.CreateInstance(
                    tp,
                    new object[] { MB }
                    );
                OpeningSettingsForm.TopLevel = false;
                OpeningSettingsForm.Visible = true;
                this.SettingsTLP.Controls.Add(OpeningSettingsForm, 0, 1);

                SettingPage = ToPage;
                Settings_PageLabel.Text = (SettingPage + 1).ToString() + " / " + SettingFormsName.Count.ToString() + " ページ";

                Settings_PageControl_L.BackColor = UnHoverCol;
                Settings_PageControl_R.BackColor = UnHoverCol;

                if (SettingPage == 0) {
                    Settings_PageControl_L.BackColor = DisabledCol;
                }

                if (SettingPage == SettingFormsName.Count - 1) {
                        Settings_PageControl_R.BackColor = DisabledCol;
                }


            }
        }

        private void Settings_PageControl_L_Click(object sender, EventArgs e) {
            if (SettingPage > 0) {
                Settings_ChangePage(SettingPage - 1);
            }
         }

        private void Settings_PageControl_L_MouseEnter(object sender, EventArgs e) {
            if (SettingPage != 0) {
                Settings_PageControl_L.BackColor = HoverCol;
            }
        }

        private void Settings_PageControl_L_MouseLeave(object sender, EventArgs e) {
            if (SettingPage != 0) {
                Settings_PageControl_L.BackColor = UnHoverCol;
            }
        }

        private void Settings_PageControl_R_Click(object sender, EventArgs e) {
            if (SettingPage < SettingFormsName.Count - 1) {
                Settings_ChangePage(SettingPage + 1);
            }

        }

        private void Settings_PageControl_R_MouseEnter(object sender, EventArgs e) {
            if (SettingPage < SettingFormsName.Count - 1) {
                Settings_PageControl_R.BackColor = HoverCol;
            }
        }

        private void Settings_PageControl_R_MouseLeave(object sender, EventArgs e) {
            if (SettingPage < SettingFormsName.Count - 1) {
                Settings_PageControl_R.BackColor = UnHoverCol;
            }
        }

        private void Settings_UpdateLabel_Click(object sender, EventArgs e) {
            MB.MainGRPBox.Invalidate();
        }

        private void Settings_UpdateLabel_MouseEnter(object sender, EventArgs e) {
            Settings_UpdateLabel.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void Settings_UpdateLabel_MouseLeave(object sender, EventArgs e) {
            Settings_UpdateLabel.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
