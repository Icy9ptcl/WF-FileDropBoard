// 設定 - 情報
using System;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class Setting_Part_Info : Form {

        Main MB;

        public Setting_Part_Info(Main MB) {
            InitializeComponent();
            this.MB = MB;
        }

        private void Setting_Part_Info_Load(object sender, EventArgs e) {
            Settings_Info_VerLabel.Text = "Ver " + Main.VersionS;
        }

        private void Settings_Info_ContactL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("mailto:HiShis.yfmn@gmail.com");
        }

    }
}
