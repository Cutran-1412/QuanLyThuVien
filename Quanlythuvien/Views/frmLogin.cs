using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Models.Admins;
using Quanlythuvien.Controllers;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using FontAwesome.Sharp;

namespace Quanlythuvien.Views
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            gtxtUsername.TabStop = false;
            gtxtPassword.TabStop = false;
            gbtndangnhap.TabStop = false;
            gbtnthoat.TabStop = false;
            gpican.Visible = false;
            gtxtPassword.UseSystemPasswordChar = true;
        }
        private void lbllammoi_Click(object sender, EventArgs e)
        {
            gtxtUsername.Text = "";
            gtxtPassword.Text = "";
            gtxtUsername.TabStop = false;
            gtxtPassword.TabStop = false;
            gbtndangnhap.TabStop = false;
            gbtnthoat.TabStop = false;
            gpican.Visible = false;
            gpichien.Visible = true;
            gtxtPassword.UseSystemPasswordChar = true;
        }
        private DialogResult Msgbox(string text, string caption, MessageDialogButtons buttons, MessageDialogIcon icon)
        {
            var msg = new Guna2MessageDialog
            {
                Text = text,
                Caption = caption,
                Buttons = buttons,
                Icon = icon,
                Style = MessageDialogStyle.Light,
                Parent = this
            };
            return msg.Show();
        }
        public bool Check_Null()
        {
            if (string.IsNullOrEmpty(gtxtUsername.Text))
            {
                string text = "Chưa nhập tài khoản";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                Msgbox(text, caption, button, icon);
                gtxtUsername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gtxtPassword.Text))
            {
                string text = "Chưa nhập mật khẩu";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                Msgbox(text, caption, button, icon);
                gtxtPassword.Focus();
                return false;
            }
            return true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void gpichien_Click(object sender, EventArgs e)
        {
            gtxtPassword.UseSystemPasswordChar = false;
            gpican.Visible = true;
            gpichien.Visible = false;
        }

        private void gpican_Click(object sender, EventArgs e)
        {
            gtxtPassword.UseSystemPasswordChar = true;
            gpichien.Visible = true;
            gpican.Visible = false;
        }


        private void gbtndangnhap_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin { Username = gtxtUsername.Text, Password = gtxtPassword.Text };
            if (Check_Null())
            {
                if (gtxtUsername.Text == "Administrator" && gtxtPassword.Text == "2004")
                {
                    string text = "Đăng nhập thành công với quyền Administrator !";
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    Msgbox(text, caption, button, icon);
                    this.Visible = false;
                    frmMain from = new frmMain();
                    from.check = true;
                    from.Visible = true;
                }
                else if (new AdminController().Check_TaiKhoan_Admin(ad))
                {
                    string text = "Đăng nhập thành công với quyền Admin !";
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    Msgbox(text, caption, button, icon);
                    this.Visible = false;
                    frmMain from = new frmMain();
                    from.check = false;
                    from.Visible = true;
                }
                else
                {
                    string text = "Đăng nhập thất bại !";
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Error;
                    Msgbox(text, caption, button, icon);
                }
            }
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            string text = "Bạn chắc chắn muốn thoát chương trình?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
