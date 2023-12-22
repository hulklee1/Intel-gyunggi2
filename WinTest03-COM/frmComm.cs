using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest03_COM
{
    public partial class frmComm : Form
    {
        public frmComm()
        {
            InitializeComponent();
        }

        delegate void AddTextCB(string text, int n);
        void AddText(string text, int op = 0)
        {
            if (tbTerminal.InvokeRequired)
            {
                AddTextCB cb = new AddTextCB(AddText);
                object[] obj = { text, op };
                Invoke(cb, obj);
            }
            else
            {
                tbTerminal.Text += text;
                if(op == 0)
                    tbTerminal.Text += "\r\n";
            }
        }
        private void mnuSetup_Click(object sender, EventArgs e)
        {
            // 1. 통신설정
            // 2. 환경설정 : 배경색, Font 
            frmConfig frm = new frmConfig();
            frm.ShowDialog();

            //string str = frm.cbParity.Text;
            //serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), str, true); 
            serialPort1.Parity = (Parity)frm.cbParity.SelectedIndex;
            serialPort1.DataBits = int.Parse(frm.cbData.Text);
            serialPort1.StopBits = (StopBits)frm.cbStop.SelectedIndex;
            serialPort1.BaudRate = int.Parse(frm.cbBaud.Text);
            serialPort1.PortName = frm.cbCom.Text;
            // COM1:115200N81
            string strComm = $"{frm.cbCom.Text}:{frm.cbBaud.Text}{frm.cbParity.Text[0]}";
            strComm += $"{frm.cbData.Text}{frm.cbStop.SelectedIndex}";
            //this.Text = strComm ;
            AddText($"Communication String {strComm}");
        }

        private void mnuRestart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); 
                AddText($"{serialPort1.PortName} Port Closed.");
            }
            serialPort1.Open();
            AddText($"{serialPort1.PortName} Port Open success!");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadExisting();
            AddText(str, 1);
        }
    }
}
