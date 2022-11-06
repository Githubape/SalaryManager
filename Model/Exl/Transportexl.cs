using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Model
{
    /// <summary>
    /// 交通费用对照表
    /// </summary>
    [Table("transportexl")]
    public class Transportexl
    {
        [Column("one")]
        public int One { get; set; }
        [Column("tow")]
        public int Tow { get; set; }
        [Column("three")]
        public int Three { get; set; }
    }
}
