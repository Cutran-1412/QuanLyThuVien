using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views.ucFrom.Sachs
{
    public partial class ucSachExtra : UserControl
    {
        private SachController sachCtrl = new SachController();
        private Sach sach;
        public ucSachExtra(Sach sach, int loai)
        {
            InitializeComponent();
            this.sach = sach;
            if (loai == 0)
            {
                gbtnthem.Enabled = false;
                gbtnsua.Enabled = false;
                gtxtma.ReadOnly = true;
                gtxtTenSach.ReadOnly = true;
                gtxtTacgia.ReadOnly = true;
                gdtpNgaynhap.Enabled = false;
                gtxtNhaxb.Enabled = true;
                gtxtTheloai.ReadOnly = true;
                gtxtDongia.ReadOnly = true;
                gtxtSoluong.ReadOnly = true;
                gtxtNamphathanh.ReadOnly = true;
            }
            if (loai == 1)
            {
                gbtnthem.Enabled = true;
                gbtnsua.Enabled = false;
            }
            if (loai == -1)
            {
                gbtnthem.Enabled = false;
                gbtnsua.Enabled = true;
                gtxtma.ReadOnly = true;
            }


        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (IsFilledAll())
            {
                if (this.sachCtrl.FindByKey(this.gtxtma.Text) != null)
                {
                    string text1 = "Mã sách bị trùng ";
                    string caption1 = "Cảnh báo";
                    MessageDialogButtons button1 = MessageDialogButtons.OK;
                    MessageDialogIcon icon1 = MessageDialogIcon.Warning;
                    new frmMain().Msgbox(text1, caption1, button1, icon1);
                    gtxtma.Focus();
                    return;
                }
                Sach sach = new Sach
                {
                    MaSach = this.gtxtma.Text,
                    TenSach = this.gtxtTenSach.Text,
                    DonGia = decimal.Parse(this.gtxtDongia.Text),
                    NamPhatHanh = int.Parse(this.gtxtNamphathanh.Text),
                    NgayNhap = this.gdtpNgaynhap.Value.Date,
                    NhaXuatBan = this.gtxtNhaxb.Text,
                    SoLuong = int.Parse(this.gtxtSoluong.Text),
                    TenTacGia = this.gtxtTacgia.Text,
                    TheLoai = this.gtxtTheloai.Text,
                };
                this.sachCtrl.Insert(sach);
                string text = "Đã thêm sách thành công có mã " + gtxtma.Text;
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                if (TopLevelControl is frmMain main)
                {
                    main.ShowControl(new ucSach());
                }
            }
        }
        private bool IsFilledAll()
        {
            if (!new frmMain().Check_Null(gtxtma, "Chưa nhập mã sách"))
            {
                return false;
            }
            if (gtxtma.Text.Length < 3 || gtxtma.Text.Length > 10)
            {
                string text = "Mã sách phải từ 3 đến 10 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtma.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtTenSach, "Chưa nhập tên sách"))
            {
                return false;
            }
            if (gtxtTenSach.Text.Length > 100)
            {
                string text = "Tên sách tối đa 100 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtTenSach.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtTacgia, "Chưa nhập tên tác giả"))
            {
                return false;
            }
            if (gtxtTacgia.Text.Length > 60)
            {
                string text = "Tên tác giả tối đa 60 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtTacgia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gdtpNgaynhap.Text))
            {
                string text = "Chưa nhập ngày nhập";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gdtpNgaynhap.Focus();
                return false;
            }
            if (gdtpNgaynhap.Value > DateTime.Now)
            {
                string text = "Ngày nhập không hợp lệ (lớn hơn ngày hiện tại)";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gdtpNgaynhap.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtNhaxb, "Chưa nhập nhà xuất bản"))
            {
                return false;
            }
            if (gtxtNhaxb.Text.Length > 80)
            {
                string text = "Nhà xuất bản tối đa 80 ký tự.";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtNhaxb.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtTheloai, "Chưa nhập thể loại"))
            {
                return false;
            }
            if (gtxtTheloai.Text.Length > 40)
            {
                string text = "Thể loại tối đa 40 ký tự";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtTheloai.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtDongia, "Chưa nhập đơn giá"))
            {
                return false;
            }
            if (decimal.Parse(gtxtDongia.Text) < 0 || decimal.Parse(gtxtDongia.Text) > 5_000_000)
            {
                string text = "Đơn giá phải từ 0 đến 5 triệu.";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtDongia.Focus();
                return false;
            }

            if (!new frmMain().Check_Null(gtxtSoluong, "Chưa nhập số lượng"))
            {
                return false;
            }
            if (int.Parse(gtxtSoluong.Text) < 0 || int.Parse(gtxtSoluong.Text) > 1000)
            {
                string text = "Số lượng phải từ 0 đến 1000";
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                gtxtSoluong.Focus();
                return false;
            }
            if (!new frmMain().Check_Null(gtxtNamphathanh, "Chưa nhập số năm phát hành"))
            {
                return false;
            }
            return true;
        }
  
        private void LoadChiTietSach(Sach sach)
        {
            this.gtxtma.Text = sach.MaSach;
            this.gtxtTenSach.Text = sach.TenSach;
            this.gtxtTacgia.Text = sach.TenTacGia;
            this.gtxtSoluong.Text = sach.SoLuong.ToString();
            this.gtxtTheloai.Text = sach.TheLoai;
            this.gtxtDongia.Text = sach.DonGia.ToString();
            this.gtxtNamphathanh.Text = sach.NamPhatHanh.ToString();
            this.gdtpNgaynhap.Value = sach.NgayNhap;
            this.gtxtNhaxb.Text = sach.NhaXuatBan;
        }

        private void gbtnsua_Click(object sender, EventArgs e)
        {
            if (IsFilledAll())
            {
                string MaSach = this.gtxtma.Text;
                string TenSach = this.gtxtTenSach.Text;
                decimal DonGia = decimal.Parse(this.gtxtDongia.Text);
                int NamPhatHanh = int.Parse(this.gtxtNamphathanh.Text);
                DateTime NgayNhap = this.gdtpNgaynhap.Value;
                string NhaXuatBan = this.gtxtNhaxb.Text;
                int SoLuong = int.Parse(this.gtxtSoluong.Text);
                string TenTacGia = this.gtxtTacgia.Text;
                string TheLoai = this.gtxtTheloai.Text;
                Sach sach = this.sachCtrl.FindByKey(MaSach);
                if (sach != null)
                {
                    sach.TenSach = TenSach;
                    sach.DonGia = DonGia;
                    sach.NamPhatHanh = NamPhatHanh;
                    sach.NgayNhap = NgayNhap;
                    sach.NhaXuatBan = NhaXuatBan;
                    sach.SoLuong = SoLuong;
                    sach.TenTacGia = TenTacGia;
                    sach.TheLoai = TheLoai;
                    sachCtrl.Update(sach);
                    // thông báo sửa thành công
                    string text = "Đã sửa thành công sách mã :" + MaSach;
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text, caption, button, icon);
                    if (TopLevelControl is frmMain main)
                    {
                        main.ShowControl(new ucSach());
                    }
                }
            }
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSach());
            }
        }

        private void gtxtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gtxtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void gtxtNamphathanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {

        }

        private void gtxtSoluong_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
        }

        private void ucSachExtra_Load(object sender, EventArgs e)
        {
            if (this.sach != null) this.LoadChiTietSach(this.sach);
        }
    }
}
