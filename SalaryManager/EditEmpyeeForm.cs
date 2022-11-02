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

        #region 所需变量
        /// <summary>
        /// 接收员工编号
        /// </summary>
        private string itemID;
        private string EditEF_Eid;
        private string EditEF_Name;
        private string EditEF_Sex;
        private string EditEF_BankAccount;
        private string EditEF_Egroup;
        private string EditEF_Etype;
        private string EditEF_EntryTime;
        private string EditEF_WorkType;
        private string EditEF_Post;
        private string EditEF_PostOrder;
        private string EditEF_PostLevel;
        private string EditEF_QualificationLevel;
        private string EditEF_DutyTime;
        private string EditEF_ServiceLength;
        private string EditEF_OnlyChild;
        private string EditEF_OnlychildAllowance;
        private string EditEF_IsHard;
        private string EditEF_HardshipAllowance;
        private string EditEF_IsEdge;
        private string EditEF_EdgeAllowance;
        private string EditEF_MealAllowance;
        private string EditEF_PostWage;
        private string EditEF_PostBomus;
        private string EditEF_PostTransportation;
        private string EditEF_HousingAllowance;
        private string EditEF_HeatingAllowance;

        #endregion


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
