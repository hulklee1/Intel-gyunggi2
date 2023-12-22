using System;
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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            string[] sarr = System.IO.Ports.SerialPort.GetPortNames();
            for(int i = 0; i < sarr.Length; i++) cbCom.Items.Add(sarr[i]);

        }
    }
}
