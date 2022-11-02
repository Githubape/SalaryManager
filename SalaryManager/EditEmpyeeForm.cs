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

using Model;

namespace SalaryManager
{
    public partial class EditEmpyeeForm : MaterialForm
    {

        #region 所需变量
        /// <summary>
        /// 接收员工编号
        /// </summary>
        public Employee Eedit;
        public EmployeeManager Emanager=new EmployeeManager();
        #endregion


        public EditEmpyeeForm(Employee Emp)
        {
            InitializeComponent();
            Dusheng_ComboBox.Items.AddRange(new object[]
            {
                "11",
                "22"
            });
            Dusheng_ComboBox.Text = "11";
            Eedit = Emp;
            LoadData();
        }
        //加载预览数值
        private void LoadData()
        {
            Type FormType = this.GetType();
            FieldInfo[] Fpros = FormType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            //foreach (FieldInfo item in Fpros)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Dictionary<String, object> edic = Emanager.GetProDic(Eedit);
            foreach (FieldInfo item in Fpros)
            {     
                if (item.Name.Split('_').Length==3&&item.Name.Split('_')[0] == "EditEF"&& item.Name.Split('_')[2]=="TextBox")
                {
                    //Console.WriteLine(item.Name);
                    Console.WriteLine(item.Name.Split('_')[1]);
                    Object obj =item.GetValue(this);
                    MaterialSkin.Controls.MaterialTextBox obj2=(MaterialSkin.Controls.MaterialTextBox)obj;
                    obj2.Text =edic[item.Name.Split('_')[1]].ToString();
                }
            }
        }

        //public void GetItemID(string item)
        //{
        //    this.itemID = item;
        //}

        private void EditEF_Save_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("员工ID" + itemID);

        }

        private void EditEF_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEF_HousingAllowance_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemID_TextBox_TextChanged(object sender, EventArgs e)
        {
            
            //string tmp = sender.Text;
            //Console.WriteLine(tmp); 
        }

        private void EditEmpyeeForm_Load(object sender, EventArgs e)
        {

        }

        private void EditEF_BankAccount_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
