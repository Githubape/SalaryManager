using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetDimension.NanUI;
using MaterialSkin;

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

            // 初始化窗体
            WinFormium.CreateRuntimeBuilder(env =>
            {
                env.CustomCefSettings(settings =>
                {
                    // 在此设置CEF的相关参数
                });

                env.CustomCefCommandLineArguments(commandLine =>
                {
                    // 在此处指定CEF命令参数
                });
            }, app =>
            {
                // 指定启动窗体
                app.UseMainWindow(context => new TestWindow());
            })
            .Build()
            .Run();
       
        }
    }
}
