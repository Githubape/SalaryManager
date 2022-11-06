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
    /// 管理岗位工资对照
    /// </summary>
    [Table("managerwagexl")]
    public class ManagerWage
    {
        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("one")]
        public int One{ get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("one_brige")]
        public int OneBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("one_mac_brige")]
        public int OneMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("tow")]
        public int Tow { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tow_brige")]
        public int TowBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tow_mac_brige")]
        public int TowMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("three")]
        public int Three { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("three_brige")]
        public int ThreeBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("three_mac_brige")]
        public int ThreeMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("four")]
        public int Four { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("four_brige")]
        public int FourBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("four_mac_brige")]
        public int FourMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("five")]
        public int Five { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("five_brige")]
        public int FiveBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("five_mac_brige")]
        public int FiveMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("six")]
        public int Six { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("six_brige")]
        public int SixBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("six_mac_brige")]
        public int SixMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("seven")]
        public int Seven { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("seven_brige")]
        public int SevenBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("seven_mac_brige")]
        public int SevenMaxBrige { get; set; }

    }


}
