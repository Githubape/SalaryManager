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
            LogService.WriteErrorLog(msg);
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

        public void Sqlupdatetest()
        {
            MySqlParameter[] eparam = new MySqlParameter[]
            {
                 new MySqlParameter("@Id","0"),
                new MySqlParameter("@Sex","不会吧"),
                new MySqlParameter("@BankAccount","34d4")
               
            };

            //string sql= "update salary.employee set Sex=@Sex, BankAccount = @BankAccount where Id =@Id";
            //string sql = "insert into salary.employee (employee.Eid,Name,employee.Sex,employee.BankAccount,employee.Egroup,employee.EntryTime ) values(46,0,0,0,0,0);";
            string sql = "insert into salary.employee() values()";
         
            Console.WriteLine( Sservice.InsertNl(sql,null));
        }
    }
}
