using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Metadata;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Views.ucFrom.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
namespace Quanlythuvien.Views.ucFrom.PhieuMuon
{
    public partial class ucPhieuMuonExtra : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new();
        private DocGiaController docGiaCtrl = new();
        private SachController sachCtrl = new();
        private Quanlythuvien.Models.PhieuMuons.PhieuMuon phieuMuon;
        private BindingList<ChiTietPhieuMuon> ctPhieuMuons = new();
        public ucPhieuMuonExtra(Models.PhieuMuons.PhieuMuon phieuMuon)
        {
            InitializeComponent();
            this.phieuMuon = phieuMuon;
            this.LoadMaDocGia();
            gdgvCtMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;

        }

        private void ucPhieuMuonExtra_Load(object sender, EventArgs e)
        {
            if (this.phieuMuon != null)
            {
                this.gtxtMaPhieu.Text = this.phieuMuon.MaPhieuMuon;
                this.gcboMaDG.SelectedValue = this.phieuMuon.MaDocGia;
                this.gdtpNgayMuon.Value = this.phieuMuon.NgayMuon;
                this.gdtpNgayHenTra.Value = this.phieuMuon.NgayPhaiTra;
                this.SetReadOnly();
                this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.phieuMuon.ChiTietPhieuMuons);
            }
            else
            {
                this.SinhMaPhieuMuon();
                this.LoadDtp();
                this.gdgvCtMuon.DataSource = this.ctPhieuMuons;
            }
            this.LoadSachMuon();
            this.LoadMaSach();
        }
        private void LoadDtp()
        {
            this.gdtpNgayMuon.Value = DateTime.Now;
            this.gdtpNgayHenTra.Value = DateTime.Now;
        }
        private void LoadMaSach()
        {
            this.gcboMaSach.DropDownHeight = this.gcboMaSach.ItemHeight * 5;
            this.gcboMaSach.DataSource = this.sachCtrl.GetData();
            this.gcboMaSach.SelectedIndex = -1;
            this.gcboMaSach.DisplayMember = "MaSach";
            this.gcboMaSach.ValueMember = "MaSach";
        }
        private void SetReadOnly()
        {
            this.gtxtMaPhieu.ReadOnly = true;
            this.gcboMaDG.Enabled = false;
            this.gdtpNgayMuon.Enabled = false;
            this.gdtpNgayHenTra.Enabled = false;
            foreach (Control ct in this.ggrbCnPhieuMuon.Controls)
            {
                ct.Enabled = false;
            }
            foreach (Control ct in this.ggrbCnChitiet.Controls)
            {
                ct.Enabled = false;
            }
            gbtnThoat.Enabled = true;
        }
        private void LoadSachMuon()
        {
            this.gdgvCtMuon.DataSource = this.ctPhieuMuons;
            this.gdgvCtMuon.Columns["MaSach"].FillWeight = 90;
            this.gdgvCtMuon.Columns["TenSach"].FillWeight = 150;
            this.gdgvCtMuon.Columns["SoLuongMuon"].FillWeight = 80;
            this.gdgvCtMuon.Columns["DaTra"].FillWeight = 65;
            this.gdgvCtMuon.Columns["MaPhieuMuon"].Visible = false;
            this.gdgvCtMuon.Columns["PhieuMuon"].Visible = false;
            this.gdgvCtMuon.Columns["Sach"].Visible = false;

            DataGridViewButtonColumn btnCotXoa = new DataGridViewButtonColumn();
            btnCotXoa.Name = "btnXoa";               
            btnCotXoa.HeaderText = "Thao tác";         
            btnCotXoa.Text = "Xóa";                     
            btnCotXoa.UseColumnTextForButtonValue = true; 
            btnCotXoa.FillWeight = 80;     

            gdgvCtMuon.Columns.Add(btnCotXoa);

        }
        private void ClearPhieuMuon()
        {
            this.gtxtMaPhieu.Text = string.Empty;
            this.gcboMaDG.SelectedItem = null;
            this.gdtpNgayMuon.Value = DateTime.Now;
            this.gdtpNgayHenTra.Value = DateTime.Now;

        }
        public void SinhMaPhieuMuon()
        {
            var phieuCuoi = this.phieuMuonCtrl.GetLast();
            int nextNumber = 1;
            if (phieuCuoi != null)
            {
                string numberPart = phieuCuoi.MaPhieuMuon.Substring(2);
                if (int.TryParse(numberPart, out nextNumber))
                {
                    nextNumber = nextNumber + 1;
                }
            }
            this.gtxtMaPhieu.Text = "PM" + nextNumber;
        }

        private void LoadMaDocGia()
        {
            this.gcboMaDG.DataSource = this.docGiaCtrl.Get_DocGia();
            this.gcboMaDG.DisplayMember = "MaDocGia";
            this.gcboMaDG.ValueMember = "MaDocGia";
            this.gcboMaDG.DropDownHeight = this.gcboMaDG.ItemHeight * 5;
            this.gcboMaDG.SelectedIndex = -1;
        }

        private void gbtnLuu_Click(object sender, EventArgs e)
        {
            if (!this.IsFilledAll()) return;
            Quanlythuvien.Models.PhieuMuons.PhieuMuon phieuMuon = new Models.PhieuMuons.PhieuMuon()
            {
                MaPhieuMuon = this.gtxtMaPhieu.Text,
                MaDocGia = this.gcboMaDG.SelectedValue.ToString(),
                NgayMuon = this.gdtpNgayMuon.Value.Date,
                NgayPhaiTra = this.gdtpNgayHenTra.Value.Date,
                ChiTietPhieuMuons = this.ctPhieuMuons.ToList(),
            };
            if (this.phieuMuonCtrl.Insert(phieuMuon))
            {
                // thông báo thêm thành công
                string text = "Đã thêm phiếu mượn thành công";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                if (TopLevelControl is frmMain main)
                {
                    main.ShowControl(new ucPhieuMuon());
                }
            }
        }
        private bool IsFilledAll()
        {
            if (this.gcboMaDG.SelectedValue == null)
            {
                string text = "Vui lòng chọn mã độc giả";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                return false;
            }
            if (this.ctPhieuMuons == null || this.ctPhieuMuons.Count == 0)
            {
                string text = "Chưa có sách nào được chọn";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                return false;
            }
            return true;
        }
        private void gbtnThemSach_Click(object sender, EventArgs e)
        {
            if (!new frmMain().Check_Null(gtxtSoLuongMuon, "Chưa nhập số lượng mượn"))
            {
                return;
            }
            else
            {
                int soLuongMuon = int.Parse(this.gtxtSoLuongMuon.Text);
                ChiTietPhieuMuon ctPhieuMuon = new ChiTietPhieuMuon
                {
                    MaPhieuMuon = this.gtxtMaPhieu.Text,
                    MaSach = this.gcboMaSach.SelectedValue.ToString(),
                    SoLuongMuon = soLuongMuon
                };
                var sa = ctPhieuMuon.MaSach;
                bool isContained = false;
                foreach (var ct in this.ctPhieuMuons)
                {
                    if (!ct.MaPhieuMuon.Equals(ctPhieuMuon.MaPhieuMuon) || !ct.MaSach.Equals(ctPhieuMuon.MaSach)) continue;
                    ct.SoLuongMuon += ctPhieuMuon.SoLuongMuon;
                    isContained = true;

                    break;
                }
                if (!isContained)
                    this.ctPhieuMuons.Add(ctPhieuMuon);
                this.gdgvCtMuon.Refresh();
            }
        }

        private void gbtnThoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuMuon());
            }
        }

        private void gcboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sach = this.sachCtrl.FindByKey(gcboMaSach.Text);
            if (sach != null)
            {
                glblsoluongcon.Visible = true;
                glblsoluongcon.Text = "Số lượng tồn kho :" + sach.SoLuong;
            }
        }

        private void gdgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.gdgvCtMuon.CurrentRow.Index;
            this.gcboMaSach.SelectedValue = this.gdgvCtMuon.Rows[index].Cells["MaSach"].Value;
            this.gtxtSoLuongMuon.Text  = this.gdgvCtMuon.Rows[index].Cells["SoLuongMuon"].Value.ToString();
        }

        private void ggrbCnChitiet_Click(object sender, EventArgs e)
        {

        }
    }
}
