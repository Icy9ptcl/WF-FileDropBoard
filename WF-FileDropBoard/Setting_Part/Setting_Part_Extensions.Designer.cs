namespace WF_FileDropBoard {
    partial class Setting_Part_Extensions {
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
            this.components = new System.ComponentModel.Container();
            this.Setting_ExtTLP = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_Ext_Panel = new System.Windows.Forms.Panel();
            this.Setting_ExtListBox = new System.Windows.Forms.ListBox();
            this.Settings_ExtButton = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_ExtGetButton = new System.Windows.Forms.Button();
            this.Setting_ExtRemoveButton = new System.Windows.Forms.Button();
            this.Setting_ExtAddButton = new System.Windows.Forms.Button();
            this.Setting_Ext_InputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_InExtTBox = new System.Windows.Forms.TextBox();
            this.Setting_InColTBox = new System.Windows.Forms.TextBox();
            this.Setting_Ext_InExtDesc = new System.Windows.Forms.Label();
            this.Setting_Ext_InColDesc = new System.Windows.Forms.Label();
            this.Setting_ExtColPic = new System.Windows.Forms.PictureBox();
            this.Setting_ExtSelLabel = new System.Windows.Forms.Label();
            this.Setting_Ext_HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_ExtDescLabel = new System.Windows.Forms.Label();
            this.Setting_ExtStatusLabel = new System.Windows.Forms.Label();
            this.StatusClearTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Setting_ExtTLP.SuspendLayout();
            this.Settings_Ext_Panel.SuspendLayout();
            this.Settings_ExtButton.SuspendLayout();
            this.Setting_Ext_InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_ExtColPic)).BeginInit();
            this.Setting_Ext_HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_ExtTLP
            // 
            this.Setting_ExtTLP.ColumnCount = 1;
            this.Setting_ExtTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_ExtTLP.Controls.Add(this.Settings_Ext_Panel, 0, 1);
            this.Setting_ExtTLP.Controls.Add(this.Settings_ExtButton, 0, 3);
            this.Setting_ExtTLP.Controls.Add(this.Setting_Ext_InputPanel, 0, 2);
            this.Setting_ExtTLP.Controls.Add(this.Setting_Ext_HeaderPanel, 0, 0);
            this.Setting_ExtTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtTLP.Location = new System.Drawing.Point(0, 0);
            this.Setting_ExtTLP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Setting_ExtTLP.Name = "Setting_ExtTLP";
            this.Setting_ExtTLP.RowCount = 4;
            this.Setting_ExtTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Setting_ExtTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_ExtTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Setting_ExtTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Setting_ExtTLP.Size = new System.Drawing.Size(284, 261);
            this.Setting_ExtTLP.TabIndex = 3;
            // 
            // Settings_Ext_Panel
            // 
            this.Settings_Ext_Panel.AutoScroll = true;
            this.Settings_Ext_Panel.Controls.Add(this.Setting_ExtListBox);
            this.Settings_Ext_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_Ext_Panel.Location = new System.Drawing.Point(0, 33);
            this.Settings_Ext_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_Ext_Panel.Name = "Settings_Ext_Panel";
            this.Settings_Ext_Panel.Size = new System.Drawing.Size(284, 138);
            this.Settings_Ext_Panel.TabIndex = 1;
            // 
            // Setting_ExtListBox
            // 
            this.Setting_ExtListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtListBox.FormattingEnabled = true;
            this.Setting_ExtListBox.ItemHeight = 18;
            this.Setting_ExtListBox.Location = new System.Drawing.Point(0, 0);
            this.Setting_ExtListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Setting_ExtListBox.Name = "Setting_ExtListBox";
            this.Setting_ExtListBox.Size = new System.Drawing.Size(284, 138);
            this.Setting_ExtListBox.TabIndex = 2;
            this.Setting_ExtListBox.SelectedIndexChanged += new System.EventHandler(this.Setting_ExtListBox_SelectedIndexChanged);
            // 
            // Settings_ExtButton
            // 
            this.Settings_ExtButton.ColumnCount = 3;
            this.Settings_ExtButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Settings_ExtButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Settings_ExtButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.Settings_ExtButton.Controls.Add(this.Setting_ExtGetButton, 2, 0);
            this.Settings_ExtButton.Controls.Add(this.Setting_ExtRemoveButton, 1, 0);
            this.Settings_ExtButton.Controls.Add(this.Setting_ExtAddButton, 0, 0);
            this.Settings_ExtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_ExtButton.Location = new System.Drawing.Point(0, 231);
            this.Settings_ExtButton.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_ExtButton.Name = "Settings_ExtButton";
            this.Settings_ExtButton.RowCount = 1;
            this.Settings_ExtButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Settings_ExtButton.Size = new System.Drawing.Size(284, 30);
            this.Settings_ExtButton.TabIndex = 2;
            // 
            // Setting_ExtGetButton
            // 
            this.Setting_ExtGetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtGetButton.Location = new System.Drawing.Point(186, 0);
            this.Setting_ExtGetButton.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_ExtGetButton.Name = "Setting_ExtGetButton";
            this.Setting_ExtGetButton.Size = new System.Drawing.Size(98, 30);
            this.Setting_ExtGetButton.TabIndex = 2;
            this.Setting_ExtGetButton.Text = "読込";
            this.Setting_ExtGetButton.UseVisualStyleBackColor = true;
            this.Setting_ExtGetButton.Click += new System.EventHandler(this.Setting_ExtGetButton_Click);
            // 
            // Setting_ExtRemoveButton
            // 
            this.Setting_ExtRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtRemoveButton.Location = new System.Drawing.Point(93, 0);
            this.Setting_ExtRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_ExtRemoveButton.Name = "Setting_ExtRemoveButton";
            this.Setting_ExtRemoveButton.Size = new System.Drawing.Size(93, 30);
            this.Setting_ExtRemoveButton.TabIndex = 1;
            this.Setting_ExtRemoveButton.Text = "削除";
            this.Setting_ExtRemoveButton.UseVisualStyleBackColor = true;
            this.Setting_ExtRemoveButton.Click += new System.EventHandler(this.Setting_ExtRemoveButton_Click);
            // 
            // Setting_ExtAddButton
            // 
            this.Setting_ExtAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtAddButton.Location = new System.Drawing.Point(0, 0);
            this.Setting_ExtAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_ExtAddButton.Name = "Setting_ExtAddButton";
            this.Setting_ExtAddButton.Size = new System.Drawing.Size(93, 30);
            this.Setting_ExtAddButton.TabIndex = 0;
            this.Setting_ExtAddButton.Text = "追加";
            this.Setting_ExtAddButton.UseVisualStyleBackColor = true;
            this.Setting_ExtAddButton.Click += new System.EventHandler(this.Setting_ExtAddButton_Click);
            // 
            // Setting_Ext_InputPanel
            // 
            this.Setting_Ext_InputPanel.ColumnCount = 3;
            this.Setting_Ext_InputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Setting_Ext_InputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Setting_Ext_InputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_InExtTBox, 1, 0);
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_InColTBox, 1, 1);
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_Ext_InExtDesc, 0, 0);
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_Ext_InColDesc, 0, 1);
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_ExtColPic, 2, 0);
            this.Setting_Ext_InputPanel.Controls.Add(this.Setting_ExtSelLabel, 2, 1);
            this.Setting_Ext_InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Ext_InputPanel.Location = new System.Drawing.Point(0, 171);
            this.Setting_Ext_InputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_Ext_InputPanel.Name = "Setting_Ext_InputPanel";
            this.Setting_Ext_InputPanel.RowCount = 2;
            this.Setting_Ext_InputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Setting_Ext_InputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Setting_Ext_InputPanel.Size = new System.Drawing.Size(284, 60);
            this.Setting_Ext_InputPanel.TabIndex = 3;
            // 
            // Setting_InExtTBox
            // 
            this.Setting_InExtTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Setting_InExtTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_InExtTBox.Location = new System.Drawing.Point(80, 2);
            this.Setting_InExtTBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Setting_InExtTBox.Name = "Setting_InExtTBox";
            this.Setting_InExtTBox.Size = new System.Drawing.Size(121, 25);
            this.Setting_InExtTBox.TabIndex = 0;
            this.Setting_InExtTBox.WordWrap = false;
            this.Setting_InExtTBox.TextChanged += new System.EventHandler(this.Setting_InExtTBox_TextChanged);
            this.Setting_InExtTBox.Enter += new System.EventHandler(this.Setting_InExtTBox_Enter);
            this.Setting_InExtTBox.Leave += new System.EventHandler(this.Setting_InExtTBox_Leave);
            // 
            // Setting_InColTBox
            // 
            this.Setting_InColTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_InColTBox.Location = new System.Drawing.Point(80, 32);
            this.Setting_InColTBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Setting_InColTBox.Name = "Setting_InColTBox";
            this.Setting_InColTBox.Size = new System.Drawing.Size(121, 25);
            this.Setting_InColTBox.TabIndex = 1;
            this.Setting_InColTBox.WordWrap = false;
            this.Setting_InColTBox.TextChanged += new System.EventHandler(this.Setting_InColTBox_TextChanged);
            this.Setting_InColTBox.Enter += new System.EventHandler(this.Setting_InColTBox_Enter);
            this.Setting_InColTBox.Leave += new System.EventHandler(this.Setting_InColTBox_Leave);
            // 
            // Setting_Ext_InExtDesc
            // 
            this.Setting_Ext_InExtDesc.AutoSize = true;
            this.Setting_Ext_InExtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Ext_InExtDesc.Location = new System.Drawing.Point(3, 0);
            this.Setting_Ext_InExtDesc.Name = "Setting_Ext_InExtDesc";
            this.Setting_Ext_InExtDesc.Size = new System.Drawing.Size(74, 30);
            this.Setting_Ext_InExtDesc.TabIndex = 2;
            this.Setting_Ext_InExtDesc.Text = "拡張子";
            this.Setting_Ext_InExtDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Setting_Ext_InColDesc
            // 
            this.Setting_Ext_InColDesc.AutoSize = true;
            this.Setting_Ext_InColDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Ext_InColDesc.Location = new System.Drawing.Point(3, 30);
            this.Setting_Ext_InColDesc.Name = "Setting_Ext_InColDesc";
            this.Setting_Ext_InColDesc.Size = new System.Drawing.Size(74, 30);
            this.Setting_Ext_InColDesc.TabIndex = 3;
            this.Setting_Ext_InColDesc.Text = "色コード";
            this.Setting_Ext_InColDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Setting_ExtColPic
            // 
            this.Setting_ExtColPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtColPic.Location = new System.Drawing.Point(204, 4);
            this.Setting_ExtColPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Setting_ExtColPic.Name = "Setting_ExtColPic";
            this.Setting_ExtColPic.Size = new System.Drawing.Size(77, 22);
            this.Setting_ExtColPic.TabIndex = 4;
            this.Setting_ExtColPic.TabStop = false;
            // 
            // Setting_ExtSelLabel
            // 
            this.Setting_ExtSelLabel.AutoSize = true;
            this.Setting_ExtSelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtSelLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Setting_ExtSelLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Setting_ExtSelLabel.Location = new System.Drawing.Point(204, 30);
            this.Setting_ExtSelLabel.Name = "Setting_ExtSelLabel";
            this.Setting_ExtSelLabel.Size = new System.Drawing.Size(77, 30);
            this.Setting_ExtSelLabel.TabIndex = 5;
            this.Setting_ExtSelLabel.Text = "色選択";
            this.Setting_ExtSelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Setting_ExtSelLabel.Click += new System.EventHandler(this.Setting_ExtSelLabel_Click);
            // 
            // Setting_Ext_HeaderPanel
            // 
            this.Setting_Ext_HeaderPanel.ColumnCount = 2;
            this.Setting_Ext_HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Setting_Ext_HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.Setting_Ext_HeaderPanel.Controls.Add(this.Settings_ExtDescLabel, 0, 0);
            this.Setting_Ext_HeaderPanel.Controls.Add(this.Setting_ExtStatusLabel, 1, 0);
            this.Setting_Ext_HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Ext_HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.Setting_Ext_HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_Ext_HeaderPanel.Name = "Setting_Ext_HeaderPanel";
            this.Setting_Ext_HeaderPanel.RowCount = 1;
            this.Setting_Ext_HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Setting_Ext_HeaderPanel.Size = new System.Drawing.Size(284, 33);
            this.Setting_Ext_HeaderPanel.TabIndex = 4;
            // 
            // Settings_ExtDescLabel
            // 
            this.Settings_ExtDescLabel.AutoSize = true;
            this.Settings_ExtDescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_ExtDescLabel.Font = new System.Drawing.Font("メイリオ", 11F);
            this.Settings_ExtDescLabel.Location = new System.Drawing.Point(3, 0);
            this.Settings_ExtDescLabel.Name = "Settings_ExtDescLabel";
            this.Settings_ExtDescLabel.Size = new System.Drawing.Size(42, 33);
            this.Settings_ExtDescLabel.TabIndex = 1;
            this.Settings_ExtDescLabel.Text = "色";
            this.Settings_ExtDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setting_ExtStatusLabel
            // 
            this.Setting_ExtStatusLabel.AutoSize = true;
            this.Setting_ExtStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_ExtStatusLabel.Location = new System.Drawing.Point(51, 3);
            this.Setting_ExtStatusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.Setting_ExtStatusLabel.Name = "Setting_ExtStatusLabel";
            this.Setting_ExtStatusLabel.Size = new System.Drawing.Size(230, 27);
            this.Setting_ExtStatusLabel.TabIndex = 2;
            this.Setting_ExtStatusLabel.Text = "ステータス";
            this.Setting_ExtStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusClearTimer
            // 
            this.StatusClearTimer.Interval = 5000;
            this.StatusClearTimer.Tick += new System.EventHandler(this.StatusClearTimer_Tick);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // Setting_Part_Extensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Setting_ExtTLP);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Setting_Part_Extensions";
            this.Text = "Setting_Part_Extensions";
            this.Load += new System.EventHandler(this.Setting_Part_Extensions_Load);
            this.Setting_ExtTLP.ResumeLayout(false);
            this.Settings_Ext_Panel.ResumeLayout(false);
            this.Settings_ExtButton.ResumeLayout(false);
            this.Setting_Ext_InputPanel.ResumeLayout(false);
            this.Setting_Ext_InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_ExtColPic)).EndInit();
            this.Setting_Ext_HeaderPanel.ResumeLayout(false);
            this.Setting_Ext_HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Setting_ExtTLP;
        private System.Windows.Forms.Panel Settings_Ext_Panel;
        private System.Windows.Forms.ListBox Setting_ExtListBox;
        private System.Windows.Forms.TableLayoutPanel Settings_ExtButton;
        private System.Windows.Forms.Button Setting_ExtGetButton;
        private System.Windows.Forms.Button Setting_ExtRemoveButton;
        private System.Windows.Forms.Button Setting_ExtAddButton;
        private System.Windows.Forms.TableLayoutPanel Setting_Ext_InputPanel;
        private System.Windows.Forms.TextBox Setting_InExtTBox;
        private System.Windows.Forms.TextBox Setting_InColTBox;
        private System.Windows.Forms.Label Setting_Ext_InExtDesc;
        private System.Windows.Forms.Label Setting_Ext_InColDesc;
        private System.Windows.Forms.PictureBox Setting_ExtColPic;
        private System.Windows.Forms.Label Setting_ExtSelLabel;
        private System.Windows.Forms.TableLayoutPanel Setting_Ext_HeaderPanel;
        private System.Windows.Forms.Label Settings_ExtDescLabel;
        private System.Windows.Forms.Label Setting_ExtStatusLabel;
        private System.Windows.Forms.Timer StatusClearTimer;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}