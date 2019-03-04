using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattime
{
    public partial class main : Form
    {
        private Form logi;
        private string username;
        private string userid;
        public main(Form f,string name, string uid, bool admin)
        {
           
            logi= f;
           // this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            username = name_la.Text = name;
            userid = uid;
            if (admin)
            {
                button5.Visible = true;
            }
            Showcat();
        }

        private static string path = @Application.StartupPath + "\\DB\\CatHome.db";
        SQLiteConnection cn = new SQLiteConnection("data source=" + path);
        
        private void Showcat()
        {
            cattype.Items.Clear();
            cattype.Items.Add("全部");
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT cattype FROM cattype order by cattype";
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    cattype.Items.Add(sr.GetString(0));
                }
                sr.Close();
            }
            cattype.SelectedIndex = 0;
            cattype_SelectedIndexChanged(null,null);
            cn.Close();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            logi.Show();
        }

        private void cattype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                while (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                if (cattype.SelectedIndex == 0)
                {
                    cmd.CommandText = "SELECT cattype,num,price FROM cattype order by cattype DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT cattype,num,price FROM cattype where cattype=@type";
                    cmd.Parameters.Add("type", DbType.String).Value = cattype.SelectedItem.ToString();
                   
                }
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView1);
                    dr.Cells[0].Value = sr.GetString(0);
                    dr.Cells[1].Value = sr.GetInt32(1);
                    dr.Cells[2].Value = sr.GetInt32(2);
                    dataGridView1.Rows.Insert(0, dr);
                }
                sr.Close();
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getcat gc = new getcat();
            gc.Owner = this;
            DialogResult result = gc.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Showcat();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outcat oc = new outcat();
            oc.Owner = this;
            DialogResult result = oc.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Showcat();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            password oc = new password(userid);
            oc.Owner = this;
            DialogResult result = oc.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Showcat();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



   
    }
}
