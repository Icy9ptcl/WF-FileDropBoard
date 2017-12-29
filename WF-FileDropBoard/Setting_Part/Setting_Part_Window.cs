using System;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class Setting_Part_Window : Form {
        Main MB;

        public Setting_Part_Window(Main MB) {
            InitializeComponent();
            this.MB = MB;
        }

        private void Setting_Part_Window_Load(object sender, EventArgs e) {
            AutoHideCB.Checked = MB.AutoHide;
            AutoHideSecNUD.Value = MB.AutoHideTime;
            TopMostCB.Checked = MB.TopWindow;
            PosSecSelCB.SelectedIndex = (int)MB.AutoHidePosition;
        }

        private void AutoHideCB_CheckedChanged(object sender, EventArgs e) {
            MB.AutoHide = AutoHideCB.Checked;
        }

        private void AutoHideSecNUD_ValueChanged(object sender, EventArgs e) {
            MB.AutoHideTime = (int)AutoHideSecNUD.Value;
        }

        private void TopMostCB_CheckedChanged(object sender, EventArgs e) {
            MB.TopWindow = TopMostCB.Checked;
        }

        private void PosSecSelCB_SelectedIndexChanged(object sender, EventArgs e) {
            MB.AutoHidePosition = (Main.AutoHidePositionE)PosSecSelCB.SelectedIndex;
        }
    }
}
