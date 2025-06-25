using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Models.Login;
using Quanlythuvien.Models.Logins;
using Quanlythuvien.Views.Login;
using Quanlythuvien.Views.Logins;

namespace Quanlythuvien.Controllers
{
    public class LoginManagement
    {
        public void An_Hien(TextBox txtpass)
        {
            txtpass.PasswordChar = txtpass.PasswordChar == '*' ? '\0' : '*';
        }
        public bool Check_Null(TextBox txtuser, TextBox txtpass)
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
        public void Load_Admin(DataGridView dt)
        {
            LoginDAO lgd = new LoginDAO();
            dt.AutoGenerateColumns = false;
            dt.Columns.Clear();
            dt.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "Số thứ tự"
            });
            dt.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "username",
                HeaderText = "Tài khoản"
            });
            dt.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "password",
                HeaderText = "Mật khẩu",
                Name = "password"
            });
            dt.DataSource = lgd.Get_Admin();
        }
        private bool Check_Admin(TextBox txtuser, TextBox txtpass)
        {
            List<Admin> list = new LoginDAO().Get_Admin();
            foreach (Admin item in list)
            {
                if (item.username == txtuser.Text && item.password == txtpass.Text) 
                {
                    return true;
                }
            }
            return false;
        }
        public void Login(TextBox txtuser, TextBox txtpass)
        {
            if (Check_Null(txtuser, txtpass))
            {
                if (txtuser.Text == "administrator" && txtpass.Text == "2004")
                {
                    Adminshow form = new Adminshow();
                    form.Show();
                }
                else if (Check_Admin(txtuser,txtpass))
                {
                    MessageBox.Show("Đăng nhập thành công !");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai !");
                    txtuser.Focus();
                }
            }
        }
        public void Insert_Admin(TextBox txtuser, TextBox txtpass)
        {
            if (Check_Null(txtuser, txtpass))
            {
                Admin admin = new Admin
                {
                    username = txtuser.Text,
                    password = txtpass.Text,
                };
                MessageBox.Show("Thêm thành công tài khoản " + txtuser.Text + " !");
                new LoginDAO().Insert(admin);
            }
        }
        public void Show_Details(TextBox txtma, TextBox txtuser, TextBox txtpass,DataGridView data)
        {
            if (data.SelectedRows.Count > 0)
            {
                DataGridViewRow row = data.SelectedRows[0];
                txtma.Text = row.Cells[0].Value.ToString();
                txtuser.Text = row.Cells[1].Value.ToString();
                txtpass.Text = row.Cells[2].Value.ToString();
            }
        }
        public void Update(TextBox txtuser, TextBox txtpass , DataGridView data)
        {
            if (data.SelectedRows.Count > 0)
            {
                int ma = Convert.ToInt32(data.SelectedRows[0].Cells[0].Value.ToString());
                if (Check_Null(txtuser,txtpass))
                {
                    new LoginDAO().Update(ma, txtuser, txtpass);
                    MessageBox.Show("Sửa thành công "+ma+" !"); 
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }
        public void Delete(DataGridView data)
        {
            if (data.SelectedRows.Count > 0)
            {
                int ma = Convert.ToInt32(data.SelectedRows[0].Cells[0].Value.ToString());
                new LoginDAO().Delete(ma);
                MessageBox.Show("Xóa thành công "+ma+"!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
