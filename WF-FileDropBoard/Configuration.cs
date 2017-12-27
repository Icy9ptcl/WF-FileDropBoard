
using System;
using System.Collections.Generic;
using System.Drawing;
using FData;
using System.Runtime.Serialization;

namespace WF_FileDropBoard {
    /// <summary>
    /// MainBox の設定を保存するクラス。
    /// </summary>
    public class Configuration {
        public string VersionS;
        public int VersionNumS;
        public bool File_AlwaysShowDate;
        public Main.File_ShowDateModeE File_ShowDateMode;
        public bool File_ShowPreview;
        public Dictionary<String, Color> ExtCol;

        //public List<FileData> FileListS;
        //Dictionary<String, Color> ExtCol;
        //HashSet<int> UsedFileNumS;
        public List<FileData> FileListS;
        public Main MB;
        /*
        public Configurations() {
            File_AlwaysShowDate = false;
            FileListS = new List<FileData>();

        }

        */
        public Configuration(Main MB) {
            this.MB = MB;
        }

        /// <summary>
        /// 設定をこのクラスにインポートします。
        /// このクラスに残っていた設定は、上書きされます。
        /// </summary>
        public void ImportSettings() {
            VersionS = Main.VersionS;
            VersionNumS = Main.VerNum;
            File_AlwaysShowDate = MB.File_AlwaysShowDate;
            File_ShowDateMode = MB.File_ShowDateMode;
            File_ShowPreview = MB.File_ShowPreview;
            FileListS = MB.FileListS;
            ExtCol = MB.ExtCol;
        }

        /// <summary>
        /// MainBox の設定をこのクラスに保存されていたデータで上書きします。
        /// MainBox に残っていた設定は、上書きされます。
        /// </summary>
        public void ExportSettings() {
            MB.File_AlwaysShowDate = this.File_AlwaysShowDate;
            MB.File_ShowDateMode = this.File_ShowDateMode;
            MB.File_ShowPreview = this.File_ShowPreview;
            MB.FileListS = this.FileListS;
            MB.ExtCol = this.ExtCol;
        }

    }

}
