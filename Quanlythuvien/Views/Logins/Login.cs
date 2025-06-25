using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Controllers;

namespace Quanlythuvien.Views.Logins
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cboanhien_CheckedChanged(object sender, EventArgs e)
        {
            new LoginManagement().An_Hien(txtpass);
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            new LoginManagement().Login(txtuser, txtpass);
        }
    }
}
