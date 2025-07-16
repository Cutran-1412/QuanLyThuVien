using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quanlythuvien.Views.ucFrom.DocGias
{
    public partial class ucDocgiaExtra : UserControl
    {
        private readonly DocGiaController dgctr = new DocGiaController();
        private DocGia docgia;
        public ucDocgiaExtra(DocGia dg,int loai)
        {
            InitializeComponent();
            docgia = dg;
            if (loai == 0)
            {
                gbtnThem.Enabled = false;
                gbtnSua.Enabled = false;
                gtxtma.ReadOnly = true;
                gtxthoten.ReadOnly = true;
                gtxtdiachi.ReadOnly = true;
                gtxtsodienthoai.ReadOnly = true;
                gtxthoten.ReadOnly = true;
                gtxtemail.ReadOnly = true;
                gcbogioitinh.Enabled = false;
                gdatengaydangki.Enabled = false;
                gdatengaysinh.Enabled = false;
            }
            if (loai == 1)
            {
                gbtnThem.Enabled = true;
                gbtnSua.Enabled = false;
                gdatengaydangki.Value = DateTime.Now;
            }
            if (loai == -1)
            {
                gbtnThem.Enabled = false;
                gbtnSua.Enabled = true;
                gtxtma.ReadOnly = true;
            }
        }
        public void Load_Data()
        {
            if (docgia != null)
            {
                gtxtma.Text = docgia.MaDocGia;
                gtxthoten.Text = docgia.HoTen;
                gcbogioitinh.Text = docgia.GioiTinh;
                gdatengaysinh.Value = docgia.NgaySinh;
                gtxtsodienthoai.Text = docgia.SoDienThoai;
                gtxtemail.Text = docgia.Email;
                gtxtdiachi.Text = docgia.DiaChi;
                gdatengaydangki.Value = docgia.NgayDangKy;
            } 
        }
        private void ucDocgiaExtra_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private bool Check_Null()
        {
            if(!new frmMain().Check_Null(gtxtma, "Chưa nhập mã độc giả"))
            {
                return false;
            }
            if (gtxtma.Text.Length < 3 || gtxtma.Text.Length > 10)
            {
                string text = "Mã độc giả phải từ 3 đến 10 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtma.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxthoten, "Chưa nhập họ tên độc giả"))
            {
                return false;
            }
            if (gtxthoten.Text.Length > 50)
            {
                string text = "Họ tên tối đa 50 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxthoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gcbogioitinh.Text))
            {
                string text = "Chưa nhập giới tính độc giả";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gcbogioitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gdatengaysinh.Text))
            {
                string text = "Chưa nhập ngày sinh độc giả";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gdatengaysinh.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtsodienthoai, "Chưa nhập số điện thoại độc giả"))
            {
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(gtxtsodienthoai.Text, @"^\d{9,11}$"))
            {
                string text = "Số điện thoại không hợp lệ. Chỉ chấp nhận 9-11 chữ số";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtsodienthoai.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtemail, "Chưa nhập email"))
            {
                return false;
            }
            if (!new EmailAddressAttribute().IsValid(gtxtemail.Text))
            {
                string text = "Email không hợp lệ";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtemail.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtdiachi, "Chưa nhập địa chỉ"))
            {
                return false;
            }
            return true;
        }
        private void gbtnThem_Click(object sender, EventArgs e)
        {
            if (Check_Null())
            {
                DocGia dg = new DocGia
                {
                    MaDocGia = gtxtma.Text,
                    HoTen = gtxthoten.Text,
                    GioiTinh = gcbogioitinh.Text,
                    NgaySinh = gdatengaysinh.Value.Date,
                    SoDienThoai = gtxtsodienthoai.Text,
                    Email = gtxtemail.Text,
                    DiaChi = gtxtdiachi.Text,
                    NgayDangKy = gdatengaydangki.Value.Date,
                };
                if (dgctr.Get_DocGia_Ma(dg.MaDocGia) == null)
                {
                    dgctr.Insert_DocGia(dg);
                    string text = "Đã thêm thành công độc giả có mã :" + gtxtma.Text;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    if (TopLevelControl is frmMain main)
                    {
                        main.ShowControl(new ucDocgia());
                    }
                }
                else
                {
                    string text = "Đã thêm thất bại độc giả bị trùng mã :" + gtxtma.Text;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                }
            }
        }

        private void gbtnSua_Click(object sender, EventArgs e)
        {
            if (Check_Null())
            {
                DocGia dg = new DocGia
                {
                    MaDocGia = gtxtma.Text,
                    HoTen = gtxthoten.Text,
                    GioiTinh = gcbogioitinh.Text,
                    NgaySinh = gdatengaysinh.Value,
                    SoDienThoai = gtxtsodienthoai.Text,
                    Email = gtxtemail.Text,
                    DiaChi = gtxtdiachi.Text,
                    NgayDangKy = gdatengaydangki.Value,
                };
                if (dgctr.Get_DocGia_Ma(dg.MaDocGia) != null)
                {
                    dgctr.Update_Docgia(dg);
                    string text = "Đã sửa thành công độc giả có mã :" + gtxtma.Text;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    if (TopLevelControl is frmMain main)
                    {
                        main.ShowControl(new ucDocgia());
                    }
                }
            }
            else
            {
                string text = "Sửa thất bại độc giả ";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
            }
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucDocgia());
            }
        }
    }
}
