using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01_Base
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            cmbTest1.SelectedIndex = 0;
            cmbTest2.SelectedIndex = 1;
            cmbTest3.SelectedIndex = 2;
            cmbTest4.SelectedIndex = 3;
        }

        int flag = 0;
        private void btnTest_Click(object sender, EventArgs e)
        {
            //if (++flag == 1) { label1.Text = "안녕하세요"; }
            //else { label1.Text = "Hello!"; flag = 0; }
            //if (label1.Text == "안녕하세요") label1.Text = "Hello!";
            //else label1.Text = "안녕하세요";
            int n = (flag++) % 4; 
            switch(n) 
            {
                case 0:
                    if (cbTest1.Checked == false) break;
                    tbTest01.Text = $"{n+1}";
                    tbTest02.Text = "";
                    tbTest03.Text = "";
                    tbTest04.Text = "";
                    break;
                case 1:
                    if (cbTest2.Checked == false) break;
                    tbTest01.Text = "";
                    tbTest02.Text = $"{n+1}";
                    tbTest03.Text = "";
                    tbTest04.Text = "";
                    break;
                case 2:
                    if (cbTest3.Checked == false) break;
                    tbTest01.Text = "";
                    tbTest02.Text = "";
                    tbTest03.Text = $"{n+1}";
                    tbTest04.Text = "";
                    break;
                case 3:
                    if (cbTest4.Checked == false) break;
                    tbTest01.Text = "";
                    tbTest02.Text = "";
                    tbTest03.Text = "";
                    tbTest04.Text = $"{n+1}";
                    break;
            }
        }

        private void cbTest1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTest1.Checked) cmbTest1.Enabled = true;
            else cmbTest1.Enabled = false; 
        }

        private void cbTest2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTest2.Checked) cmbTest2.Enabled = true;
            else cmbTest2.Enabled = false;
        }

        private void cbTest3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTest3.Checked) cmbTest3.Enabled = true;
            else cmbTest3.Enabled = false;
        }

        private void cbTest4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTest4.Checked) cmbTest4.Enabled = true;
            else cmbTest4.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuUpper_Click(object sender, EventArgs e)
        {
            tbTest04.Text = tbTest04.Text.ToUpper();
        }

        private void mnuLower_Click(object sender, EventArgs e)
        {
            tbTest04.Text = tbTest04.Text.ToLower();
        }

        private void cmbTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTest01.Text = cmbTest1.Text;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog1.FileName;
            }
        }
    }
}
