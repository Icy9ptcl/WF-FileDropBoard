namespace WF_FileDropBoard {
    partial class Setting_Part_Tile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Setting_TileTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_TileDescLabel = new System.Windows.Forms.Label();
            this.Settings_Tile_Panel = new System.Windows.Forms.Panel();
            this.Settings_Tile_SelDateMode = new System.Windows.Forms.ComboBox();
            this.Settings_Tile_ShowLU = new System.Windows.Forms.CheckBox();
            this.Settings_Tile_SelectDateModeDescLabel = new System.Windows.Forms.Label();
            this.Settings_Tile_ShowPreviewCB = new System.Windows.Forms.CheckBox();
            this.Setting_TileTLP.SuspendLayout();
            this.Settings_Tile_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_TileTLP
            // 
            this.Setting_TileTLP.ColumnCount = 1;
            this.Setting_TileTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_TileTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Setting_TileTLP.Controls.Add(this.Settings_TileDescLabel, 0, 0);
            this.Setting_TileTLP.Controls.Add(this.Settings_Tile_Panel, 0, 1);
            this.Setting_TileTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_TileTLP.Location = new System.Drawing.Point(0, 0);
            this.Setting_TileTLP.Name = "Setting_TileTLP";
            this.Setting_TileTLP.RowCount = 2;
            this.Setting_TileTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Setting_TileTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_TileTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Setting_TileTLP.Size = new System.Drawing.Size(284, 261);
            this.Setting_TileTLP.TabIndex = 2;
            // 
            // Settings_TileDescLabel
            // 
            this.Settings_TileDescLabel.AutoSize = true;
            this.Settings_TileDescLabel.Font = new System.Drawing.Font("メイリオ", 11F);
            this.Settings_TileDescLabel.Location = new System.Drawing.Point(3, 0);
            this.Settings_TileDescLabel.Name = "Settings_TileDescLabel";
            this.Settings_TileDescLabel.Size = new System.Drawing.Size(55, 22);
            this.Settings_TileDescLabel.TabIndex = 0;
            this.Settings_TileDescLabel.Text = "タイル";
            // 
            // Settings_Tile_Panel
            // 
            this.Settings_Tile_Panel.AutoScroll = true;
            this.Settings_Tile_Panel.Controls.Add(this.Settings_Tile_SelDateMode);
            this.Settings_Tile_Panel.Controls.Add(this.Settings_Tile_ShowLU);
            this.Settings_Tile_Panel.Controls.Add(this.Settings_Tile_SelectDateModeDescLabel);
            this.Settings_Tile_Panel.Controls.Add(this.Settings_Tile_ShowPreviewCB);
            this.Settings_Tile_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_Tile_Panel.Location = new System.Drawing.Point(0, 22);
            this.Settings_Tile_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_Tile_Panel.Name = "Settings_Tile_Panel";
            this.Settings_Tile_Panel.Size = new System.Drawing.Size(284, 239);
            this.Settings_Tile_Panel.TabIndex = 1;
            // 
            // Settings_Tile_SelDateMode
            // 
            this.Settings_Tile_SelDateMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Settings_Tile_SelDateMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Settings_Tile_SelDateMode.FormattingEnabled = true;
            this.Settings_Tile_SelDateMode.Location = new System.Drawing.Point(3, 55);
            this.Settings_Tile_SelDateMode.Name = "Settings_Tile_SelDateMode";
            this.Settings_Tile_SelDateMode.Size = new System.Drawing.Size(223, 20);
            this.Settings_Tile_SelDateMode.TabIndex = 6;
            this.Settings_Tile_SelDateMode.SelectedIndexChanged += new System.EventHandler(this.Settings_Tile_SelDateMode_SelectedIndexChanged);
            // 
            // Settings_Tile_ShowLU
            // 
            this.Settings_Tile_ShowLU.AutoSize = true;
            this.Settings_Tile_ShowLU.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Tile_ShowLU.Location = new System.Drawing.Point(0, 16);
            this.Settings_Tile_ShowLU.Name = "Settings_Tile_ShowLU";
            this.Settings_Tile_ShowLU.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Settings_Tile_ShowLU.Size = new System.Drawing.Size(284, 16);
            this.Settings_Tile_ShowLU.TabIndex = 4;
            this.Settings_Tile_ShowLU.Text = "タイルに最終更新日時を表示する";
            this.Settings_Tile_ShowLU.UseVisualStyleBackColor = true;
            this.Settings_Tile_ShowLU.CheckedChanged += new System.EventHandler(this.Settings_Tile_ShowLU_CheckedChanged);
            // 
            // Settings_Tile_SelectDateModeDescLabel
            // 
            this.Settings_Tile_SelectDateModeDescLabel.AutoSize = true;
            this.Settings_Tile_SelectDateModeDescLabel.Location = new System.Drawing.Point(3, 38);
            this.Settings_Tile_SelectDateModeDescLabel.Name = "Settings_Tile_SelectDateModeDescLabel";
            this.Settings_Tile_SelectDateModeDescLabel.Size = new System.Drawing.Size(146, 12);
            this.Settings_Tile_SelectDateModeDescLabel.TabIndex = 3;
            this.Settings_Tile_SelectDateModeDescLabel.Text = "更新日時として表示する内容";
            // 
            // Settings_Tile_ShowPreviewCB
            // 
            this.Settings_Tile_ShowPreviewCB.AutoSize = true;
            this.Settings_Tile_ShowPreviewCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Tile_ShowPreviewCB.Location = new System.Drawing.Point(0, 0);
            this.Settings_Tile_ShowPreviewCB.Name = "Settings_Tile_ShowPreviewCB";
            this.Settings_Tile_ShowPreviewCB.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Settings_Tile_ShowPreviewCB.Size = new System.Drawing.Size(284, 16);
            this.Settings_Tile_ShowPreviewCB.TabIndex = 1;
            this.Settings_Tile_ShowPreviewCB.Text = "タイルにファイルのプレビューを表示する";
            this.Settings_Tile_ShowPreviewCB.UseVisualStyleBackColor = true;
            this.Settings_Tile_ShowPreviewCB.CheckedChanged += new System.EventHandler(this.Settings_Tile_ShowPreviewCB_CheckedChanged);
            // 
            // Setting_Part_Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Setting_TileTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting_Part_Tile";
            this.Text = "Setting_Part_Tile";
            this.Load += new System.EventHandler(this.Settings_Part_Tile_Load);
            this.Setting_TileTLP.ResumeLayout(false);
            this.Setting_TileTLP.PerformLayout();
            this.Settings_Tile_Panel.ResumeLayout(false);
            this.Settings_Tile_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Setting_TileTLP;
        private System.Windows.Forms.Label Settings_TileDescLabel;
        private System.Windows.Forms.Panel Settings_Tile_Panel;
        private System.Windows.Forms.ComboBox Settings_Tile_SelDateMode;
        private System.Windows.Forms.CheckBox Settings_Tile_ShowLU;
        private System.Windows.Forms.Label Settings_Tile_SelectDateModeDescLabel;
        private System.Windows.Forms.CheckBox Settings_Tile_ShowPreviewCB;
    }
}