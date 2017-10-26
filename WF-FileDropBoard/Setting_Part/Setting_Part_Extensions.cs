// 設定 - 色(ファイル名的には拡張子)
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class Setting_Part_Extensions : Form {

        Main MB;
        string ExtInputDescS = ". を含めて入力";
        string ColInputDescS = "FFFFFF など";
        Color InputCol = Color.FromArgb(0,0,0);
        Color InputDescCol = Color.FromArgb(192, 192, 192);
        List<String> ExtList = new List<String>();

        public Setting_Part_Extensions(Main MB) {
            InitializeComponent();
            this.MB = MB;
        }

        private void Setting_Part_Extensions_Load(object sender, EventArgs e) {
            // ListBox に要素を追加して、選択できるようにする
            foreach (KeyValuePair<String, Color> ExtCols in MB.ExtCol) {
                string AddStr = "";
                try {
                    AddStr += ExtCols.Key;
                    AddStr += " (#" + ColortoHexColCode(ExtCols.Value) + ")";
                    this.Setting_ExtListBox.Items.Add(AddStr);
                    ExtList.Add(ExtCols.Key);
               } catch (Exception exc) {
                    MB.AddError(string.Format("拡張子リストの作成中にエラーが発生しました:{0} ({1})\n{2}\nこれにより、色設定(拡張子 {3} , 色{4}) は削除されます。", exc.ToString(), exc.Message, exc.StackTrace, ExtCols.Key, ExtCols.Value), false);
                    MB.ExtCol.Remove(ExtCols.Key);
               }
            }

            // ヒントを出しておく
            Setting_InExtTBox.ForeColor = InputDescCol;
            Setting_InExtTBox.Text = ExtInputDescS;
            Setting_InColTBox.ForeColor = InputDescCol;
            Setting_InColTBox.Text = ColInputDescS;

            //ボタンは無効化する
            Setting_ExtAddButton.Enabled = false;
            Setting_ExtRemoveButton.Enabled = false;
            Setting_ExtGetButton.Enabled = false;

            Setting_ExtStatusLabel.Text = "";
        }

        private void Setting_InExtTBox_Enter(object sender, EventArgs e) {
            if (Setting_InExtTBox.Text == ExtInputDescS) {
                Setting_InExtTBox.ForeColor = InputCol;
                Setting_InExtTBox.Text = "";
            }
        }

        private void Setting_InExtTBox_Leave(object sender, EventArgs e) {
            if (Setting_InExtTBox.Text == "") {
                Setting_InExtTBox.ForeColor = InputDescCol;
                Setting_InExtTBox.Text = ExtInputDescS;
            }
        }

        private void Setting_InColTBox_Enter(object sender, EventArgs e) {
            if (Setting_InColTBox.Text == ColInputDescS) {
                Setting_InColTBox.ForeColor = InputCol;
                Setting_InColTBox.Text = "";
            }
        }

        private void Setting_InColTBox_Leave(object sender, EventArgs e) {
            if (Setting_InColTBox.Text == "") {
                Setting_InColTBox.ForeColor = InputDescCol;
                Setting_InColTBox.Text = ColInputDescS;
            }
        }

        /// <summary>
        /// Color 構造体を16進数のカラーコード(000000 - FFFFFF)形式に変換します。
        /// 返ってくるのは6桁(RRGGBB)となります。
        /// </summary>
        /// <param name="col">カラーコードに変換したい、Color 構造体。</param>
        /// <returns></returns>s
        private string ColortoHexColCode(Color col) {
            try {
                string RS = Convert.ToString(col.R, 16);
                string GS = Convert.ToString(col.G, 16);
                string BS = Convert.ToString(col.B, 16);
                if (RS.Length == 1) {
                    RS = "0" + RS;
                }
                if (GS.Length == 1) {
                    GS = "0" + GS;
                }
                if (BS.Length == 1) {
                    BS = "0" + BS;
                }

                return RS + GS + BS;
            } catch (ArgumentException) {
                throw new ArgumentException(String.Format("Color 構造体({0},{1},{2})を16進数に変換できませんでした。", col.R, col.G, col.B));
            }
        }

        /// <summary>
        /// 16進数のカラーコードを、Color 構造体に変換します。
        /// カラーコードは6桁(RRGGBB)でないと例外が発生します。
        /// </summary>
        /// <param name="HexColCode">6桁(RRGGBB)のカラーコード。</param>
        /// <exception cref="ArgumentException">カラーコードが6桁ではないか、16進数で表されていない場合。</exception>
        /// <returns></returns>
        private Color HexColCodetoColor(string HexColCode) {
            if (HexColCode.Length != 6) {
                throw new ArgumentException(String.Format("カラーコード {0} の桁数は、6桁である必要があります。", HexColCode));
            }
            try {
                int ColR = Convert.ToInt32(HexColCode.Substring(0, 2),16);
                int ColG = Convert.ToInt32(HexColCode.Substring(2, 2), 16);
                int ColB = Convert.ToInt32(HexColCode.Substring(4, 2), 16);
                return Color.FromArgb(ColR, ColG, ColB);
            } catch (ArgumentException) {
                throw new ArgumentException(String.Format("カラーコード {0} は正しくありません。", HexColCode));
            }
        }

        private void Setting_InExtTBox_TextChanged(object sender, EventArgs e) {
            if (( Setting_InExtTBox.Text != "" ) && ( Setting_InExtTBox.Text != ExtInputDescS ) && ( Setting_InColTBox.Text.Length == 6)) {
                Setting_ExtAddButton.Enabled = true;
            }
        }

        private void Setting_InColTBox_TextChanged(object sender, EventArgs e) {
            if (( Setting_InExtTBox.Text != "" ) && (Setting_InExtTBox.Text != ExtInputDescS) && ( Setting_InColTBox.Text.Length == 6 )) {
                Setting_ExtAddButton.Enabled = true;
                try {
                    Color col = HexColCodetoColor(Setting_InColTBox.Text);
                    Setting_ExtColPic.BackColor = col;
                    Setting_InColTBox.BackColor = Color.FromArgb(255, 255, 255);
                } catch (ArgumentException) {
                    Setting_InColTBox.BackColor = Color.FromArgb(255, 220, 220);
                }
            }
        }

        private void Setting_ExtListBox_SelectedIndexChanged(object sender, EventArgs e) {
            //選択されたものがない
            if (Setting_ExtListBox.SelectedIndex == -1) {
                Setting_ExtGetButton.Enabled = false;
                Setting_ExtRemoveButton.Enabled = false;
            } else {
                //なにかが選ばれた
                Setting_ExtGetButton.Enabled = true;
                Setting_ExtRemoveButton.Enabled = true;
            }

        }

        private void Setting_ExtAddButton_Click(object sender, EventArgs e) {
            //Debug.Print("Add clicked");
            string ExtS = Setting_InExtTBox.Text;
            string ColS = Setting_InColTBox.Text;
            string ErrorCode = "";
            bool WillOverWrite = false;
            //無理やり条件判定
            while (true) {
                if (ExtS.Substring(0, 1).Equals(".") == false) {
                    //Debug.Print(". except");
                    ErrorCode = "拡張子が正しくありません。";
                    break;
                }
                if (ExtS.Length < 2) {
                    //Debug.Print("Length not enough");
                    ErrorCode = "拡張子が正しくありません。";
                    break;
                }
                if (ExtS == ExtInputDescS) {
                    //Debug.Print("Nothing was inputted");
                    ErrorCode = "拡張子を入力してください。";
                    break;
                }
                try {
                    Color ToCol;
                    try {
                        ToCol = HexColCodetoColor(ColS);
                    } catch (ArgumentException) {
                        ErrorCode = "カラーコードが正しくありません。";
                        break;
                    }
                    // うまくできている

                    int i = 0;
                    try {
                        //上書き
                        MB.ExtCol.Remove(ExtS);
                        for (i = 0; i < Setting_ExtListBox.Items.Count; i++) {
                            if (Setting_ExtListBox.Items[i].ToString().StartsWith(ExtS)) {
                                break;
                            }
                        }
                        if (i != Setting_ExtListBox.Items.Count) {
                            Setting_ExtListBox.Items.RemoveAt(i);
                        }
                        ExtList.Remove(ExtS);
                        WillOverWrite = true;
                    } catch (Exception exc2) {
                        //新規
                    }
                    MB.ExtCol.Add(ExtS, ToCol);
                    //表にも追加する
                    string AddStr = "";
                    try {
                        AddStr += ExtS;
                        AddStr += " (#" + ColortoHexColCode(ToCol) + ")";
                    } catch (ArgumentException) {
                        //カラーコードが正しくない
                        ErrorCode = "カラーコードが正しくありません。";
                        break; //離脱
                    }
                    this.Setting_ExtListBox.Items.Add(AddStr);
                    ExtList.Add(ExtS);
                    //成功なら入力ボックス初期化
                    Setting_InExtTBox.Text = "";
                    Setting_InColTBox.Text = "";
                    //ふたたびヒント表示
                    Setting_InExtTBox.ForeColor = InputDescCol;
                    Setting_InExtTBox.Text = ExtInputDescS;
                    Setting_InColTBox.ForeColor = InputDescCol;
                    Setting_InColTBox.Text = ColInputDescS;
                    Setting_ExtAddButton.Enabled = false;
                } catch (Exception exc) {
                    //Debug.Print("Err:{0}\non {1}",exc.ToString(),exc.TargetSite.ToString());
                    break;
                }
                break;
            }
            //Debug.Print(ErrorCode);
            if (ErrorCode != "") {
                StatusClearTimer.Stop();
                Setting_ExtStatusLabel.Text = ErrorCode;
                Setting_ExtStatusLabel.ForeColor = Color.FromArgb(200, 80, 80);
                Setting_ExtStatusLabel.BackColor = Color.FromArgb(255, 220, 220);
                StatusClearTimer.Start();
                System.Media.SystemSounds.Beep.Play();
                //MessageBox.Show(ErrorCode,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            } else {
                if (WillOverWrite) {
                    StatusClearTimer.Stop();
                    Setting_ExtStatusLabel.Text = String.Format("拡張子 {0} の設定を上書きしました。", ExtS);
                    Setting_ExtStatusLabel.ForeColor = Color.FromArgb(80, 200, 80);
                    Setting_ExtStatusLabel.BackColor = Color.FromArgb(220, 255, 220);
                    StatusClearTimer.Start();
                } else {
                    StatusClearTimer.Stop();
                    Setting_ExtStatusLabel.Text = String.Format("拡張子 {0} の設定を追加しました。", ExtS);
                    Setting_ExtStatusLabel.ForeColor = Color.FromArgb(80, 200, 80);
                    Setting_ExtStatusLabel.BackColor = Color.FromArgb(220, 255, 220);
                    StatusClearTimer.Start();
                }
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void Setting_ExtRemoveButton_Click(object sender, EventArgs e) {
            int Index = Setting_ExtListBox.SelectedIndex;
            MB.ExtCol.Remove(ExtList[Index]);
            this.Setting_ExtListBox.Items.RemoveAt(Index);
            ExtList.RemoveAt(Index);
        }

        private void Setting_ExtGetButton_Click(object sender, EventArgs e) {
            int Index = Setting_ExtListBox.SelectedIndex;
            Setting_InExtTBox.Text = ExtList[Index];
            Setting_InColTBox.Text = ColortoHexColCode(MB.ExtCol[ExtList[Index]]);
            Setting_InColTBox.ForeColor = InputCol;
            Setting_InExtTBox.ForeColor = InputCol;
        }

        private void StatusClearTimer_Tick(object sender, EventArgs e) {
            Setting_ExtStatusLabel.Text = "";
            Setting_ExtStatusLabel.ForeColor = Color.FromArgb(0, 0, 0);
            Setting_ExtStatusLabel.BackColor = this.BackColor;
        }

        private void Setting_ExtSelLabel_Click(object sender, EventArgs e) {
            Color C;
            try {
                C = HexColCodetoColor(Setting_InColTBox.Text);
            } catch (Exception exc3) {
                C = Color.FromArgb(128, 128, 128);
            }
            colorDialog.Color = C;
            colorDialog.ShowDialog();
            Setting_InColTBox.ForeColor = InputCol;
            Setting_InColTBox.Text = ColortoHexColCode(colorDialog.Color);
        }
    }

}
