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

namespace SalaryManager
{
    public partial class MainForm : MaterialForm
    {
        EmployeeManager Emanager = new EmployeeManager();
        

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        /// <summary>
        /// 加载列表数据
        /// </summary>
        private void LoadData()
        {
            List<Employee> Elist = new List<Employee>();
            Elist = Emanager.GetEmployeeInformation();
            List<string[]> Lists = ElTranSl(Elist);
            foreach (string[] item in Lists)
            {
                var Li = new ListViewItem(item);
                materialListView1.Items.Add(Li);
            }
            //throw new NotImplementedException();
        }

        List<string[]> ElTranSl(List<Employee> Elist)
        {
            Type Etype = typeof(Employee);
            Type Ptype = typeof(Position);
            PropertyInfo[] Epros = Etype.GetProperties();
            PropertyInfo[] Ppros = Ptype.GetProperties();
            //Console.WriteLine(Epros.GetLength(0));
            //Console.WriteLine(Ppros.GetLength(0));
            List<string[]> Lists = new List<string[]>();
            string[] ldata = new string[Epros.GetLength(0)-2+Ppros.GetLength(0)-1];
            foreach (Employee item in Elist)
            {
                //Emplopee 第一项最后一项不用
                for(int i=1;i<Epros.GetLength(0)-1;i++)
                {
                    ldata[i - 1] = Etype.GetProperty(Epros[i].Name).GetValue(item).ToString();
                }
                //Position第一项不用
                for (int i = Epros.GetLength(0) - 1; i <= ldata.GetLength(0); i++)
                {
     
                    ldata[i - 1] = Ptype.GetProperty(Ppros[i- Epros.GetLength(0)+2].Name).GetValue(item.position).ToString();
                    //Console.WriteLine((i - 1).ToString() + "      " + ldata[i - 1]);
                }
                //ldata[0] = item.E_id.ToString();
                //ldata[1] = item.Name;
                //ldata[2] = item.Sex;
                //ldata[3] = item.BankAccount.ToString();
                //ldata[4] = item.E_group;
                //ldata[5] = item.E_type;
                //ldata[6] = item.EntryTime;
                //foreach(string it in ldata)
                // Console.WriteLine(it);
                Lists.Add(ldata);
            }
            return Lists;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void rsgl_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click_2(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
