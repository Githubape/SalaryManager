using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Model
{
    /// <summary>
    /// 误餐参考表
    /// </summary>
    [Table("mealexl")]
    public class Mealexl
    {
        /// <summary>
        /// 一档_高级
        /// </summary>
        [Column("one_up")]
        public int One_Up { get; set; }
        [Column("one_down")]
        public int One_Down { get; set; }
        [Column("tow_up")]
        public int Tow_Up { get; set; }
        [Column("tow_down")]
        public int Tow_Down { get; set; }
        [Column("three_up")]
        public int Three_Up { get; set; }
        [Column("three_down")]
        public int Three_Down { get; set; }
    }
}
