using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattime
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = @Application.StartupPath + "\\DB\\CatHome.db";
            if (!File.Exists(path))
            {
                MessageBox.Show("程序数据已丢失！\r\n程序无法打开","提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {
                Application.Run(new Login());
            }
       
        }
    }
}
