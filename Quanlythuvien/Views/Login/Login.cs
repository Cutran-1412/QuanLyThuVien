using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Controllers.Login;

namespace Quanlythuvien.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cboanhien_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = txtpass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            QuanLyLogin kn = new QuanLyLogin();
            kn.Login(txtuser,txtpass);
        }
    }
}
