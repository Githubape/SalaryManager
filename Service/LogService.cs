using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Service
{
    public class LogService
    {
        /// <summary>
        /// 日志文件全名
        /// </summary>
        private static string logFileFullName = string.Empty;
        private static string LogFileFullName;


        /// <summary>
        /// 获取数据库服务器时间
        /// </summary>
        public static DateTime ServerTime
        {
            get
            {
                return new SqlService().GetServerTime();
            }
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteErrorLog(string msg)
        {
            LogFileFullName = System.Environment.CurrentDirectory + "\\ErrorLog\\"+DateTime.Now.ToString("yyyy-MM-dd") + ".log";//System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".log";
            //Console.WriteLine("LogPath::"+LogFileFullName);
            FileStream fs = new FileStream(LogFileFullName, FileMode.OpenOrCreate | FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string strMethodName = string.Empty;
            //获取调用栈对象
            StackTrace ss = new StackTrace(true);
            //取栈中第一个函数对象
            MethodBase mb = ss.GetFrame(1).GetMethod();
            //取得父方法类全名
            strMethodName += mb.DeclaringType.FullName + ".";
            //取得父方法名
            strMethodName += mb.Name;
            sw.WriteLine(string.Format("调用{0}时出错：{1}", strMethodName, msg));
           
            //sw.WriteLine(string.Format("[{0}] 调用{1}时出错：{2}", ServerTime.ToString(), strMethodName, msg));
            sw.Close();
            fs.Close();
            Console.WriteLine(string.Format("调用{0}时出错：{1}", strMethodName, msg));
        }

        public static void WriteLog(string msg)
        {
            LogFileFullName = System.Environment.CurrentDirectory + "\\Log\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";//System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".log";
            //Console.WriteLine("LogPath::"+LogFileFullName);
            FileStream fs = new FileStream(LogFileFullName, FileMode.OpenOrCreate | FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(msg);
            sw.Close();
            fs.Close();
            Console.WriteLine(msg);
        }
    }
}
