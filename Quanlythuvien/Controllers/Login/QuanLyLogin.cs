using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers.Login
{
    public class QuanLyLogin
    {
        public bool Check_Null(TextBox txtuser,TextBox txtpass)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản !");
                txtuser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản !");
                txtpass.Focus();
                return false;
            }
            return true;
        }
        public void Login(TextBox txtuser, TextBox txtpass)
        { 

        }
    }
}
