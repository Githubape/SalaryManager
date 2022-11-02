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
    public partial class EditEmpyeeForm : MaterialForm
    {
        /// <summary>
        /// 接收员工编号
        /// </summary>
        private string itemID;

        public EditEmpyeeForm()
        {
            InitializeComponent();
        }

        public void GetItemID(string item)
        {
            this.itemID = item;
        }

        private void EditEF_Save_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("员工ID" + itemID);
        }

        private void EditEF_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
