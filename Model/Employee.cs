/***********************************
* 描 述：
* 作 者：
* 版 本：1.0
* 创建时间：20221021
* 
* ****************************
* 命名空间：Model
* 类名：Employee
* 
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Emplopee imformation
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Emplopee id
        /// </summary>
        public int E_id { get; set; }
        /// <summary>
        /// Employee name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Employee bankaccount
        /// </summary>
        public int BankAccount { get; set; }
        /// <summary>
        /// 员工组
        /// </summary>
        public string E_group { get; set; }
        /// <summary>
        /// 工种
        /// </summary>
        public string E_type { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public string EnttyTime { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public Position position { get; set; }
    }
}
