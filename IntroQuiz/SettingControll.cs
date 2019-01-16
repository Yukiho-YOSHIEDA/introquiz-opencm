using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IntroQuiz
{
    public partial class SettingControll : UserControl
    {
        public event MyEventHandler PortSetButtonClickEvent;

        public SettingControll()
        {
            InitializeComponent();
            Init();
        }

        //デリゲートを定義
        public delegate void MyEventHandler(SettingControlEventArgs settingControlEventArgs);

        private void portSetButton_Click(object sender, EventArgs e)
        {
            if (portNamesCombBox.SelectedItem == null)
            {
                InfoTextBox.Text = "ポートを選択してください";
                return;
            }
            String portName = portNamesCombBox.SelectedItem.ToString();

            // コールバック
            PortSetButtonClickEvent(new SettingControlEventArgs(portName));   
        }

        private void Init()
        {
            var portNames = SerialPort.GetPortNames();
            var portNamesList = new List<String>();

            portNamesList.AddRange(portNames);

            // コンボボックスにポート名を追加
            portNamesList.ForEach(portName => portNamesCombBox.Items.Add(portName));
        }
    }

    public class SettingControlEventArgs : EventArgs
    {
        private String portName;

        public SettingControlEventArgs(String portName)
        {
            this.portName = portName;
        }

        public String getPortName()
        {
            return portName;
        }
    }
}
