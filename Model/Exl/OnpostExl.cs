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
    /// 艰苦岗位津贴对照
    /// </summary>
    [Table("onpostexl")]
    public class OnpostExl
    {
        /// <summary>
        /// 档次一标准
        /// </summary>
        [Column("one")]
        public int One { get; set; }

        [Column("two")]
        public int Two { get; set; }

        [Column("three")]
        public int Three { get; set; }

        [Column("four")]
        public int Four { get; set; }
    }
}
