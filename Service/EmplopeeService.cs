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
                        item.SetValue(etem, Convert.ToInt32(objReader[item.Name]));
                    }
                    if (item.PropertyType.ToString() == "System.String")
                    {
                        item.SetValue(etem, objReader[item.Name].ToString());
                    }
                    if (item.PropertyType.ToString() == "System.Double")
                    {
                        item.SetValue(etem, Convert.ToDouble(objReader[item.Name]));
                    }
                }
                foreach (PropertyInfo item in Ppros)
                {
                    if (item.PropertyType.ToString() == "System.Int32")
                    {
                        item.SetValue(epos,Convert.ToInt32(objReader[item.Name]));
                    }
                    if (item.PropertyType.ToString() == "System.String")
                    {
                        item.SetValue(epos, objReader[item.Name].ToString());
                    }
                    if (item.PropertyType.ToString() == "System.Double")
                    {
                        item.SetValue(epos, Convert.ToDouble(objReader[item.Name]));
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
        /// <returns></returns>
        public int UpdateEmployeeInformation(Employee objEmployeeNew)
        {
            
            Type Etype = typeof(Employee);
            Type Ptype = typeof(Position);
            PropertyInfo[] Epros = Etype.GetProperties();
            PropertyInfo[] Ppros = Ptype.GetProperties();

            MySqlParameter[] eparam = new MySqlParameter[Epros.GetLength(0)-1];
            MySqlParameter[] pparam = new MySqlParameter[Ppros.GetLength(0)];

            string eqlw = "";
            string pqlw = "";

            string eql = "";
            string pql = "";

            Dictionary<String, Object> Edic = GetProDic(objEmployeeNew);
            int num = 0;
            foreach (PropertyInfo item in Epros)
            {
                if (item.PropertyType.ToString() == "System.Double" || item.PropertyType.ToString() == "System.Int32" || item.PropertyType.ToString() == "System.String")
                {
                    eparam[num] = new MySqlParameter("@" + item.Name.ToString(), item.GetValue(objEmployeeNew));
                    if (num == 0)
                        eqlw += item.Name.ToString() + "=" + "@" + item.Name.ToString() + " ";
                    if (num == eparam.Length - 1)
                        eql += item.Name.ToString() + "=" + "@" + item.Name.ToString() + " ";
                    else
                        eql += item.Name.ToString() + "=" + "@" + item.Name.ToString() + ",";
                    num++;
                }
            }
            num = 0;
            foreach (PropertyInfo item in Ppros)
            {
                if (item.PropertyType.ToString() == "System.Double" || item.PropertyType.ToString() == "System.Int32" || item.PropertyType.ToString() == "System.String")
                {
                    pparam[num] = new MySqlParameter("@" + item.Name.ToString(), item.GetValue(objEmployeeNew.position));
                    if (num == 0)
                        pqlw += item.Name.ToString() + "=" + "@" + item.Name.ToString() + " ";
                    if (num == pparam.Length - 1)
                        pql += item.Name.ToString() + "=" + "@" + item.Name.ToString() + " ";
                    else
                        pql += item.Name.ToString() + "=" + "@" + item.Name.ToString() + ",";
                    num++;
                }
            }
            
            
            string sql1 = "Update salary.employee set "+eql+" where "+eqlw;
            string sql2 = "Update salary.position set "+ pql + " where " + pqlw;
            //Sservice.UpdateByProcedure(sql1,eparam);
            //Sservice.UpdateByProcedure(sql1, pparam);
            //Console.WriteLine(sql1);
            Console.WriteLine(sql2);
            return Sservice.Update(sql1, eparam)+ Sservice.Update(sql2, pparam);
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
