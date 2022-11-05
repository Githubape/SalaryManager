using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PositionData
    {
        public PositionData()
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
    }
}
