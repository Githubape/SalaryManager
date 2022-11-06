using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Model
{
    /// <summary>
    /// 奖金对照表
    /// </summary>
    [Table("pricexl")]
    public class Pricexl
    {
        #region 岗位序列一
        /// <summary>
        /// 序列一 级别一
        /// </summary>
        [Column("fone")]
        public int FOne { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("fone_brige")]
        public int FOneBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("fone_mac_brige")]
        public int FOneMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("ftow")]
        public int FTow { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("ftow_brige")]
        public int FTowBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("ftow_mac_brige")]
        public int FTowMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("fthree")]
        public int FThree { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("fthree_brige")]
        public int FThreeBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("fthree_mac_brige")]
        public int FThreeMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("ffour")]
        public int FFour { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("ffour_brige")]
        public int FFourBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("ffour_mac_brige")]
        public int FFourMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("ffive")]
        public int FFive { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("ffive_brige")]
        public int FFiveBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("ffive_mac_brige")]
        public int FFiveMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("fsix")]
        public int FSix { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("fsix_brige")]
        public int FSixBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("fsix_mac_brige")]
        public int FSixMaxBrige { get; set; }
        #endregion

        #region 岗位序列二
        /// <summary>
        /// 序列一 级别一
        /// </summary>
        [Column("sone")]
        public int SOne { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("sone_brige")]
        public int SOneBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("sone_mac_brige")]
        public int SOneMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("stow")]
        public int STow { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("stow_brige")]
        public int STowBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("stow_mac_brige")]
        public int STowMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("sthree")]
        public int SThree { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("sthree_brige")]
        public int SThreeBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("sthree_mac_brige")]
        public int SThreeMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("sfour")]
        public int SFour { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("sfour_brige")]
        public int SFourBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("sfour_mac_brige")]
        public int SFourMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("sfive")]
        public int SFive { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("sfive_brige")]
        public int SFiveBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("sfive_mac_brige")]
        public int SFiveMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("ssix")]
        public int SSix { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("ssix_brige")]
        public int SSixBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("ssix_mac_brige")]
        public int SSixMaxBrige { get; set; }
        #endregion


        #region 岗位序列三
        /// <summary>
        /// 序列一 级别一
        /// </summary>
        [Column("tone")]
        public int TOne { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tone_brige")]
        public int TOneBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tone_mac_brige")]
        public int TOneMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("ttow")]
        public int TTow { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("ttow_brige")]
        public int TTowBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("ttow_mac_brige")]
        public int TTowMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("tthree")]
        public int TThree { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tthree_brige")]
        public int TThreeBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tthree_mac_brige")]
        public int TThreeMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("tfour")]
        public int TFour { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tfour_brige")]
        public int TFourBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tfour_mac_brige")]
        public int TFourMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("tfive")]
        public int TFive { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tfive_brige")]
        public int TFiveBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tfive_mac_brige")]
        public int TFiveMaxBrige { get; set; }

        /// <summary>
        /// 岗级一
        /// </summary>
        [Column("tsix")]
        public int TSix { get; set; }
        /// <summary>
        /// 岗级一档差
        /// </summary>
        [Column("tsix_brige")]
        public int TSixBrige { get; set; }
        /// <summary>
        /// 岗级一高岗序
        /// </summary>
        [Column("tsix_mac_brige")]
        public int TSixMaxBrige { get; set; }
        #endregion
    }
}
