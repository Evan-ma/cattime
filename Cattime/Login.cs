using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Cattime
{
    public partial class Login : Form
    {
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;//居中显示窗口
            InitializeComponent();//加载控件

        }     
        private static string path = @Application.StartupPath + "\\DB\\CatHome.db"; 
        SQLiteConnection cn = new SQLiteConnection("data source=" + path);
        private void land_btm_Click(object sender, EventArgs e)
        {
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = cn;
                sqlcmd.CommandText = "SELECT count(1),name,admin FROM password WHERE uid=@uid AND passw= @pass";
                sqlcmd.Parameters.Add("uid", DbType.String).Value = job_num.Text;//
                sqlcmd.Parameters.Add("pass", DbType.String).Value = paswd.Text;

                SQLiteDataReader sr = sqlcmd.ExecuteReader();
                while (sr.Read())//sr.Read()一行一行读数据
                {
                    if (sr.GetInt32(0) == 1)
                    {
                        string name = sr.GetString(1);
                        main mn = new main(this, name, job_num.Text, sr.GetBoolean(2));
                        mn.StartPosition = FormStartPosition.CenterScreen;
                        mn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                        paswd.Text = null;
                    }
                }
                sr.Close();
            }
            cn.Close();
        }
    }
}
