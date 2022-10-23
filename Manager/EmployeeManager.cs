using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Service;

namespace Manager
{
    class EmployeeManager
    {
        /// <summary>
        /// Employee工具包直接被UI使用
        /// </summary>
        private EmplopeeService objService=new EmplopeeService();
        /// <summary>
        /// 伪查询员工列表
        /// </summary>
        /// <returns></returns>
        public  List<Employee> GetEmployeeInformation()
        {
            return objService.QueryEmployeeListInfo();
        }

        public int SetEmployeeInformation(Employee objEmployeeNew,Employee objEmployeeOld)
        {
            return objService.UpdateEmployeeInformation(objEmployeeNew,objEmployeeOld);
        }
    }
}
