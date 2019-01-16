namespace IntroQuiz
{
    partial class SelectMusicControll
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
            this.selectMusicPanel = new System.Windows.Forms.Panel();
            this.fileButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.selectMusicList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nextButton = new System.Windows.Forms.Button();
            this.selectMusicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectMusicPanel
            // 
            this.selectMusicPanel.Controls.Add(this.nextButton);
            this.selectMusicPanel.Controls.Add(this.fileButton);
            this.selectMusicPanel.Controls.Add(this.folderButton);
            this.selectMusicPanel.Controls.Add(this.selectMusicList);
            this.selectMusicPanel.Controls.Add(this.label2);
            this.selectMusicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectMusicPanel.Location = new System.Drawing.Point(0, 0);
            this.selectMusicPanel.Name = "selectMusicPanel";
            this.selectMusicPanel.Size = new System.Drawing.Size(774, 529);
            this.selectMusicPanel.TabIndex = 11;
            // 
            // fileButton
            // 
            this.fileButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileButton.Location = new System.Drawing.Point(407, 374);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(213, 54);
            this.fileButton.TabIndex = 3;
            this.fileButton.Text = "ファイル選択";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.folderButton.Location = new System.Drawing.Point(156, 374);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(213, 54);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "フォルダ選択";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // selectMusicList
            // 
            this.selectMusicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Path});
            this.selectMusicList.Location = new System.Drawing.Point(77, 70);
            this.selectMusicList.Name = "selectMusicList";
            this.selectMusicList.Size = new System.Drawing.Size(627, 280);
            this.selectMusicList.TabIndex = 1;
            this.selectMusicList.UseCompatibleStateImageBehavior = false;
            this.selectMusicList.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "曲を選択してください";
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 623;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(280, 449);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(213, 54);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "次へ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // SelectMusicControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectMusicPanel);
            this.Name = "SelectMusicControll";
            this.Size = new System.Drawing.Size(774, 529);
            this.selectMusicPanel.ResumeLayout(false);
            this.selectMusicPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectMusicPanel;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.ListView selectMusicList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Button nextButton;
    }
}
