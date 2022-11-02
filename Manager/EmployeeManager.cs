using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Service;

namespace Manager
{
    public class EmployeeManager
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
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="objEmployeeNew"></param>
        /// <param name="objEmployeeOld"></param>
        /// <returns></returns>
        public int SetEmployeeInformation(Employee objEmployeeNew,Employee objEmployeeOld)
        {
            return objService.UpdateEmployeeInformation(objEmployeeNew,objEmployeeOld);
        }

        /// <summary>
        /// 晋档回调
        /// </summary>
        /// <returns></returns>
        public int Promotion()
        {
            ///Position
            return 0;
        }

        public Dictionary<String,Object> GetProDic()
        {
            return null;
        }
    }


}
