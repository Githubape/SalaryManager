using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using MaterialSkin;
using System.Diagnostics;

using Manager;//删除标志

namespace SalaryManager
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
            ///禁止重复启动
            Process[] ProcessArray = Process.GetProcesses();
            int currentCount = 0;
            foreach(var item in ProcessArray)
            {
                if(item.ProcessName==Process.GetCurrentProcess().ProcessName)
                {
                    currentCount += 1;
                    if (currentCount > 1)
                        return;
                }
            }

            //////////////////////////测试模块//////////////////////////////
            //TEMPEREATE.Logtest("tst");//Log 测试 测试完毕
            ///new TEMPEREATE().Sqltest();//Sql测试 测试完毕
            //new TEMPEREATE().Sqlupdatetest();
            //new TEMPEREATE().GetDataTest();
            //new TEMPEREATE().InitExl();
            //////////////////////////////////////////////////////////////

            ///登录窗体

            Application.Run(new MainForm());
            return;
            //Application.Run(new LoginForm());
            //LoginForm LogF = new LoginForm();
            //if(DialogResult.OK==LogF.ShowDialog())
            //{
            //    ///功能界面
            //    Application.Run(new MainForm());
            //}




        }
    }
}
