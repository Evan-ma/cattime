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
    public partial class outcat : Form
    {
        public outcat()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            //this.dataGridView1.RowHeadersVisible = false;
            Showcat();
     
        }
        private static string path = @Application.StartupPath + "\\DB\\CatHome.db";
        SQLiteConnection cn = new SQLiteConnection("data source=" + path);
        private void Showcat()
        {
            comboB1.Items.Clear();
            comx1.Items.Clear();
            comx1.Items.Add("全部");
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT cattype FROM cattype order by cattype";
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    comboB1.Items.Add(sr.GetString(0));
                    comx1.Items.Add(sr.GetString(0));
                }
                sr.Close();
            }
            if (comboB1.Items.Count > 0)
            {
                comboB1.SelectedIndex = 0;
            }
            comx1.SelectedIndex = 0;
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboB1.Text == "" || numtext.Text == "0")
            {
                MessageBox.Show("数据错误！");
                return;
            }
            if (cn.State != System.Data.ConnectionState.Open)
            {
                int oldnum = 0;
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select num from cattype where cattype=@aaa";
                cmd.Parameters.Add("aaa", DbType.String).Value = comboB1.Text;
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    oldnum = sr.GetInt32(0);
                }
                int sum =oldnum - int.Parse(numtext.Text);
                if (sum < 0)
                {
                    MessageBox.Show("库存不够 \r\n" + comboB1.Text + " 剩余" + oldnum + "只");
                    return;
                }
                sr.Close();
                cmd.CommandText = "UPDATE cattype SET num = @num WHERE  cattype=@cat";
                cmd.Parameters.Add("num", DbType.Int32).Value = sum;
                cmd.Parameters.Add("cat", DbType.String).Value = comboB1.Text;
                SQLiteCommand cmd2 = new SQLiteCommand();
                cmd2.Connection = cn;
                cmd2.CommandText = "insert into shiprecord values (@cat,datetime('now','localtime'),@num,@price)";
                cmd2.Parameters.Add("num", DbType.Int32).Value = int.Parse(numtext.Text);
                cmd2.Parameters.Add("cat", DbType.String).Value = comboB1.Text;
                
                cmd2.Parameters.Add("price", DbType.Int32).Value = int.Parse(pricel.Text.Substring(0, pricel.Text.Length- 3));
                cmd.ExecuteReader();
                cmd2.ExecuteReader();
                MessageBox.Show("出售成功");
                numtext.Text = "0";
            }
            cn.Close();
        }
        int price = 0;
        private void comboB1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int num = 0;
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT price FROM cattype where cattype =@cat";
                cmd.Parameters.Add("cat", DbType.String).Value = comboB1.Text;
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    price = sr.GetInt32(0);
                    pricel.Text = price.ToString()+ "(￥)";
                    sum.Text = (price * int.Parse(numtext.Text)).ToString() + "(￥)";
                }
                sr.Close();
            }
            cn.Close();
            num = int.Parse(numtext.Text);
            sum.Text = (price * num).ToString()+ "(￥)";
        }

        private void numtext_ValueChanged(object sender, EventArgs e)
        {
            sum.Text = price * numtext.Value + "(￥)";//价格*数量
        }

        private void button2_Click(object sender, EventArgs e)
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
                if (comx1.SelectedIndex == 0)
                {
                    cmd.CommandText = "SELECT cattype,num,price,outtime FROM shiprecord order by outtime";
                }
                else
                {
                    cmd.CommandText = "SELECT cattype,num,price,outtime FROM shiprecord where cattype=@type order by outtime";
                    cmd.Parameters.Add("type", DbType.String).Value = comx1.Text;
                }
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView1);
                    dr.Cells[0].Value = sr.GetString(0);
                    dr.Cells[1].Value = sr.GetInt32(1);
                    dr.Cells[2].Value = sr.GetInt32(2);
                    dr.Cells[3].Value = sr.GetInt32(1) * sr.GetInt32(2);
                    dr.Cells[4].Value = sr.GetDateTime(3);
                    dataGridView1.Rows.Insert(0, dr);
                }
                sr.Close();
            }
            cn.Close();
        }

    
    }
}
