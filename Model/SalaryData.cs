using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SQLite;

namespace Model
{
    [Table("salarydata")]
    public class SalaryData
    {
        public SalaryData()
        {
            Type Mytype = this.GetType();
            PropertyInfo[] Mypro = Mytype.GetProperties();
            foreach (PropertyInfo item in Mypro)
            {
                if (item.PropertyType.ToString() == "System.String")
                {
                    item.SetValue(this, "");
                }
                else if (item.PropertyType.ToString() == "System.Double" || item.PropertyType.ToString() == "System.Int32" )
                {
                    item.SetValue(this, 0);
                }
            }
        }

        public SalaryData(Employee Empin)
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

            Emp = Empin;
            EId = Emp.data.Id;

            #region 一次输入不变
            NohouseAllowance = Emp.position.data.NohouseAllowance;
            HeatingAllowance = Emp.position.data.HeatingAllowance;
            #endregion


            #region 根据期限而定
            OnlychildAllowance = Emp.position.data.OnlychildAllowance;
            EdgeAllowance = Emp.position.data.EdgeAllowance;
            TecAllowance = Emp.position.data.TecAllowance;
            LifeAllowance = Emp.position.data.LifeAllowance;
            AttendDeduction = Emp.position.data.AttendDeduction;
            #endregion

            #region 关联变动

            #endregion
        }

        /// <summary>
        /// 对应人员
        /// </summary>
        [Ignore]
        public Employee Emp { get; set; }


        /// <summary>
        ///主键  位置第一个不得更改
        /// </summary>
        [Column("s_id")]
        [PrimaryKey, AutoIncrement]
        public int SId { get; set; }
        /// <summary>
        /// 外键
        /// </summary>
        [Column("e_id")]
        public int EId { get; set; }

        #region 工资条除了前五项

        #region 一次不变
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

        #region 带截止日期
        /// <summary>
        /// 独生子女费
        /// </summary>
        [Column("only_child_allowance")]
        public double OnlychildAllowance { get; set; }

        /// <summary>
        /// 边远津贴
        /// </summary>
        [Column("edge_allowance")]
        public double EdgeAllowance { get; set; }

        /// <summary>
        /// 技术补贴
        /// </summary>
        [Column("tec_allowance")]
        public double TecAllowance { get; set; }

        /// <summary>
        /// 生活补贴
        /// </summary>
        [Column("life_allowance")]
        public double LifeAllowance { get; set; }

        /// <summary>
        /// 考勤扣款
        /// </summary>
        [Column("attend_deduction")]
        public double AttendDeduction { get; set; }

        #endregion


        #region 关联变动
        /// <summary>
        ///岗位工资
        /// </summary>
        [Column("post_wage")]
        public double PostWage { get; set; }

        /// <summary>
        /// 职位奖金
        /// </summary>
        [Column("post_bonus")]
        public double PostBonus { get; set; }

        /// <summary>
        /// 上岗津贴
        /// </summary>
        [Column("onjob_allowance")]
        public double OnjobAllowance { get; set; }

        /// <summary>
        /// 餐饮补助
        /// </summary>
        [Column("meal_allowance")]
        public double MealAllowance { get; set; }


        /// <summary>
        /// 职位交通费
        /// </summary>
        [Column("post_transportation")]
        public double PostTransportation { get; set; }

        /// <summary>
        /// 通讯补贴
        /// </summary>
        [Column("com_allowance")]
        public double CommuAllowance { get; set; }
        #endregion

        #region 计算

        /// <summary>
        /// 工龄津贴 ：根据工龄计算
        /// </summary>
        [Column("length_allowance")]
        public double LengthAllowance { get; set; }
        #endregion


        #region 输入


        /// <summary>
        /// 夜班津贴：三个档位
        /// </summary>
        [Column("night_allowance")]
        public double NightAllowance { get; set; }


        #endregion

        #region 输入或表格导入

        /// <summary>
        /// 加班工资
        /// </summary>
        [Column("overtime_wage")]
        public double OverTimeWage { get; set; }

        /// <summary>
        /// 补发工资
        /// </summary>
        [Column("reissue")]
        public double Reissue { get; set; }

        /// <summary>
        /// 保留工资
        /// </summary>
        [Column("remain")]
        public double Remain { get; set; }

        /// <summary>
        /// 绩效考核兑现
        /// </summary>
        [Column("performance")]
        public double Performance { get; set; }

        /// <summary>
        /// 单项奖
        /// </summary>
        [Column("single_price")]
        public double SingalPrice { get; set; }

        /// <summary>
        /// 技能津贴
        /// </summary>
        [Column("skill_allowance")]
        public double SkillAllowance { get; set; }

        /// <summary>
        /// 节日补贴
        /// </summary>
        [Column("fest_allowance")]
        public double FestAllowance { get; set; }

        /// <summary>
        /// 疗养补贴
        /// </summary>
        [Column("health_allowance")]
        public double HealthAllowanc { get; set; }



        /// <summary>
        /// 防暑降温补贴
        /// </summary>
        [Column("cold_allowance")]
        public double ClodAllowance { get; set; }

        /// <summary>
        ///应发合计
        /// </summary>
        [Column("shouldtotal")]
        public double ShouldTotal { get; set; }

        /// <summary>
        /// 养老保险
        /// </summary>
        [Column("old_insure")]
        public double OldInsure { get; set; }

        /// <summary>
        /// 失业保险
        /// </summary>
        [Column("unemp_insure")]
        public double UnempInsure { get; set; }

        /// <summary>
        /// 医疗保险
        /// </summary>
        [Column("health_insure")]
        public double HealthInsure { get; set; }

        /// <summary>
        /// 大医疗统筹
        /// </summary>
        [Column("bighealth_insure")]
        public double BighealthInsure { get; set; }

        /// <summary>
        /// 大医疗统筹
        /// </summary>
        [Column("house_fund")]
        public double HouseFund { get; set; }

        /// <summary>
        /// 企业年金
        /// </summary>
        [Column("enter_fund")]
        public double EnterpiceFund { get; set; }

        /// <summary>
        /// 扣税
        /// </summary>
        [Column("tac")]
        public double Tax { get; set; }



        #endregion

        /// <summary>
        /// 实发合计
        /// </summary>
        [Column("true_total")]
        public double TrueTotal { get; set; }
        #endregion


        #region 税务表新增

        /// <summary>
        /// 兑现奖金
        /// </summary>
        [Column("cash_price")]
        public double CashPrice { get; set; }

        /// <summary>
        /// 请假扣款
        /// </summary>
        [Column("leave_duc")]
        public double LeaveDuc { get; set; }

        /// <summary>
        /// 回算差额
        /// </summary>
        [Column("back_dif")]
        public double BackDiff { get; set; }

        /// <summary>
        /// 子女教育
        /// </summary>
        [Column("child_edu")]
        public double ChildEdu { get; set; }

        /// <summary>
        /// 赡养老人
        /// </summary>
        [Column("old_real")]
        public double OldReal { get; set; }

        /// <summary>
        /// 房贷利息
        /// </summary>
        [Column("house_inter")]
        public double HouseInterest { get; set; }

        /// <summary>
        /// 住房租金
        /// </summary>
        [Column("house_rent")]
        public double HouseRent { get; set; }

        /// <summary>
        /// 继续教育
        /// </summary>
        [Column("cont_edu")]
        public double ContiEdu { get; set; }

        /// <summary>
        /// 大病医疗
        /// </summary>
        [Column("big_dease")]
        public double BigDease { get; set; }

        /// <summary>
        /// 应税基数
        /// </summary>
        [Column("bace_tax")]
        public double BaceTax { get; set; }

        #endregion

    }
}
