using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data.SqlClient;
using Service;
using MySql.Data.MySqlClient;

// using NPOI Excel、Word读写
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Manager
{
    /// <summary>
    /// 测试模块
    /// </summary>
    public class TEMPEREATE
    {

        private SqlService Sservice = new SqlService();
        /// <summary>
        /// LogService 测试
        /// </summary>
        /// <param name="msg"></param>
        public static void Logtest(string msg)
        {
            LogService.WriteErrorLog(msg);
        }

        public void Sqltest()
        {
            string sql = "SELECT Id,Password,UserName FROM salary.users";
            MySqlDataReader objReader = Sservice.GetReader(sql);
            while(objReader.Read())
            {
                Console.WriteLine(objReader["UserName"].ToString());
                Console.WriteLine(objReader["Password"].ToString());
                Console.WriteLine(Convert.ToInt32(objReader["Id"]));
            }
        }

        public void Sqlupdatetest()
        {
            MySqlParameter[] eparam = new MySqlParameter[]
            {
                 new MySqlParameter("@Id","0"),
                new MySqlParameter("@Sex","不会吧"),
                new MySqlParameter("@BankAccount","34d4")
               
            };

            //string sql= "update salary.employee set Sex=@Sex, BankAccount = @BankAccount where Id =@Id";
            //string sql = "insert into salary.employee (employee.Eid,Name,employee.Sex,employee.BankAccount,employee.Egroup,employee.EntryTime ) values(46,0,0,0,0,0);";
            string sql = "insert into salary.employee() values()";
         
            Console.WriteLine( Sservice.InsertNl(sql,null));
        }

        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell">目标单元格</param>
        /// <returns></returns>
        private object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank:
                    return null;
                case CellType.Boolean:
                    return cell.BooleanCellValue;
                case CellType.Numeric:
                    return cell.NumericCellValue;
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Error:
                    return cell.ErrorCellValue;
                case CellType.Formula:
                default:
                    return "=" + cell.CellFormula;
            }
        }

        /// <summary>
        /// Excel导入成DataTble
        /// </summary>
        /// <param name="file">导入路径(包含文件名与扩展名)</param>
        /// <param name="i">传入表头行数</param>
        /// <returns></returns>
        public DataTable ExcelToTable(string file)
        {
            
            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                if (fileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook(fs); }
                else if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook(fs); } else
                {
                    workbook = null;
                }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(0);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0 ; i < header.LastCellNum; i++)
                {
                    object obj = GetValueType(header.GetCell(i));
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(i);
                }
                //数据  
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        ///<summary>
        ///DataTable转List
        /// </summary>
        public List<Dictionary<string, object>> DataTableToList(DataTable dt)
        {

            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in dt.Rows)//每一行信息，新建一个Dictionary<string,object>,将该行的每列信息加入到字典
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(dc.ColumnName, dr[dc].ToString());
                }
                list.Add(result);
            }
            return list;
        }

        ///<summary>
        ///打开资源管理器并获取文件名称及路径
        /// </summary>
        public string OpenFile()
        {
            //打开文件
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (file.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            var path = file.FileName;
            return path;
        }

        ///<summary>
        ///文件读取测试
        /// </summary>
        public void GetDataTest()
        {
            string fileName = "D:\\Pengzhen\\salartManagerbiao\\salary.xls";
            DataTable mydata = new TEMPEREATE().ExcelToTable(fileName);
            foreach (DataRow dt in mydata.Rows)
            {
                for (int i = 0; i < dt.ItemArray.Length; i++)
                {
                    Console.WriteLine(dt[i]);
                }
                Console.WriteLine(dt[0]);
            }
            Console.WriteLine(mydata.Rows);
        }
    }
}
