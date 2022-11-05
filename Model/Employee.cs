/***********************************
* 描 述：
* 作 者：
* 版 本：1.0
* 创建时间：20221021
* 
* ****************************
* 命名空间：Model
* 类名：Employee
* 
* 
*/
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
    /// Emplopee imformation
    /// </summary>
   
    public class Employee
    {
        public Employee()
        {
            position = new Position();
            Type Mytype = this.GetType();
            data = new Employee_Data();
        }
        public Employee(Employee_Data edata,Position_Data pdata)
        {
            position = new Position(pdata);
            Type Mytype = this.GetType();
            data = edata;
        }
        public Employee_Data data;
        /// <summary>
        /// 职位  位置最后一个不得更改
        /// </summary>
        public Position position { get; set; }

    }

   
}
