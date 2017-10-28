// 設定 - タイル
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_FileDropBoard {
    public partial class Setting_Part_Tile : Form {

        public Main MB;

        Dictionary<Main.File_ShowDateModeE, string> DateModeDic = new Dictionary<Main.File_ShowDateModeE, string> {
            { Main.File_ShowDateModeE.None,"なし" },
            { Main.File_ShowDateModeE.DateOnly,"日付のみ" },
            { Main.File_ShowDateModeE.TimeOnly,"時刻のみ" },
            { Main.File_ShowDateModeE.DateAndTime,"日付と時刻" }
        };

        public Setting_Part_Tile(Main MB) {
            InitializeComponent();
            this.MB = MB;
            this.Dock = DockStyle.Fill;
        }

        private void Settings_Part_Tile_Load(object sender, EventArgs e) {
            //プレビューを表示するか
            if (MB.File_ShowPreview) {
                Settings_Tile_ShowPreviewCB.Checked = true;
            }
            //日時を表示するか
            if (MB.File_AlwaysShowDate) {
                Settings_Tile_ShowLU.Checked = true;
                switch (MB.File_ShowDateMode) {
                    case Main.File_ShowDateModeE.DateAndTime:

                    break;
                }
            } else {
                //そもそも表示しないつもりだった
                Settings_Tile_SelDateMode.Enabled = false;
            }

            //「更新時刻として表示する内容」の設定
            foreach (KeyValuePair<Main.File_ShowDateModeE, string> StrS in DateModeDic) {
                //とりあえず要素追加
                Settings_Tile_SelDateMode.Items.Add(StrS.Value);
                //現在の設定であるか判定する
                if (StrS.Key == MB.File_ShowDateMode) {
                    Settings_Tile_SelDateMode.SelectedText = StrS.Value;
                }
            }

        }

        //「タイルにファイルのプレビューを表示する」
        private void Settings_Tile_ShowPreviewCB_CheckedChanged(object sender, EventArgs e) {
            MB.File_ShowPreview = Settings_Tile_ShowPreviewCB.Checked;
        }

        //「タイルに最終更新日時を表示する」のチェック
        private void Settings_Tile_ShowLU_CheckedChanged(object sender, EventArgs e) {

            MB.File_AlwaysShowDate = Settings_Tile_ShowLU.Checked;
            if (Settings_Tile_ShowLU.Checked) {
                Settings_Tile_SelDateMode.Enabled = true;
            } else {
                Settings_Tile_SelDateMode.Enabled = false;
            }
        }

        //「更新日時として表示する内容」の判定
        private void Settings_Tile_SelDateMode_SelectedIndexChanged(object sender, EventArgs e) {
            MB.File_ShowDateMode = (Main.File_ShowDateModeE)Settings_Tile_SelDateMode.SelectedIndex;
        }
    }
}
