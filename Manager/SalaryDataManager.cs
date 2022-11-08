using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Service;

namespace Manager
{
    /// <summary>
    /// Salary工具包 直接被UI调用
    /// </summary>
    public class SalaryDataManager
    {
        /// <summary>
        /// Salary工具包
        /// </summary>
        private SalaryService objService = new SalaryService();

        /// <summary>
        /// 查询工资记录
        /// </summary>
        /// <returns></returns>
        public List<SalaryData> GetSalaryImformation()
        {
            return objService.QuerySalaryListInfo();
        }

        /// <summary>
        /// 修改工资信息
        /// </summary>
        /// <param name="objSalaryDataNew"></param>
        /// <param name="objSalaryDataOld"></param>
        /// <returns></returns>
        public int SetSalaryDataInformation(SalaryData objSalaryDataNew, bool ifinsert)
        {
            return objService.UpdateSalaryInformationSqlite(objSalaryDataNew, ifinsert);
            //return objService.UpdateSalaryDataInformation(objSalaryDataNew,ifinsert);
        }

        /// <summary>
        /// Get属性键值对
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public Dictionary<String, Object> GetProDic(SalaryData Sal)
        {
            Dictionary<String, Object> dic = objService.GetProDic(Sal);
            return dic;
        }

        /// <summary>
        /// 工资计算模块
        /// </summary>
        /// <param name="Salin"></param>
        /// <returns></returns>
        public SalaryData CountSalary(SalaryData Salin)
        {
            return null;
        }
    }
}
