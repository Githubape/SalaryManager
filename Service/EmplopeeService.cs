using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Service
{
    /// <summary>
    /// Employee 工具包UI不可见
    /// </summary>
    public class EmplopeeService
    {
        private SqlService Sservice = new SqlService();
        /// <summary>
        /// Service查询员工列表       !!!!!!!!!!!!!!!!!!!!!!!!!!!这里没写完只做样例!!!!!!!!!!!!!!!!!!!!!!!
        /// </summary>
        /// <returns></returns>
        public List<Employee> QueryEmployeeListInfo()
        {
            string sql = "select A,B,C form Employee&&Position";
            MySqlDataReader objReader=Sservice.GetReader(sql);
            List<Employee> EList = new List<Employee>();
            while (objReader.Read())
            {
                EList.Add(new Employee()
                {
                    E_id=Convert.ToInt32(objReader["E_id"]),
                    Name = objReader["Name"].ToString(),
                    BankAccount = Convert.ToInt32(objReader["BankAccount"]),
                    E_group = objReader["E_group"].ToString(),
                    E_type = objReader[""].ToString(),
                    EnttyTime = objReader[""].ToString(),

                    position=new Position()
                    {
                        WorkType=objReader[""].ToString(),
                        Post=objReader[""].ToString(),
                        
                    }
                });
            }
            objReader.Close();
            return EList;
        }
        /// <summary>
        /// 更新员工信息 ！！！！！！！！！！！！！！！！！！！！！芝士举例，内具体容代填！！！！！！！！！！！！！！！！！！！！！！！
        /// </summary>
        /// <param name="objEmployeeNew"></param>
        /// <param name="objEmployeeOld"></param>
        /// <returns></returns>
        public int UpdateEmployeeInformation(Employee objEmployeeNew, Employee objEmployeeOld)
        {
            MySqlParameter[] param = new MySqlParameter[]
           {
                new MySqlParameter("@EId",objEmployeeOld.E_id),


           };

         return new SqlService().UpdateByProcedure("update 表名 set 字段1=@var [where E_id=@EId]", param);
        }
    }


}
