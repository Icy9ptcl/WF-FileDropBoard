namespace WF_FileDropBoard {
    partial class ErrorDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDialog));
            this.MainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorDescLabel = new System.Windows.Forms.Label();
            this.BodyTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ErrorLogTBox = new System.Windows.Forms.TextBox();
            this.Error_MessageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Emes_Action_MailButton = new System.Windows.Forms.Button();
            this.Emes_Action_CopyLogButton = new System.Windows.Forms.Button();
            this.Emes_Action_ExitButton = new System.Windows.Forms.Button();
            this.MainTLP.SuspendLayout();
            this.BodyTLP.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTLP
            // 
            this.MainTLP.ColumnCount = 1;
            this.MainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTLP.Controls.Add(this.ErrorDescLabel, 0, 0);
            this.MainTLP.Controls.Add(this.BodyTLP, 0, 1);
            this.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTLP.Location = new System.Drawing.Point(0, 0);
            this.MainTLP.Name = "MainTLP";
            this.MainTLP.RowCount = 2;
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTLP.Size = new System.Drawing.Size(384, 361);
            this.MainTLP.TabIndex = 0;
            // 
            // ErrorDescLabel
            // 
            this.ErrorDescLabel.AutoSize = true;
            this.ErrorDescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorDescLabel.Font = new System.Drawing.Font("メイリオ", 12F);
            this.ErrorDescLabel.Location = new System.Drawing.Point(3, 0);
            this.ErrorDescLabel.Name = "ErrorDescLabel";
            this.ErrorDescLabel.Size = new System.Drawing.Size(378, 34);
            this.ErrorDescLabel.TabIndex = 0;
            this.ErrorDescLabel.Text = "エラーが発生しました";
            this.ErrorDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BodyTLP
            // 
            this.BodyTLP.ColumnCount = 1;
            this.BodyTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyTLP.Controls.Add(this.BodyPanel, 0, 0);
            this.BodyTLP.Controls.Add(this.panel2, 0, 1);
            this.BodyTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyTLP.Location = new System.Drawing.Point(0, 34);
            this.BodyTLP.Margin = new System.Windows.Forms.Padding(0);
            this.BodyTLP.Name = "BodyTLP";
            this.BodyTLP.RowCount = 2;
            this.BodyTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BodyTLP.Size = new System.Drawing.Size(384, 327);
            this.BodyTLP.TabIndex = 1;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.ErrorLogTBox);
            this.BodyPanel.Controls.Add(this.Error_MessageLabel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(3, 3);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(378, 291);
            this.BodyPanel.TabIndex = 1;
            // 
            // ErrorLogTBox
            // 
            this.ErrorLogTBox.BackColor = System.Drawing.Color.White;
            this.ErrorLogTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLogTBox.Location = new System.Drawing.Point(0, 93);
            this.ErrorLogTBox.Multiline = true;
            this.ErrorLogTBox.Name = "ErrorLogTBox";
            this.ErrorLogTBox.ReadOnly = true;
            this.ErrorLogTBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ErrorLogTBox.Size = new System.Drawing.Size(378, 198);
            this.ErrorLogTBox.TabIndex = 1;
            // 
            // Error_MessageLabel
            // 
            this.Error_MessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Error_MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.Error_MessageLabel.Name = "Error_MessageLabel";
            this.Error_MessageLabel.Size = new System.Drawing.Size(378, 93);
            this.Error_MessageLabel.TabIndex = 0;
            this.Error_MessageLabel.Text = "FileDropBoard で予期しないエラーが発生しました。\r\n恐れ入りますが、この内容を製作者(Hishis.yfmn@gmail.com)に連絡してください" +
    "。\r\n\r\nエラーログ:\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Emes_Action_MailButton);
            this.panel2.Controls.Add(this.Emes_Action_CopyLogButton);
            this.panel2.Controls.Add(this.Emes_Action_ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 297);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 30);
            this.panel2.TabIndex = 2;
            // 
            // Emes_Action_MailButton
            // 
            this.Emes_Action_MailButton.AutoSize = true;
            this.Emes_Action_MailButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Emes_Action_MailButton.Location = new System.Drawing.Point(109, 0);
            this.Emes_Action_MailButton.Name = "Emes_Action_MailButton";
            this.Emes_Action_MailButton.Size = new System.Drawing.Size(102, 30);
            this.Emes_Action_MailButton.TabIndex = 2;
            this.Emes_Action_MailButton.Text = "メーラーを起動";
            this.Emes_Action_MailButton.UseVisualStyleBackColor = true;
            this.Emes_Action_MailButton.Click += new System.EventHandler(this.Emes_Action_MailButton_Click);
            // 
            // Emes_Action_CopyLogButton
            // 
            this.Emes_Action_CopyLogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Emes_Action_CopyLogButton.Location = new System.Drawing.Point(211, 0);
            this.Emes_Action_CopyLogButton.Name = "Emes_Action_CopyLogButton";
            this.Emes_Action_CopyLogButton.Size = new System.Drawing.Size(98, 30);
            this.Emes_Action_CopyLogButton.TabIndex = 0;
            this.Emes_Action_CopyLogButton.Text = "ログをコピー";
            this.Emes_Action_CopyLogButton.UseVisualStyleBackColor = true;
            this.Emes_Action_CopyLogButton.Click += new System.EventHandler(this.Emes_Action_CopyLogButton_Click);
            // 
            // Emes_Action_ExitButton
            // 
            this.Emes_Action_ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Emes_Action_ExitButton.Location = new System.Drawing.Point(309, 0);
            this.Emes_Action_ExitButton.Name = "Emes_Action_ExitButton";
            this.Emes_Action_ExitButton.Size = new System.Drawing.Size(75, 30);
            this.Emes_Action_ExitButton.TabIndex = 1;
            this.Emes_Action_ExitButton.Text = "終了する";
            this.Emes_Action_ExitButton.UseVisualStyleBackColor = true;
            this.Emes_Action_ExitButton.Click += new System.EventHandler(this.Emes_Action_ExitButton_Click);
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.MainTLP);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.Text = "ErrorDialog";
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            this.MainTLP.ResumeLayout(false);
            this.MainTLP.PerformLayout();
            this.BodyTLP.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTLP;
        private System.Windows.Forms.Label ErrorDescLabel;
        private System.Windows.Forms.TableLayoutPanel BodyTLP;
        private System.Windows.Forms.Label Error_MessageLabel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.TextBox ErrorLogTBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Emes_Action_MailButton;
        private System.Windows.Forms.Button Emes_Action_CopyLogButton;
        private System.Windows.Forms.Button Emes_Action_ExitButton;
    }
}