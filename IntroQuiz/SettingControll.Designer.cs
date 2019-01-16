namespace IntroQuiz
{
    partial class SettingControll
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.settingPanel = new System.Windows.Forms.Panel();
            this.portSetButton = new System.Windows.Forms.Button();
            this.portNamesCombBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.portSetButton);
            this.settingPanel.Controls.Add(this.portNamesCombBox);
            this.settingPanel.Controls.Add(this.label1);
            this.settingPanel.Controls.Add(this.InfoTextBox);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(0, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(774, 529);
            this.settingPanel.TabIndex = 6;
            // 
            // portSetButton
            // 
            this.portSetButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.portSetButton.Location = new System.Drawing.Point(558, 55);
            this.portSetButton.Name = "portSetButton";
            this.portSetButton.Size = new System.Drawing.Size(146, 57);
            this.portSetButton.TabIndex = 8;
            this.portSetButton.Text = "設定";
            this.portSetButton.UseVisualStyleBackColor = true;
            this.portSetButton.Click += new System.EventHandler(this.portSetButton_Click);
            // 
            // portNamesCombBox
            // 
            this.portNamesCombBox.FormattingEnabled = true;
            this.portNamesCombBox.Location = new System.Drawing.Point(198, 70);
            this.portNamesCombBox.Name = "portNamesCombBox";
            this.portNamesCombBox.Size = new System.Drawing.Size(342, 32);
            this.portNamesCombBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(105, 150);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(587, 324);
            this.InfoTextBox.TabIndex = 5;
            // 
            // SettingControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingPanel);
            this.Name = "SettingControll";
            this.Size = new System.Drawing.Size(774, 529);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Button portSetButton;
        private System.Windows.Forms.ComboBox portNamesCombBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InfoTextBox;
    }
}
