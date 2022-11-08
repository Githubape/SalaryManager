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
    public partial class MainForm : MaterialForm
    {
        EmployeeManager Emanager = new EmployeeManager();
        List<Employee> Elist;// = new List<Employee>();
        /// <summary>
        /// 定义变量是拿到员工编号
        /// </summary>
        /// ItemID 是拿到员工编号
        string ItemID;

        SqliteHelper sqliteHelper;


        public MainForm()
        {
            try
            {
                // 使用了单例模式
                sqliteHelper = SqliteHelper.Instance;
                // 数据库加密
                //sqliteHelper.Init(Path.Combine(Environment.CurrentDirectory, "salary.db"), "123456");
                // 先用未加密的开发
                sqliteHelper.Init(Path.Combine(Environment.CurrentDirectory, "salary.db"));
            }
            catch(SQLite.SQLiteException e)
            {
                LogService.WriteErrorLog(e.Message);
                Console.WriteLine("数据库连接失败");
                throw e;
            }
            InitializeComponent();
            //List<Employee> Elist = new List<Employee>();
            Elist = Emanager.GetEmployeeInformation();
            LoadData("List1Header", Elist);
           
        }
        /// <summary>
        /// 加载列表数据
        /// </summary>
        private void LoadData(String list, List<Employee> Elist)
        {
            materialListView1.Items.Clear();
            //List<string[]> Lists = ElTranSl(Elist);
            Type FormType = typeof(MainForm);
            //PropertyInfo[] Fpros = FormType.GetProperties();
            FieldInfo[] Fpros = FormType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            //foreach (FieldInfo item in Ffiel)
            //{
            //    Console.WriteLine(item.Name);
            //}
            List<String> Fprolst = new List<String>();
            foreach (FieldInfo item in Fpros)
            {
                if (item.Name.Split('_')[0] == list)
                {
                    Fprolst.Add(item.Name.Split('_')[1]);
                }
            }
            foreach (Employee Emp in Elist)
            {
                Dictionary<String, object> edic = Emanager.GetProDic(Emp);
                string[] ldata = new string[Fprolst.ToArray().Length];
                for (int i = 0; i < ldata.Length; i++)
                {
                    //Console.WriteLine(Fprolst[i]);
                    ldata[i] = edic[Fprolst[i]].ToString();
                }
                var Li = new ListViewItem(ldata);
                materialListView1.Items.Add(Li);
            }

            //foreach (string[] item in Lists)
            //{
            //    var Li = new ListViewItem(item);
            //    materialListView1.Items.Add(Li);    
            //}

            //throw new NotImplementedException();
        }
        /// <summary>
        /// Elist -》List string 已弃用
        /// </summary>
        /// <param name="Elist"></param>
        /// <returns></returns>
        List<string[]> ElTranSl(List<Employee> Elist)
        {
            Type Etype = typeof(Employee);
            Type Ptype = typeof(Position);
            PropertyInfo[] Epros = Etype.GetProperties();
            PropertyInfo[] Ppros = Ptype.GetProperties();
            //Console.WriteLine(Epros.GetLength(0));
            //Console.WriteLine(Ppros.GetLength(0));
            List<string[]> Lists = new List<string[]>();

            foreach (Employee item in Elist)
            {
                string[] ldata = new string[Epros.GetLength(0) - 2 + Ppros.GetLength(0) - 1];
                //Emplopee 第一项最后一项不用
                for (int i = 1; i < Epros.GetLength(0) - 1; i++)
                {
                    ldata[i - 1] = Etype.GetProperty(Epros[i].Name).GetValue(item).ToString();
                }
                //Position第一项不用
                for (int i = Epros.GetLength(0) - 1; i <= ldata.GetLength(0); i++)
                {

                    ldata[i - 1] = Ptype.GetProperty(Ppros[i - Epros.GetLength(0) + 2].Name).GetValue(item.position).ToString();
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



        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(sender);
            //Console.WriteLine(e);
            //Console.WriteLine(materialListView1.SelectedItems[0].SubItems[0].Text);

            ListView list = sender as ListView;
            if (list.SelectedItems.Count > 0)
            {
                ItemID = list.SelectedItems[0].SubItems[0].Text;
                Console.WriteLine("当前员工编号" + ItemID);

            }
        }
        /// <summary>
        /// 
        /// 添加按钮回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButton1_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("创建" + ItemID + "的编辑界面");
            EditEmpyeeForm editEmFrom = new EditEmpyeeForm(new Employee(), true);
            //editEmFrom.GetItemID(ItemID);

            if (DialogResult.OK == editEmFrom.ShowDialog())
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("保存成功", "OK", true);
                SnackBarMessage.Show(this);

                Elist = Emanager.GetEmployeeInformation();
                LoadData("List1Header", Elist);
            }

        }
        /// <summary>
        /// 编辑按钮回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (ItemID != null)
            {
                //Console.WriteLine("创建" + ItemID + "的编辑界面");
                EditEmpyeeForm editEmFrom = new EditEmpyeeForm(GetEmpFromList(ItemID), false);
                //editEmFrom.GetItemID(ItemID);

                if (DialogResult.OK == editEmFrom.ShowDialog())
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("保存成功", "OK", true);
                    SnackBarMessage.Show(this);
                    LoadData("List1Header", Elist);
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("请选择一名员工", "OK", true);
                SnackBarMessage.Show(this);
            }
        }
        private Employee GetEmpFromList(string Eid)
        {
            foreach (Employee item in Elist)
            {
                if (item.data.Eid.ToString() == Eid)
                    return item;
            }
            return null;
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
