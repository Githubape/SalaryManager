using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class SalaryService
    {
        //private SqlService Sservice = new SqlService();
        SqliteHelper Sqlhelper = SqliteHelper.Instance;

        /// <summary>
        /// Sqlite 查询员工列表
        /// </summary>
        /// <returns></returns>
        public List<SalaryData> QuerySalaryListInfo()
        {
            List<SalaryData> SlaList = Sqlhelper.Query<SalaryData>("select * from salarydata");                  
            return SlaList;
        }

        /// <summary>
        /// Sllite 更工资工信息
        /// </summary>
        /// <returns></returns>
        public int UpdateSalaryInformationSqlite(SalaryData objSalaryDatanew, bool ifinsert)
        {
            if (ifinsert)
            {
                return Sqlhelper.Add<SalaryData>(objSalaryDatanew);
            }
            else
            {
                return Sqlhelper.Update<SalaryData>(objSalaryDatanew);
            }
        }

        /// <summary>
        /// 获取Salary 属性字典
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public Dictionary<String, Object> GetProDic(SalaryData Sla)
        {
            Dictionary<String, Object> dic = ClassTools.GetProDic(Sla);
            return dic;
        }


    }
}
