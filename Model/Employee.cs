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
        /// 数据库主键  位置第一个不得更改
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Emplopee id
        /// </summary>
        public int Eid { get; set; }
        /// <summary>
        /// Employee name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Employee bankaccount
        /// </summary>
        public int BankAccount { get; set; }
        /// <summary>
        /// 员工组
        /// </summary>
        public string Egroup { get; set; }
        /// <summary>
        /// 工种
        /// </summary>
        public string Etype { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public string EntryTime { get; set; }
        /// <summary>
        /// 职位  位置最后一个不得更改
        /// </summary>
        public Position position { get; set; }
    }
}
