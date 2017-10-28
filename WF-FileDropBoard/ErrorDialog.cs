using System;
using System.Windows.Forms;
using System.Threading;

namespace WF_FileDropBoard {
    public partial class ErrorDialog : Form {

        ThreadExceptionEventArgs TE;
        public ErrorDialog(ThreadExceptionEventArgs e) {
            InitializeComponent();
            this.TE = e;
        }

        private void Emes_Action_ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Emes_Action_CopyLogButton_Click(object sender, EventArgs e) {
            Clipboard.SetData("Text",ErrorLogTBox.Text);
            MessageBox.Show("エラーログをコピーしました。", "コピー", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ;
        }

        private void Emes_Action_MailButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("mailto:HiShis.yfmn@gmail.com?subject=FileDropBoard エラーログ&body=(ここにエラーログをペーストしてください)");
            MessageBox.Show("メーラーを起動しました。\n送信する場合、エラーログのコピー/ペーストをお願いします。", "メーラーの起動 - FileDropBoard", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ErrorDialog_Load(object sender, EventArgs e) {
            this.Text = "FileDropBoard - エラー";
            System.Media.SystemSounds.Hand.Play();
            string ErrText = "";
            string VersionS = Main.VersionS;
            int VerNum = Main.VerNum;

            //定型フォーマット
            ErrText = String.Format(new string('=', 30) + "\r\nFileDropBoard Error log\r\n" + new string('=', 30));
            ErrText += "\r\n\r\n";
            ErrText += "I'm so sorry for inconvinience,I'll do my best for fix it!\r\n";
            ErrText += "\r\n";
            ErrText += "Details:\r\n";
            ErrText += String.Format("Version : {0} (Num {1})\r\n", VersionS, VerNum);
            ErrText += String.Format("Time:{0}\r\n", DateTime.Now.ToString());
            ErrText += String.Format("OS:{0} ",Environment.OSVersion.ToString());
            if (Environment.Is64BitOperatingSystem) {
                ErrText += "64-bit";
            } else {
                ErrText += "32-bit";
            }
            ErrText += "\r\nProcess:";
            if (Environment.Is64BitProcess) {
                ErrText += "64-bit";
            } else {
                ErrText += "32-bit";
            }
            ErrText += String.Format("\r\nMemory:{0}", Environment.WorkingSet);
            ErrText += String.Format("\r\nRuntime:{0}", Environment.Version.ToString());
            ErrText += String.Format("\r\nProcessor:{0}", Environment.ProcessorCount);
            ErrText += String.Format("\r\n\nSystem Stack-trace:{0}", Environment.StackTrace);
            ErrText += String.Format("\r\nApp Stack-trace:\r\n{0}", TE.Exception.StackTrace);
            ErrText += String.Format("\r\nThrown method by:{0}", TE.Exception.TargetSite);
            ErrText += String.Format("\r\nError by:{0}", TE.Exception.Source);
            ErrText += String.Format("\r\nException message:", TE.Exception.Message);
            ErrText += "\n\r";
            ErrText += "Logs:\n\r";
            ErrText += "\r\nPlease send this error log to: [hishis.yfmn@gmail.com].";

            ErrorLogTBox.Text = ErrText;

        }
    }
}
