namespace IntroQuiz
{
    partial class PlayerControl
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
            this.songLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.ansowerLabel = new System.Windows.Forms.Label();
            this.correctButton = new System.Windows.Forms.Button();
            this.uncorrectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.songLabel.Location = new System.Drawing.Point(125, 72);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(121, 33);
            this.songLabel.TabIndex = 0;
            this.songLabel.Text = "次の曲：";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.playButton.Location = new System.Drawing.Point(187, 137);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(144, 138);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "▶";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(402, 137);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(139, 138);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ansowerLabel
            // 
            this.ansowerLabel.AutoSize = true;
            this.ansowerLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ansowerLabel.Location = new System.Drawing.Point(125, 308);
            this.ansowerLabel.Name = "ansowerLabel";
            this.ansowerLabel.Size = new System.Drawing.Size(127, 33);
            this.ansowerLabel.TabIndex = 3;
            this.ansowerLabel.Text = "解答者：";
            // 
            // correctButton
            // 
            this.correctButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.correctButton.ForeColor = System.Drawing.Color.Red;
            this.correctButton.Location = new System.Drawing.Point(187, 366);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(144, 138);
            this.correctButton.TabIndex = 4;
            this.correctButton.Text = "〇";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // uncorrectButton
            // 
            this.uncorrectButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uncorrectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uncorrectButton.Location = new System.Drawing.Point(397, 366);
            this.uncorrectButton.Name = "uncorrectButton";
            this.uncorrectButton.Size = new System.Drawing.Size(144, 138);
            this.uncorrectButton.TabIndex = 5;
            this.uncorrectButton.Text = "✖";
            this.uncorrectButton.UseVisualStyleBackColor = true;
            this.uncorrectButton.Click += new System.EventHandler(this.uncorrectButton_Click);
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uncorrectButton);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.ansowerLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.songLabel);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(774, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label ansowerLabel;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Button uncorrectButton;
    }
}
