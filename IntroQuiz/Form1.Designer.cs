namespace IntroQuiz
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.selectMusicControll1 = new IntroQuiz.SelectMusicControll();
            this.settingControll1 = new IntroQuiz.SettingControll();
            this.playerControl1 = new IntroQuiz.PlayerControl();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.playerControl1);
            this.mainPanel.Controls.Add(this.selectMusicControll1);
            this.mainPanel.Controls.Add(this.settingControll1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(774, 529);
            this.mainPanel.TabIndex = 0;
            // 
            // selectMusicControll1
            // 
            this.selectMusicControll1.Location = new System.Drawing.Point(3, 0);
            this.selectMusicControll1.Name = "selectMusicControll1";
            this.selectMusicControll1.Size = new System.Drawing.Size(774, 529);
            this.selectMusicControll1.TabIndex = 1;
            // 
            // settingControll1
            // 
            this.settingControll1.Location = new System.Drawing.Point(3, 0);
            this.settingControll1.Name = "settingControll1";
            this.settingControll1.Size = new System.Drawing.Size(774, 529);
            this.settingControll1.TabIndex = 0;
            // 
            // playerControl1
            // 
            this.playerControl1.Location = new System.Drawing.Point(3, 0);
            this.playerControl1.Name = "playerControl1";
            this.playerControl1.Size = new System.Drawing.Size(774, 529);
            this.playerControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "イントロクイズ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private SelectMusicControll selectMusicControll1;
        private SettingControll settingControll1;
        private PlayerControl playerControl1;
    }
}

