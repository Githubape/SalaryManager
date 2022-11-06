using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 薪水表单数据
    /// </summary>
    class SalaryModel
    {
        /// <summary>
        /// 员工信息
        /// </summary>
        public Employee employee { get; set; }
        /// <summary>
        /// 加班工资
        /// </summary>
        public double OvertimeSalary { get; set; }
        /// <summary>
        /// 补发工资
        /// </summary>
        public double ReisssueSalary { get; set; }
        /// <summary>
        /// 保留工资
        /// </summary>
        public double RetainSalary { get; set; }
        /// <summary>
        /// 绩效考核兑现
        /// </summary>
        public double PerformanceAppraisal { get; set; }
        /// <summary>
        /// 单项奖
        /// </summary>
        public double SingalAward { get; set; }
        /// <summary>
        /// 工龄津贴
        /// </summary>
        public double ServicelenthAllowance { get; set; }
        /// <summary>
        /// 夜班津贴
        /// </summary>
        public double NightshiftAllowance { get; set; }
        /// <summary>
        /// 技术津贴
        /// </summary>
        public double TechnologyAllowance { get; set; }
        /// <summary>
        /// 技能津贴
        /// </summary>
        public double SkillAllowance { get; set; }
        /// <summary>
        /// 生活补助
        /// </summary>
        public double LivingAllowance { get; set; }
        /// <summary>
        /// 通讯补贴                                                        
        /// </summary>
        public double CommunicateAllowance { get; set; }
        /// <summary>
        /// 节日补贴
        /// </summary>
        public double FestivalAllowance { get; set; }
        /// <summary>
        /// 疗养补贴
        /// </summary>
        public double RecuperationAllowance { get; set; }
        /// <summary>
        /// 防暑经文补贴
        /// </summary>
        public double HeatprevenAllowance { get; set; }
        /// <summary>
        /// 合计
        /// </summary>
        public double TotalSalary { get; set; }
    }
}
