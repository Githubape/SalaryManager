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
            string[] ldata = new string[7];
            foreach (Employee item in Elist)
            {
                ldata[0] = item.E_id.ToString();
                ldata[1] = item.Name;
                ldata[2] = item.Sex;
                ldata[3] = item.BankAccount.ToString();
                ldata[4] = item.E_group;
                ldata[5] = item.E_type;
                ldata[6] = item.EntryTime;
                var Li= new ListViewItem(ldata);
                materialListView1.Items.Add(Li);
            }
            //throw new NotImplementedException();
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
    }
}
