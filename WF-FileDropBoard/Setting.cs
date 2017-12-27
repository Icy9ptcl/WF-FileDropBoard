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
            MB.SaveConfiguration(MB);
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
