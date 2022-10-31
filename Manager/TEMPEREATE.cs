using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data.SqlClient;
using Service;
using MySql.Data.MySqlClient;

namespace Manager
{
    public class TEMPEREATE
    {

        private SqlService Sservice = new SqlService();
        /// <summary>
        /// LogService 测试
        /// </summary>
        /// <param name="msg"></param>
        public static void Logtest(string msg)
        {
            LogService.WriteLog(msg);
        }

        public void Sqltest()
        {
            string sql = "SELECT Id,Password,UserName FROM salary.users";
            MySqlDataReader objReader = Sservice.GetReader(sql);
            while(objReader.Read())
            {
                Console.WriteLine(objReader["UserName"].ToString());
                Console.WriteLine(objReader["Password"].ToString());
                Console.WriteLine(Convert.ToInt32(objReader["Id"]));
            }
        }
    }
}
