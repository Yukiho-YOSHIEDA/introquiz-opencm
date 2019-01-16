using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IntroQuiz
{
    public partial class SelectMusicControll : UserControl
    {
        public event MyEventHandler nextButtonClickHandler;

        private List<String> musicList;

        public SelectMusicControll()
        {
            InitializeComponent();
            Init();
        }

        public delegate void MyEventHandler(SelectMusicEventArgs selectMusicEventArgs);

        private void Init()
        {
            musicList = new List<string>();
            nextButton.Enabled = false;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "データが入っているフォルダを選択してください"
            };
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                var directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                foreach (var file in directoryInfo.GetFiles("*.wav"))
                {
                    selectMusicList.Items.Add(file.FullName);
                    musicList.Add(file.FullName);
                }
                foreach (var file in directoryInfo.GetFiles("*.wave"))
                {
                    selectMusicList.Items.Add(file.FullName);
                    musicList.Add(file.FullName);
                }
                nextButton.Enabled = true;
            }
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "ファイルを選択してください",
                Filter = "wavファイル(*.wav;*.wave)|*.wav;*.wave",
                Multiselect = true
            };

            if(openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach(var fileName in openFileDialog.FileNames)
                {
                    selectMusicList.Items.Add(fileName);
                    musicList.Add(fileName);
                }
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // コールバック
            nextButtonClickHandler(new SelectMusicEventArgs(musicList));
        }
    }

    public class SelectMusicEventArgs : EventArgs
    {
        private List<String> musicList;

        public SelectMusicEventArgs(List<String> musicList)
        {
            this.musicList = musicList;
        }

        public List<String> getMusicList()
        {
            return musicList;
        }
    }
}
