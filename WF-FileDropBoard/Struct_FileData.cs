using System.Drawing;

namespace Form1 {
    /// <summary>
    /// ボードに追加できるファイルのデータ。
    /// </summary>
    public struct FileData {
        /// <summary>
        /// ファイルの完全パス。
        /// </summary>
        public string FilePath {
            get; set;
        }

        /// <summary>
        /// タイルの X 座標。
        /// </summary>
        public int PosX {
            get; set;
        }

        /// <summary>
        /// タイルの Y 座標。
        /// </summary>
        public int PosY {
            get; set;
        }

        /// <summary>
        /// ファイルの名前(***.ext)。
        /// 拡張子は除外されます。
        /// (<seealso cref="System.IO.FileInfo"/> から取得します)
        /// </summary>
        public string FileName {
            get {
                return System.IO.Path.GetFileName(this.FilePath);
            }
        }

        /// <summary>
        /// ファイルの拡張子(filename.***)。
        /// ファイル名は除外され、かつ . が付きます。
        /// (<seealso cref="System.IO.FileInfo"/> から取得します)
        /// </summary>
        public string FileExt {
            get {
                return System.IO.Path.GetExtension(this.FilePath);
            }
        }

        /// <summary>
        /// タイルの色。
        /// </summary>
        public Color FileCol {
            get; set;
        }

        /// <summary>
        /// このファイルのプレビューとして表示する文字列。
        /// </summary>
        public string FilePreviewS {
            get; set;
        }

        /// <summary>
        /// ファイルの管理番号。
        /// </summary>
        public int FileNum {
            get; set;
        }

        /// <summary>
        /// ファイルの最終更新時間(変更可能)。
        /// </summary>
        public System.DateTime FileLastUpdateTime {
            get; set;
        }
    }
}