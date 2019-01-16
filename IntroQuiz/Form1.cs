using IntroQuiz.Enum;
using IntroQuiz.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroQuiz
{
    public partial class Form1 : Form
    {
        private String portName;
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 起動時設定メソッド
        /// </summary>
        private void Init()
        {
            // 必要なView以外を非表示
            settingControll1.Dock = DockStyle.Fill;
            selectMusicControll1.Visible = false;
            playerControl1.Visible = false;

            settingControll1.PortSetButtonClickEvent += SettingControll1_PortSetButtonClickEvent;
            selectMusicControll1.nextButtonClickHandler += SelectMusicControll1_nextButtonClickHandler;
            playerControl1.judgeEventHandler += PlayerControl1_judgeEventHandler;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReadSerial();
        }

        private void PlayerControl1_judgeEventHandler(JudgeEventArgs judgeEventArgs)
        {
            serialPort.WriteLine(judgeEventArgs.Order.Order.ToString() + "," + 
                judgeEventArgs.Order.Answerer);
        }

        private void OpenSerial()
        {
            int baudRate = 9600;
            Parity parity = Parity.None;
            int dataBits = 8;
            StopBits stopBits = StopBits.One;

            serialPort = new SerialPort(portName);
            serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 非同期通信
        /// </summary>
        /// <param name="selectMusicEventArgs"></param>
        private async void AsyncSelialConnect()
        {
            await Task.Run(() => ReadSerial());
        }

        private void ReadSerial()
        {
            var message = serialPort.ReadLine();

            var order = ConvertToOrderModel(message.Split(','));
            if(order != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    playerControl1.RewriteName(order.Answerer);
                    playerControl1.PauseSound();
                });
            }
        }

        private OrderModel ConvertToOrderModel(String[] messages)
        {
            // 適するフォーマットに従っていない
            if(messages.Length != 2)
            {
                return null;
            }
            if (!messages[0].Contains("answer"))
            {
                return null;
            }

            var order = new OrderModel
            {
                Order = OrderEnum.Answer,
                Answerer = messages[1]
            };

            return order;
        }

        private void SelectMusicControll1_nextButtonClickHandler(SelectMusicEventArgs selectMusicEventArgs)
        {
            settingControll1.Visible = false;
            selectMusicControll1.Visible = false;
            playerControl1.Visible = true;
            playerControl1.Dock = DockStyle.Fill;

            playerControl1.SetMusicList(selectMusicEventArgs.getMusicList());
        }

        private void SettingControll1_PortSetButtonClickEvent(SettingControlEventArgs settingControlEventArgs)
        {
            settingControll1.Visible = false;
            selectMusicControll1.Visible = true;
            playerControl1.Visible = false;
            selectMusicControll1.Dock = DockStyle.Fill;

            portName = settingControlEventArgs.getPortName();
            OpenSerial();
            AsyncSelialConnect();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void folderButton_Click(object sender, EventArgs e)
        {

        }

        private void fileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
