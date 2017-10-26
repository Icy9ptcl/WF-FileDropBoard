using System;
using System.Collections.Generic;
using System.Drawing;
using Form1;
using System.Runtime.Serialization;

namespace WF_FileDropBoard {
    /// <summary>
    /// MainBox の設定を保存するクラス。
    /// </summary>
    [DataContract(Name = "Configurations")]
    public class Configuration : IExtensibleDataObject {
        private ExtensionDataObject _extensionData;
        public ExtensionDataObject ExtensionData {
            get {
                return _extensionData;
            }
            set {
                _extensionData = value;
            }

        }

        [DataMember(Order = 0)]
        private string VersionS;
        [DataMember(Order = 1)]
        private int VersionNumS;
        [DataMember(Order = 2)]
        private bool File_AlwaysShowDate;
            [DataMember(Order = 3)]
        private Main.File_ShowDateModeE File_ShowDateMode;
        [DataMember(Order = 4)]
        private bool File_ShowPreview;
        [DataMember(Order = 5)]
        private Dictionary<String, Color> ExtCol;
        //private List<FileData> FileListS;
        //Dictionary<String, Color> ExtCol;
        //HashSet<int> UsedFileNumS;
        [IgnoreDataMember]
        private List<FileData> FileListS;
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
            //MB.FileListS = this.FileListS;
            MB.ExtCol = this.ExtCol;

        }

    }

}
