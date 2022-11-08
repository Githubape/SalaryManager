using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SQLite;
namespace Model
{
    [Table("position")]
    public class Position_Data
    {
        public Position_Data()
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
        ///主键  位置第一个不得更改
        /// </summary>
        [Column("p_id")][PrimaryKey,AutoIncrement]
        public int PId { get; set; }
        /// <summary>
        /// 外键
        /// </summary>
        [Column("e_id")]
        public int EId { get; set; }

        #region 基础职位信息
        /// <summary>
        /// 工种
        /// </summary>
        [Column("work_type")]
        public string WorkType { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [Column("department")]
        public string Department { get; set; }
        /// <summary>
        /// 序列
        /// </summary>
        [Column("Squence")]
        public string Squence { get; set; }      
        /// <summary>
        /// 岗序
        /// </summary>
        [Column("post_order")]
        public string PostOrder { get; set; }
        /// <summary>
        /// 岗级
        /// </summary>
        [Column("post_level")]
        public string PostLevel { get; set; }
        /// <summary>
        /// 职业资格等级[初级工，中级工，高级工，技师，高级技师]
        /// </summary>
        [Column("qualification_level")]
        public string QualificationLevel { get; set; }
        /// <summary>
        /// 入岗时间
        /// </summary>
        [Column("duty_time")]
        public string DutyTime { get; set; }

        /// <summary>
        /// 工龄 手动输入与入职时间无瓜:根据日期计算
        /// </summary>
        [Column("service_length")]
        public int ServiceLength { get; set; }
        #endregion

        #region 带截止日期工资信息
        /// <summary>
        /// 独生子女费
        /// </summary>
        [Column("only_child_allowance")]
        public double OnlychildAllowance { get; set; }
        /// <summary>
        /// 独生子女截止日期
        /// </summary>
        [Column("oc_expiration")]
        public DateTime OcaExpiration { get; set; }

        /// <summary>
        /// 边远津贴
        /// </summary>
        [Column("edge_allowance")]
        public double EdgeAllowance { get; set; }
        /// <summary>
        /// 边远津贴截止日期
        /// </summary>
        [Column("eda_expiration")]
        public DateTime EdaExpiration { get; set; }

        /// <summary>
        /// 技术补贴
        /// </summary>
        [Column("tec_allowance")]
        public double TecAllowance { get; set; }
        /// <summary>
        /// 技术津贴截止日期
        /// </summary>
        [Column("tec_expiration")]
        public DateTime TecExpiration { get; set; }

        /// <summary>
        /// 生活补贴
        /// </summary>
        [Column("life_allowance")]
        public double LifeAllowance { get; set; }
        /// <summary>
        /// 生活津贴截止日期
        /// </summary>
        [Column("life_expiration")]
        public DateTime LifeExpiration { get; set; }
        
        /// <summary>
        /// 考勤扣款
        /// </summary>
        [Column("attend_deduction")]
        public double AttendDeduction { get; set; }
        /// <summary>
        /// 考勤扣款截止日期
        /// </summary>
        [Column("attendduc_expiration")]
        public DateTime AttendDucExpiration { get; set; }


        #endregion

        #region 一次输入不变

        /// <summary>
        /// 无住房补贴
        /// </summary>
        [Column("nohouse_allowance")]
        public double NohouseAllowance { get; set; }

        /// <summary>
        /// 取暖补贴
        /// </summary>
        [Column("heating_allowance")]
        public double HeatingAllowance { get; set; }

        #endregion
        /// <summary>
        /// 抛弃
        /// </summary>
        [Column("abolish")]
        public int Abolish { get; set; }
    }
}
