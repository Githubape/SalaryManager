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
        public ImportExcelDataForm()
        {
            InitializeComponent();

        }
        public void GetFileName(string name)
        {
            this.fileName = name;
            List<Dictionary<string, object>> employeeInfo = new FileHelper().GetExcelDataToList(this.fileName,ExclHead.Salaryexl);
            foreach(Dictionary<string,object> item in employeeInfo)
            {
                foreach(var idtem in item)
                {
                    Console.WriteLine($"key={idtem.Key},value={idtem.Value}");
                }
            }
            Console.WriteLine(employeeInfo);
        }

        private void importExcelData_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
 }
