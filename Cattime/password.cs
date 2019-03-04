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
    public partial class password : Form
    {
        public password(string uid)
        {
            userid = uid;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private static string path = @Application.StartupPath + "\\DB\\CatHome.db";
        SQLiteConnection cn = new SQLiteConnection("data source=" + path);
        private string userid;
        private void button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= textBox2.Text)
            {
                MessageBox.Show("确认新密码错误");
            }
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT count(1) FROM password WHERE uid=@uid AND passw= @pass";//验证旧密码
                cmd.Parameters.Add("uid", DbType.String).Value = userid;
                cmd.Parameters.Add("pass", DbType.String).Value = textBox0.Text;
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    if (sr.GetInt32(0) == 1)//验证旧密码
                    {
                        SQLiteCommand cmd2 = new SQLiteCommand();
                        cmd2.Connection = cn;
                        cmd2.CommandText = "UPDATE password SET passw = @pass WHERE uid=@userid";//更新密码
                        cmd2.Parameters.Add("userid", DbType.String).Value = userid;
                        cmd2.Parameters.Add("pass", DbType.String).Value = textBox1.Text;
                        cmd2.ExecuteReader();

                    }
                    else
                    {
                        MessageBox.Show("旧密码输入错误");
                    }
                }
                sr.Close();
            }
            cn.Close();
            MessageBox.Show("密码更改成功！");
            this.Close();
        }
    }
}
