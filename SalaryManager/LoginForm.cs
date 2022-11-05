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
using Service;
using System.IO;
namespace SalaryManager
{
    public partial class LoginForm : MaterialForm
    {
        AdminManager Adminmgr = new AdminManager();
        SqliteHelper sqliteHelper;
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                // 使用了单例模式
                sqliteHelper = SqliteHelper.Instance;
                // 数据库加密
                //sqliteHelper.Init(Path.Combine(Environment.CurrentDirectory, "salary.db"), "123456");
                // 先用未加密的开发
                sqliteHelper.Init(Path.Combine(Environment.CurrentDirectory, "salary.db"));
            }
            catch (SQLite.SQLiteException e)
            {
                LogService.WriteErrorLog(e.Message);
                Console.WriteLine("数据库连接失败");
                throw e;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录点击回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string UserNameIn = this.materialTextBox1.Text.Trim();
            string PasswordIn = this.materialTextBox2.Text.Trim();
            if(UserNameIn.Length==0)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("请输入用户名", "OK", true);
                SnackBarMessage.Show(this);
            }
            if (PasswordIn.Length == 0)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("请输入密码", "OK", true);
                SnackBarMessage.Show(this);
            }

            Admin objIn = new Admin
            {
                UserName = UserNameIn,
                Password=PasswordIn
            };
            Admin obj = null;
            try
            {
                obj=Adminmgr.UserLogin(objIn);
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("请检查数据库连接", "OK", true);
                SnackBarMessage.Show(this);
                return;
            }

            if(obj==null)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("用户名或密码不正确", "OK", true);
                SnackBarMessage.Show(this);
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("登录成功",1500);
                SnackBarMessage.Show(this);
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// 回车登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.materialButton1.PerformClick();
            }
        }
        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
