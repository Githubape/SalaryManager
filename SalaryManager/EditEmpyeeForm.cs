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
        private Employee Eedit;
        private bool ifinsert=false;
        private EmployeeManager Emanager=new EmployeeManager();
        #endregion


        public EditEmpyeeForm(Employee Emp,bool insert)
        {
            InitializeComponent();
            Dusheng_ComboBox.Items.AddRange(new object[]
            {
                "11",
                "22"
            });
            Dusheng_ComboBox.Text = "11";
            Eedit = Emp;
            ifinsert = insert;
            if(!ifinsert)
                LoadData();
        }
        //加载预览数值
        private void LoadData()
        {
            Type FormType = this.GetType();
            FieldInfo[] Fpros = FormType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            Dictionary<String, object> edic = Emanager.GetProDic(Eedit);
            foreach (FieldInfo item in Fpros)
            {     
                if (item.Name.Split('_').Length==3&&item.Name.Split('_')[0] == "EditEF"&& item.Name.Split('_')[2]=="TextBox")
                {
                    //Console.WriteLine(item.Name);
                    //Console.WriteLine(item.Name.Split('_')[1]);
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

            Type FormType = this.GetType();
            FieldInfo[] Fpros = FormType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            Type Etype = typeof(Employee);
            PropertyInfo[] Epros = Etype.GetProperties();
            Type Ptype = typeof(Position);
            PropertyInfo[] Ppros = Ptype.GetProperties();
            try
            {
                foreach (FieldInfo item in Fpros)
                {

                    if (item.Name.Split('_').Length == 3 && item.Name.Split('_')[0] == "EditEF" && item.Name.Split('_')[2] == "TextBox")
                    {
                        //Console.WriteLine(item.Name);
                        //Console.WriteLine(item.Name.Split('_')[1]);
                        Object obj = item.GetValue(this);
                        MaterialSkin.Controls.MaterialTextBox obj2 = (MaterialSkin.Controls.MaterialTextBox)obj;
                        foreach (PropertyInfo eitem in Epros)
                        {
                            if (eitem.Name == item.Name.Split('_')[1]&&obj2.Text!="")
                            {
                                eitem.SetValue(Eedit, Convert.ChangeType(obj2.Text, eitem.PropertyType));
                            }

                        }
                        foreach (PropertyInfo eitem in Ppros)
                        {
                            if (eitem.Name == item.Name.Split('_')[1] && obj2.Text != "")
                            {
                                eitem.SetValue(Eedit.position, Convert.ChangeType(obj2.Text, eitem.PropertyType));
                            }
                        }
                    }
                }
            }
            catch(System.FormatException)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("输入格式不正确", "OK", true);
                SnackBarMessage.Show(this);
                return;
            }
            Console.WriteLine( Emanager.SetEmployeeInformation(Eedit,ifinsert));
            this.DialogResult = DialogResult.OK;
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
