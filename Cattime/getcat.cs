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
    public partial class getcat : Form
    {
        public getcat()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.dataGridView1.RowHeadersVisible = false;
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

        private void Showhistroy()
        {
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                while (dataGridView1.Rows.Count != 0)//循环清除
                {
                    dataGridView1.Rows.RemoveAt(0);//清表中第一行
                }
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                if (comx1.SelectedIndex == 0)
                {
                    cmd.CommandText = "SELECT cattype,num,price,gettime FROM tockrecord order by gettime";
                }
                else
                {
                    cmd.CommandText = "SELECT cattype,num,price,gettime FROM tockrecord where cattype=@type order by gettime";
                    cmd.Parameters.Add("type", DbType.String).Value = comx1.Text.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboB1.Text == "" || numtext.Text == "0"|| int.Parse(pricebot.Text) < 0 || pricebot.Text=="")
            {
                MessageBox.Show("数据错误！");
                return;
            }
            if (cn.State != System.Data.ConnectionState.Open)
            {
                int oldnum=0;
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select num from cattype where cattype=@aaa";
                cmd.Parameters.Add("aaa", DbType.String).Value = comboB1.Text;
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    oldnum=sr.GetInt32(0);
                }
                sr.Close();
                cmd.CommandText = "UPDATE cattype SET num = @num WHERE  cattype=@cat";
                cmd.Parameters.Add("num", DbType.Int32).Value = int.Parse(numtext.Text)+ oldnum;
                cmd.Parameters.Add("cat", DbType.String).Value = comboB1.Text;
          
                SQLiteCommand cmd2 = new SQLiteCommand();
                cmd2.Connection = cn;
                cmd2.CommandText = "insert into tockrecord values (@cat,datetime('now','localtime'),@num,@price)";
                cmd2.Parameters.Add("num", DbType.Int32).Value = int.Parse(numtext.Text);
                cmd2.Parameters.Add("cat", DbType.String).Value = comboB1.Text;
                cmd2.Parameters.Add("price", DbType.Int32).Value = int.Parse(pricebot.Text);
                cmd.ExecuteReader();
                cmd2.ExecuteReader();
                MessageBox.Show("数量增加成功");
                numtext.Text = pricebot.Text = "0";
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showhistroy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboB2.Text == ""|| numtext2.Text == "0")
            {
                MessageBox.Show("数据错误！");
                return;            }

            if (cn.State != System.Data.ConnectionState.Open)
            {

                int num = 0;
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select count(1) from cattype where cattype=@aaa";//查是否是已存在猫咪品种
                cmd.Parameters.Add("aaa", DbType.String).Value = comboB2.Text;
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    num = sr.GetInt32(0);
                }
                sr.Close();
                if (num == 0)
                {
                    cmd.CommandText = "insert into cattype values (@cat,@num,@price)";
                    cmd.Parameters.Add("num", DbType.Int32).Value = int.Parse(numtext2.Text);
                    cmd.Parameters.Add("cat", DbType.String).Value = comboB2.Text;
                    cmd.Parameters.Add("price", DbType.Int32).Value = int.Parse(pricebot2_2.Text);
                    SQLiteCommand cmd2 = new SQLiteCommand();
                    cmd2.Connection = cn;
                    cmd2.CommandText = "insert into tockrecord values (@cat,datetime('now','localtime'),@num,@price)";//localtime表示时区：北京时间
                    cmd2.Parameters.Add("num", DbType.Int32).Value = int.Parse(numtext2.Text);
                    cmd2.Parameters.Add("cat", DbType.String).Value = comboB2.Text;
                    cmd2.Parameters.Add("price", DbType.Int32).Value = int.Parse(pricebot2.Text);
                    cmd.ExecuteReader();
                    cmd2.ExecuteReader();
                    
                    MessageBox.Show("新品种增加成功");
                    comboB2.Text = "";
                    numtext2.Text = pricebot2.Text = "0";
                    pricebot2_2.Text = "0";
                }
                else
                {
                    MessageBox.Show(comboB2.Text + " 品种已购进,不可重复添加");
                }

            }
            cn.Close();
            Showcat();
        }

        private void pricebot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)//若输入价格为非数字，不显示输入
            {
                e.Handled = true;
            }
        }

        private void pricebot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void pricebot2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void getcat_Load(object sender, EventArgs e)
        {
         
        }
    }
}
