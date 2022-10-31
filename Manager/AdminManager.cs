using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Service;
using Model;

namespace Manager
{
    public class AdminManager
    {
        /// <summary>
        /// 管理员访问对象
        /// </summary>
        private AdminService service = new AdminService();

        public Admin UserLogin(Admin objIn)
        {
            objIn = service.UserLogin(objIn);
            if(objIn!=null)
            {
                LogService.WriteLog(objIn.UserName + "LogIN");
            }
            return objIn;
        }
       
    }
}
