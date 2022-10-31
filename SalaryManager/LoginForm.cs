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
    public partial class LoginForm : MaterialForm
    {
        AdminManager Adminmgr = new AdminManager();
        public LoginForm()
        {
            InitializeComponent();

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
    }
}
