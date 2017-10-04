using System.Drawing;

namespace Form1 {
    public struct FileData {
        public string FilePath {
            get; set;
        }
        public int PosX {
            get; set;
        }
        public int PosY {
            get; set;
        }
        public string FileName {
            get {
                return System.IO.Path.GetFileName(this.FilePath);
            }
        }
        public string FileExt {
            get {
                return System.IO.Path.GetExtension(this.FilePath);
            }
        }
        public Color FileCol {
            get; set;
        }
        public string FilePreviewS {
            get; set;
        }
        public int FileNum {
            get; set;
        }
        public System.DateTime FileLastUpdateTime {
            get; set;
        }
    }
}