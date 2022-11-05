using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Manager;
using Model;
using System.Reflection;
using Service;
using System.IO;

namespace SalaryManager
{
    public partial class ImportExcelDataForm : MaterialForm
    {

        string fileName;
        DataTable employeeInfo;
        public ImportExcelDataForm()
        {
            InitializeComponent();

        }
        public void GetFileName(string name)
        {
            this.fileName = name;
            employeeInfo = new TEMPEREATE().ExcelToTable(this.fileName);
            List<Dictionary<string, object>> importInfo = new TEMPEREATE().DataTableToList(employeeInfo);
            Console.WriteLine(importInfo);
            Console.WriteLine(employeeInfo.Columns[0]);
        }

        private void importExcelData_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
 }
