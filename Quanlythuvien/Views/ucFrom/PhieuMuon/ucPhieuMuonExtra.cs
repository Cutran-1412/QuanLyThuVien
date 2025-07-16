using Guna.UI2.WinForms;
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
            gdgvSach.CellBorderStyle = DataGridViewCellBorderStyle.Single;
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
                this.LoadMaSach();
                this.gdgvSach.DataSource = this.ctPhieuMuons;
            }
            this.LoadSachMuon();

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
            foreach (Control ct in this.ggrbTtPhieuMuon.Controls)
            {
                ct.Enabled = false;
            }
            foreach (Control ct in this.ggrbCnPhieuMuon.Controls)
            {
                ct.Enabled = false;
            }
            gbtnThoat.Enabled = true;
            foreach (Control ct in this.ggrbCnChitiet.Controls)
            {
                ct.Enabled = false;
            }
        }
        private void LoadSachMuon()
        {
            this.gdgvSach.DataSource = this.ctPhieuMuons;
            this.gdgvSach.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gdgvSach.Columns["MaPhieuMuon"].Visible = false;
            this.gdgvSach.Columns["PhieuMuon"].Visible = false;
            this.gdgvSach.Columns["Sach"].Visible = false;
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

        private void gbtnThemSach_Click(object sender, EventArgs e)
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
            this.gdgvSach.Refresh();
        }

        private void gbtnThoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuMuon());
            }
        }
    }
}
