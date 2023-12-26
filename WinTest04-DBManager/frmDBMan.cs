using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest04_DBManager
{
    public partial class frmDBMan : Form
    {
        public frmDBMan()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        List<string> colName = new List<string>();
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK) 
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();
                sqlCommand.Connection = sqlConn;
                sbLabel1.Text = "Database connected.";
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string sql = "select * from student";
            sqlCommand.CommandText = sql;
            SqlDataReader sr = sqlCommand.ExecuteReader();
            for(int i = 0; sr.Read(); i++)
            {
                for(int j = 0; j < sr.FieldCount; j++)
                {
                    tbSql.Text += sr.GetValue(j).ToString() + " ";
                }
                tbSql.Text += "\r\n";
            }
            sr.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataView.Rows.Clear();
            dataView.Columns.Clear();

            List<string> sarr = RunSql("select * from student");

            for (int i = 0; i < colName.Count; i++)
            {
                dataView.Columns.Add(colName[i], colName[i]);
            }
            for(int i = 0;i< sarr.Count; i++)
            {
                int rIndex = dataView.Rows.Add();
                for(int j = 0;j < colName.Count; j++)
                {
                    dataView.Rows[rIndex].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }
        private void viewSql(List<string> sarr)
        {
            if (sarr == null) return;
            dataView.Rows.Clear();
            dataView.Columns.Clear();

            for (int i = 0; i < colName.Count; i++)
            {
                dataView.Columns.Add(colName[i], colName[i]);
            }
            for (int i = 0; i < sarr.Count; i++)
            {
                int rIndex = dataView.Rows.Add();
                for (int j = 0; j < colName.Count; j++)
                {
                    dataView.Rows[rIndex].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }

        private List<string> RunSql(string sql)
        {
            List<string> sarr = new List<string>();
            try
            {
                sqlCommand.CommandText = sql;
                if(sql.Trim().ToLower().Substring(0,6) == "select") // SELECT / ___Select / sEleCt
                {
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    colName.Clear();
                    for(int j = 0; j < sr.FieldCount; j++)
                    {
                        colName.Add(sr.GetName(j).ToString());
                    }

                    for(int i = 0; sr.Read(); i++)
                    {
                        string str = "";
                        for(int j = 0; j < sr.FieldCount; j++)
                        {
                            str += sr.GetValue(j).ToString() + ",";
                        }
                        sarr.Add(str);
                    }
                    sr.Close();
                }
                else
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return sarr;
            }
            catch(Exception ex) 
            {
                sbLabel1.Text = ex.Message;
                return null;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            viewSql(RunSql("select * from student"));
        }

        private void mnuRunSql_Click(object sender, EventArgs e)
        {            
            viewSql(RunSql(tbSql.SelectedText));
        }
    }
}
