using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class FileMenu : Form {
        public FileMenu() {
            InitializeComponent();
        }

        private void FileMenu_LocationChanged(object sender, EventArgs e) {
            //System.Diagnostics.Debug.Print("Load");
        }

        private void FileMenu_ExitLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void FileMenu_ExitLabel_MouseEnter(object sender, EventArgs e) {
            FileMenu_ExitLabel.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void FileMenu_ExitLabel_MouseLeave(object sender, EventArgs e) {
            FileMenu_ExitLabel.BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}
