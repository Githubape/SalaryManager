using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using NetDimension.NanUI;
using MaterialSkin;
>>>>>>> e0663af87cf0245f0a29833fcce37e52d4ae65de

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
            Application.Run(new LoginForm());
            // 初始化窗体
            //WinFormium.CreateRuntimeBuilder(env =>
            //{
            //    env.CustomCefSettings(settings =>
            //    {
            //        // 在此设置CEF的相关参数
            //    });

            //    env.CustomCefCommandLineArguments(commandLine =>
            //    {
            //        // 在此处指定CEF命令参数
            //    });
            //}, app =>
            //{
            //    // 指定启动窗体
            //    // 测试界面改成TestWindow()即可
            //    app.UseMainWindow(context => new SaMLoginUI());
               
            //})
            //.Build()
            //.Run();
       
        }
    }
}
