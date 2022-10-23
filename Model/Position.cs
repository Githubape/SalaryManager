using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 个人职位信息
    /// </summary>
    public class Position
    {
        /// <summary>
        /// 工种[操作，服务，管理，专业技术]
        /// </summary>
        public string WorkType { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Post { get; set; }
        /// <summary>
        /// 岗序
        /// </summary>
        public string PostOrder { get; set; }
        /// <summary>
        /// 岗级
        /// </summary>
        public string PostLevel { get; set; }
        /// <summary>
        /// 职业资格等级[初级工，中级工，高级工，技师，高级技师]
        /// </summary>
        public string QualificationLevel { get; set; }
        /// <summary>
        /// 入岗时间
        /// </summary>
        public string DutyTime { get; set; }
        /// <summary>
        /// 工龄 手动输入与入职时间无瓜
        /// </summary>
        public int ServiceLength { get; set; }
        /// <summary>
        /// 是否独生子女[是，否]
        /// </summary>
        public string OnlyChild { get; set; }
        /// <summary>
        /// 独生子女费
        /// </summary>
        public string OnlychildAllowance { get; set; }
        /// <summary>
        /// 是否艰苦岗位[一，二，三，四，否]
        /// </summary>
        public string IsHard { get; set; }
        /// <summary>
        /// 艰难岗位津贴
        /// </summary>
        public double HardshipAllowance { get; set; }
        /// <summary>
        /// 是否艰苦边远地区[是，否]                                                       ！！！！！！！！！！！待解决！！！！！！！！！！
        /// </summary>
        public string IsEdge { get; set; }
        /// <summary>
        /// 边远地区津贴
        /// </summary>
        public double EdgeAllowance { get; set; }
        /// <summary>
        /// 餐饮补助
        /// </summary>
        public double MealAllowance { get; set; }
        /// <summary>
        /// 职位基础工资
        /// </summary>
        public double PostWage { get; set; }
        /// <summary>
        /// 职位奖金
        /// </summary>
        public double PostBonus { get; set; }
        /// <summary>
        /// 职位交通费
        /// </summary>
        public double PostTransportation { get; set; }
        /// <summary>
        /// 住房补贴
        /// </summary>
        public string HousingAllowance { get; set; }
        /// <summary>
        /// 取暖补贴
        /// </summary>
        public string HeatingAllowance { get; set; }
    }
}
