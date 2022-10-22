using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;
using System.Data.SqlClient;

namespace Service
{
    /// <summary>
    /// Employee 工具包UI不可见
    /// </summary>
    public class EmplopeeService
    {
        /// <summary>
        /// Service查询员工列表
        /// </summary>
        /// <returns></returns>
        public List<Employee> QueryEmployeeListInfo()
        {
            string sql = "select ";
            SqlDataReader objReader;
            return null;
        }
    }
}
