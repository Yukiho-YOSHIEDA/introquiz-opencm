using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using IntroQuiz.model;

namespace IntroQuiz
{
    public partial class PlayerControl : UserControl
    {

        private List<String> musicList;

        private SoundPlayer soundPlayer;

        private bool isSelectedMusic;

        private String nowMusicName;

        private bool isMusicListEmpty;

        private String nowAnsowerer;

        public event MyEventHandler judgeEventHandler;

        public delegate void MyEventHandler(JudgeEventArgs judgeEventArgs);

        public PlayerControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            nextButton.Enabled = false;
            correctButton.Enabled = false;
            uncorrectButton.Enabled = false;
            isSelectedMusic = false;
            isMusicListEmpty = false;
            nowMusicName = "";
        }

        public void SetMusicList(List<String> musicList)
        {
            this.musicList = musicList;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!isSelectedMusic)
            {
                SelectNext();
            }
            songLabel.Text = "再生中：" + nowMusicName;
            ansowerLabel.Text = "解答者：";
            soundPlayer.Play();

            // ボタンを止める
            playButton.Enabled = false;

            if (!isMusicListEmpty)
            {
                nextButton.Enabled = true;
            }
            correctButton.Enabled = true;
            uncorrectButton.Enabled = true;
        }

        private void SelectNext()
        {
            var index = new Random().Next(musicList.Count);
            nowMusicName = musicList[index];
            soundPlayer = new SoundPlayer(nowMusicName);
            songLabel.Text = "次の曲：" + nowMusicName;
            musicList.RemoveAt(index);
            isSelectedMusic = true;

            if (musicList.Count == 0)
            {
                nextButton.Enabled = false;
                isMusicListEmpty = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();

            SelectNext();

            playButton.Enabled = true;
        }

        public void RewriteName(String name)
        {
            ansowerLabel.Text = "解答者：" + name;
            nowAnsowerer = name;
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            judgeEventHandler(new JudgeEventArgs
            {
                Order = new OrderModel
                {
                    Order = Enum.OrderEnum.Correct,
                    Answerer = nowAnsowerer
                }
            });

            correctButton.Enabled = false;
            uncorrectButton.Enabled = false;
            playButton.Enabled = true;
            nextButton.Enabled = true;

            isSelectedMusic = false;
        }

        private void uncorrectButton_Click(object sender, EventArgs e)
        {
            judgeEventHandler(new JudgeEventArgs
            {
                Order = new OrderModel
                {
                    Order = Enum.OrderEnum.Uncorrect,
                    Answerer = nowAnsowerer
                }
            });

            correctButton.Enabled = false;
            uncorrectButton.Enabled = false;
        }

        public void PauseSound()
        {
            soundPlayer.Stop();

            correctButton.Enabled = true;
            uncorrectButton.Enabled = true;
            playButton.Enabled = false;
            nextButton.Enabled = false;
        }

    }
}
