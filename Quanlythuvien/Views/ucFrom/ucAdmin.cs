using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Views
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
            dtAdmin.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private AdminController adm = new AdminController();
        public void Load_Data()
        {
            dtAdmin.DataSource = adm.Get_Admin();
            dtAdmin.RowTemplate.Height = 40;
            dtAdmin.ColumnHeadersHeight = 45;

            dtAdmin.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dtAdmin.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            dtAdmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtAdmin.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtAdmin.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dtAdmin.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            dtAdmin.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dtAdmin.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dtAdmin.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtAdmin.Columns[0].Width = 60; 
            dtAdmin.Columns[1].Width = 150;
            dtAdmin.Columns[2].Width = 150;
        }
        private void ucAdmin_Load(object sender, EventArgs e)
        {
            Load_Data();
            gpican.Visible = false;
        }
        public bool Check_Null()
        {
            if (string.IsNullOrEmpty(gtxtUsername.Text))
            {
                string text = "Chưa nhập tài khoản";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtUsername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gtxtPassword.Text))
            {
                string text = "Chưa nhập mật khẩu";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtPassword.Focus();
                return false;
            }
            return true;
        } 
        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (Check_Null())
            {
                Admin ad = new Admin { Username = gtxtUsername.Text, Password = gtxtPassword.Text };
                if (adm.CheckUser(gtxtUsername.Text))
                {
                    adm.Insert_Admin(ad);
                    string text = "Đã thêm thành công tài khoản :" + gtxtUsername.Text;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    Load_Data();
                }
                else
                {
                    string text = "Tài khoản bị trùng";
                    string caption = "Cảnh báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Warning;
                    new frmMain().Msgbox(text, caption, button, icon);
                    gtxtPassword.Focus();
                }
            }
        }

        private void gbtnSua_Click(object sender, EventArgs e)
        {
            if (dtAdmin.SelectedRows.Count > 0)
            {
                if (Check_Null())
                {
                    int id = Convert.ToInt32(dtAdmin.SelectedRows[0].Cells[0].Value.ToString());
                    Admin ad = new Admin { Id = id, Username = gtxtUsername.Text, Password = gtxtPassword.Text };
                    adm.Update_Admin(ad);
                    string text = "Sửa thành công tài khoản có ID :" + id;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    Load_Data();
                }
            }
            else
            {
                string text = "Sửa thất bại !";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
            }
        }

        private void dtAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtAdmin.SelectedRows[0];
                gtxtId.Text = row.Cells[0].Value.ToString();
                gtxtUsername.Text = row.Cells[1].Value.ToString();
                gtxtPassword.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dtAdmin_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtAdmin.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                string password = e.Value.ToString();
                e.Value = new string('●', password.Length);
                e.FormattingApplied = true;
            }
        }

        private void gbtnXoa_Click(object sender, EventArgs e)
        {
            if (dtAdmin.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtAdmin.SelectedRows[0].Cells[0].Value.ToString());
                string text1 = "Bạn chắc chắn muốn xóa mã " + id;
                string caption1 = "Xác nhận";
                MessageDialogButtons button1 = MessageDialogButtons.OKCancel;
                MessageDialogIcon icon1 = MessageDialogIcon.Question;
                if (new frmMain().Msgbox(text1, caption1, button1, icon1) == DialogResult.Yes)
                {
                    adm.Delete_Admin(id);
                    string text = "Xóa thành công tài khoản có ID :" + id;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    Load_Data();
                }
            }
            else
            {
                string text = "Xóa thất bại !";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
            }
        }

        private void gtxtSearch_TextChanged(object sender, EventArgs e)
        {
            dtAdmin.DataSource = adm.Search_Admin(gtxtSearch.Text);
        }

        private void gpichien_Click(object sender, EventArgs e)
        {
            gpichien.Visible = false;
            gtxtPassword.UseSystemPasswordChar = false;
            gpican.Visible = true;
        }

        private void gpican_Click(object sender, EventArgs e)
        {
            gpican.Visible  = false;
            gtxtPassword.UseSystemPasswordChar = true;
            gpichien.Visible = true;
        }
    }
}
