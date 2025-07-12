using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;

namespace Quanlythuvien.Views.ucFrom.DocGias
{
    public partial class ucDocgiaExtra : UserControl
    {
        private readonly DocGiaController dgctr = new DocGiaController();
        private DocGia docgia;
        public ucDocgiaExtra(DocGia dg)
        {
            InitializeComponent();
            docgia = dg;
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
                datengaydangki.Value = docgia.NgayDangKy;
                gtxttienphat.Text = docgia.TienPhat.ToString();
            }
        }
        private void ucDocgiaExtra_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private bool Check_Null()
        {

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
                    NgaySinh = gdatengaysinh.Value,
                    SoDienThoai = gtxtsodienthoai.Text,
                    Email = gtxtemail.Text,
                    DiaChi = gtxtdiachi.Text,
                    NgayDangKy = datengaydangki.Value,
                    TienPhat = decimal.Parse(gtxttienphat.Text)
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
                    NgayDangKy = datengaydangki.Value,
                    TienPhat = decimal.Parse(gtxttienphat.Text)
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
    }
}
