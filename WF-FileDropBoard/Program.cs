//
//  FileDropBoard - v 1.1.1
//    by 2012 - 2017 Hiro-Project
//  GitHub : https://github.com/hiro0916-ptcl/WF-FileDropBoard 
//
//  LICENSED under the GPL-3.0
//   - See : https://www.gnu.org/licenses/gpl-3.0.en.html
//
using System;
using System.Windows.Forms;

namespace WF_FileDropBoard
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException); //例外を設定する
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException); //ついでに。
            Application.Run(new Main());
        }

        /// <summary>
        /// エラーが発生したときに発生します。
        /// 出てきたら、アンラッキーです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            ErrorDialog dir = new ErrorDialog(e);
            dir.ShowDialog();
            Application.Exit();
        }
    }
}
