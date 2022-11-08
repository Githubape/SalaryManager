using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class UpdateForm : MaterialForm
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void EditPostCencal_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
