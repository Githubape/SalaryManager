using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using NPOI Excel、Word读写
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Service
{
    public class FileHelper
    {
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
        private DataTable ExcelToTable(string file)
        {

            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                if (fileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook(fs);
                }
                else if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook(fs);
                }
                else
                {
                    workbook = null;
                }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(0);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0; i < header.LastCellNum; i++)
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

        /// <summary>
        /// 匹配字典函数
        /// </summary>
        /// <param name="columnName">原字典名</param>
        /// <param name="excelToList">字典</param>
        /// <returns></returns>
        private string MatchColumnName(string columnName, Dictionary<string, string> excelToList)
        {
            string tmpName;
            if (excelToList.ContainsKey(columnName))
            {
                tmpName = excelToList[columnName];
            }
            else
            {
                tmpName = columnName;
            }
            return tmpName;
        }

        /// <summary>
        /// 获取Excel中的值并转换成List
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="excelToList">匹配字典</param>
        /// <returns></returns>
        public List<Dictionary<string, object>> GetExcelDataToList(string fileName,Dictionary<string,string> excelToList)
        {
            DataTable dt = ExcelToTable(fileName);
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in dt.Rows)//每一行信息，新建一个Dictionary<string,object>,将该行的每列信息加入到字典
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(MatchColumnName(dc.ColumnName,excelToList), dr[dc].ToString());
                }
                list.Add(result);
            }
            return list;
        }
    }
}
