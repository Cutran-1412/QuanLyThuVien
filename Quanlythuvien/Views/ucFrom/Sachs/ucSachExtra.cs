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
        private Sach Sach;
        public ucSachExtra(Sach sach)
        {
            InitializeComponent();
            this.Sach = sach;
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (IsFilledAll())
            {
                if (this.sachCtrl.FindByKey(this.gtxtma.Text) != null)
                {
                    // thông báo đã tồn tại sách

                    return;
                }
                Sach sach = new Sach
                {
                    MaSach = this.gtxtma.Text,
                    TenSach = this.gtxtTenSach.Text,
                    DonGia = decimal.Parse(this.gtxtDongia.Text),
                    NamPhatHanh = int.Parse(this.gtxtNamphathanh.Text),
                    NgayNhap = this.gdtpNgaynhap.Value,
                    NhaXuatBan = this.gtxtNhaxb.Text,
                    SoLuong = int.Parse(this.gtxtSoluong.Text),
                    TenTacGia = this.gtxtTacgia.Text,
                    TheLoai = this.gtxtTheloai.Text,
                };
                this.sachCtrl.Insert(sach);
                // thông báo thêm thành công
                string text = "Đã thêm sách thành công";
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
            return true;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.Sach != null) this.LoadChiTietSach(this.Sach);
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
                string text = "Đã sửa thành công";
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

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSach());
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            string maSach = this.gtxtma.Text;
            if (this.sachCtrl.DeleteByKey(maSach))
            {
                // thông báo xóa thành công
                string text = "Đã xóa thành công";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                if (TopLevelControl is frmMain main)
                {
                    main.ShowControl(new ucSach());
                }
            }
            else
            {
                // thông báo xóa thất bại 
            }
        }
    }
}
