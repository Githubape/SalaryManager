using System;
using System.Collections.Generic;
using System.Reflection;
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
        /// Service查询员工列表   
        /// </summary>
        /// <returns></returns>
        public List<Employee> QueryEmployeeListInfo()
        {
            string sql = "SELECT *  FROM salary.employee Left Join salary.position on salary.employee.Id=salary.position.Eid where salary.position.Abolish=0";
            MySqlDataReader objReader = Sservice.GetReader(sql);
            List<Employee> EList = new List<Employee>();
            Type Etype = typeof(Employee);
            Type Ptype = typeof(Position);
            PropertyInfo[] Epros= Etype.GetProperties();
            PropertyInfo[] Ppros = Ptype.GetProperties();
            //foreach(PropertyInfo item in Ppros)
            //{
            //    Console.WriteLine(item.Name+" "+item.PropertyType);
            //}
            
            
            while (objReader.Read())
            {               
                Employee etem = new Employee();
                Position epos = new Position();

                foreach (PropertyInfo item in Epros)
                {
                    if (item.PropertyType.ToString() == "System.Int32")
                    {
                        Etype.GetProperty(item.Name).SetValue(etem, Convert.ToInt32(objReader[item.Name]));
                    }
                    if (item.PropertyType.ToString() == "System.String")
                    {
                        Etype.GetProperty(item.Name).SetValue(etem, objReader[item.Name].ToString());
                    }
                    if (item.PropertyType.ToString() == "System.Double")
                    {
                        Etype.GetProperty(item.Name).SetValue(etem, Convert.ToDouble(objReader[item.Name]));
                    }
                }
                foreach (PropertyInfo item in Ppros)
                {
                    if (item.PropertyType.ToString() == "System.Int32")
                    {
                        Ptype.GetProperty(item.Name).SetValue(epos,Convert.ToInt32(objReader[item.Name]));
                    }
                    if (item.PropertyType.ToString() == "System.String")
                    {
                        Ptype.GetProperty(item.Name).SetValue(epos, objReader[item.Name].ToString());
                    }
                    if (item.PropertyType.ToString() == "System.Double")
                    {
                        Ptype.GetProperty(item.Name).SetValue(epos, Convert.ToDouble(objReader[item.Name]));
                    }
                }
                etem.position = epos;
                //foreach (PropertyInfo item in Epros)
                //{

                //        Console.WriteLine( Etype.GetProperty(item.Name).GetValue(etem));
   
                //}
                EList.Add(etem);
                
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
            Type Etype = typeof(Employee);
            Type Ptype = typeof(Position);
            PropertyInfo[] Epros = Etype.GetProperties();
            PropertyInfo[] Ppros = Ptype.GetProperties();
            MySqlParameter[] eparam = new MySqlParameter[Epros.GetLength(0)];
            MySqlParameter[] pparam = new MySqlParameter[Ppros.GetLength(0)];


            MySqlParameter[] param = new MySqlParameter[]
           {
                new MySqlParameter("@EId",objEmployeeOld.Eid),
           };
            string sql1 = "update";
            string sql2 = "set";
            string sql3 = "[where";
            string sql4 = "]";
            string sql = sql1 + "salary.employee" + sql2 + sql3 + sql4;
         return new SqlService().UpdateByProcedure("update salary.employee set 字段1=@var [where E_id=@EId]", param);
        }
        /// <summary>
        /// 获取Employee 属性字典
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public Dictionary<String,Object> GetProDic(Employee Emp)
        {
            Dictionary<String, Object> dic = ClassTools.GetProDic(Emp);
            Dictionary<String, Object> pdic = ClassTools.GetProDic(Emp.position);
            Dictionary<String, Object> Fdic = dic.Union(pdic).ToDictionary(k => k.Key, v => v.Value);
            return Fdic;
        }
    }


}
