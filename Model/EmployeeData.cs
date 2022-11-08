using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SQLite;
namespace Model
{
    [Table("employee")]
    public class Employee_Data
    {
   
        public Employee_Data()
        {
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
        [Column("id")][PrimaryKey,AutoIncrement]
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
        /// 企业特定员工分类
        /// </summary>
        [Column("classfy")]
        public string Classfy { get; set; }

        #region 税务表内容
        /// <summary>
        /// 身份证号
        /// </summary>
        [Column("id_cardnum")]
        public string IdcardNum { get; set; }

        /// <summary>
        /// 所属二级单位
        /// </summary>
        [Column("second_company")]
        public string SecondCompany { get; set; }

        /// <summary>
        /// 组织单元文本
        /// </summary>
        [Column("org_text")]
        public string OrganizeText { get; set; }

        /// <summary>
        /// 工资范围编码
        /// </summary>
        [Column("wage_scope")]
        public string WageScope { get; set; }
        #endregion
    }

}
