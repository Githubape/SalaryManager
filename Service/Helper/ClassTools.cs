using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;


namespace Service
{
    /// <summary>
    /// 工具类
    /// </summary>
    public static class ClassTools
    {
        /// <summary>
        /// 获得成员字典
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Dictionary<String,Object> GetProDic(Object obj)
        {
            Dictionary<String, Object> dic = new Dictionary<string, object>();
            Type Otype =obj.GetType();
            PropertyInfo[] Opros= Otype.GetProperties();
            foreach (PropertyInfo item in Opros)
            {
                dic.Add(item.Name,item.GetValue(obj));
            }
            return dic;
        }
    }
}
