using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Memo
{
    public partial class frmMemo : Form
    {
        public frmMemo()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if(r == DialogResult.OK) 
            {
                string fn = openFileDialog1.FileName;
                FileStream fi = new FileStream(fn, FileMode.Open);
                StreamReader sr = new StreamReader(fi);
                tbMemo.Text = sr.ReadToEnd();
            }
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearch frm = new frmSearch(1);
                frm.ShowDialog();
                string s1 = frm.tbFind.Text;
                tbMemo.Select(tbMemo.Text.IndexOf(s1), s1.Length);     
            }
            catch { }
        }

        private void mnuReplace_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearch frm = new frmSearch();
                frm.ShowDialog();
                string s1 = frm.tbFind.Text;
                string s2 = frm.tbReplace.Text;
                tbMemo.Text = tbMemo.Text.Replace(s1, s2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
