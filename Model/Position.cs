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
    /// 个人职位信息
    /// </summary>

    public class Position
    {
        public Position()
        {
            data = new Position_Data();
        }
        public Position_Data data;

    }
   
}
