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
using System.Reflection;
using SQLite;

namespace Model
{
    /// <summary>
    /// Emplopee imformation
    /// </summary>
    [Table("employee")]
    public class Employee
    {
        public Employee()
        {
            position = new Position();
            Type Mytype = this.GetType();
            PropertyInfo[] Mypro = Mytype.GetProperties();
            foreach (PropertyInfo item in Mypro)
            {
                if (item.PropertyType.ToString() == "System.String")
                {
                    item.SetValue(this, "");
                }
                else if (item.PropertyType.ToString() == "System.Double" || item.PropertyType.ToString() == "System.Int32")
                {
                    item.SetValue(this, 0);
                }
            }
        }
        /// <summary>
        /// 数据库主键  位置第一个不得更改
        /// </summary>
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Emplopee id
        /// </summary>
        [Column("e_id")]
        public int Eid { get; set; }
        /// <summary>
        /// Employee name
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Column("sex")]
        public string Sex { get; set; }
        /// <summary>
        /// Employee bankaccount
        /// </summary>
        [Column("bank_account")]
        public string BankAccount { get; set; }
        /// <summary>
        /// 员工组
        /// </summary>
        [Column("e_group")]
        public string Egroup { get; set; }
        /// <summary>
        /// 工种
        /// </summary>
        [Column("e_type")]
        public string Etype { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        [Column("entry_time")]
        public string EntryTime { get; set; }

        /// <summary>
        /// 职位  位置最后一个不得更改
        /// </summary>
        [Ignore]
        public Position position { get; set; }
    }
}
