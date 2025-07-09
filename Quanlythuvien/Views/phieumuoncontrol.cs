using Quanlythuvien.Controllers;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views
{
    public partial class phieumuoncontrol : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new PhieuMuonController();
        private SachController sachController = new SachController();
        private DocGiaController docGiaCtrol = new DocGiaController();
        private ChiTietPhieuMuonController ctPhieuMuonCtrl = new ChiTietPhieuMuonController();
        private BindingList<ChiTietPhieuMuon> chiTietPhieuMuons = new BindingList<ChiTietPhieuMuon>();
        public phieumuoncontrol()
        {
            InitializeComponent();
        }

        private void phieumuoncontrol_Load(object sender, EventArgs e)
        {
            this.LoadDateTime();
            this.LoadDanhSachMuon();
        }

        private void LoadDateTime()
        {
            this.dtpNgayMuon.Value = DateTime.Now.Date;

        }
        private void LoadDanhSachMuon()
        {
            this.dgvDanhSachMuon.DataSource = this.chiTietPhieuMuons;
            this.dgvDanhSachMuon.Columns["PhieuMuon"].Visible = false;
            this.dgvDanhSachMuon.Columns["Sach"].Visible = false;
            this.dgvDanhSachMuon.Columns["SoLuongDaTra"].Visible = false;

        }

        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            this.SinhMaPhieuMuon();
            this.ToggleControlPhieuMuon(true);
            this.LoadMaDocGia();
            this.LoadChiTietPhieuMuon(this.txtMaPhieuLeft.Text);

        }
        private void LoadMaDocGia()
        {
            this.cboMaDG.DataSource = this.docGiaCtrol.Get_DocGia();
            this.cboMaDG.DisplayMember = "MaDocGia";
            this.cboMaDG.ValueMember = "MaDocGia";
            this.cboMaDG.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboMaDG.MaxDropDownItems = 5;
        }
        private void ToggleControlPhieuMuon(bool isEnable)
        {
            this.cboMaDG.Enabled = isEnable;
            this.dtpNgayHenTra.Enabled = isEnable;

            this.btnHuyPhieuMuon.Enabled = isEnable;
        }
        private void SinhMaPhieuMuon()
        {
            int soLuongDaCo = this.phieuMuonCtrl.GetCount();
            this.txtMaPhieuLeft.Text = "PM" + (++soLuongDaCo);
        }

        private void btnLuuPhieuMuon_Click(object sender, EventArgs e)
        {

            PhieuMuon phieuMuon = new PhieuMuon
            {
                MaPhieuMuon = this.txtMaPhieuLeft.Text,
                MaDocGia = this.cboMaDG.SelectedValue.ToString(),
                NgayMuon = this.dtpNgayMuon.Value.Date,
                NgayPhaiTra = this.dtpNgayHenTra.Value.Date
            };
            phieuMuon.ChiTietPhieuMuons = this.chiTietPhieuMuons.ToList();
            this.phieuMuonCtrl.Insert(phieuMuon);
            this.LoadThongTinSach(this.txtMaSach.Text);
            this.btnChoMuon.Enabled = false;
            this.ClearAll();
            this.chiTietPhieuMuons.Clear();

        }
        private void ClearAll()
        {
            this.ClearChiTietPhieuMuon();
            this.ClearPhieuMuon();
        }
        private void LoadChiTietPhieuMuon(string maPhieuMuon)
        {
            this.txtMaPhieuCenter.Text = maPhieuMuon;
            this.cbbMaSach.Enabled = true;
            this.txtSoLuongMuon.ReadOnly = false;

            this.cbbMaSach.DropDownHeight = this.cbbMaSach.ItemHeight * 5;
            this.cbbMaSach.DataSource = this.sachController.GetData();
            this.cbbMaSach.DisplayMember = "MaSach";
            this.cbbMaSach.ValueMember = "MaSach";
        }

        private void cbbMaSach_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbbMaSach.DataSource == null) return;
            var maSach = this.cbbMaSach.SelectedValue.ToString();
            this.LoadThongTinSach(maSach);
        }
        private void LoadThongTinSach(string maSach)
        {
            Sach sach = this.sachController.FindByKey(maSach);
            if (sach == null) return;
            this.txtMaSach.Text = sach.MaSach;
            this.txtTenSach.Text = sach.TenSach;
            this.txtTacGia.Text = sach.TenTacGia;
            this.txtTheLoai.Text = sach.TheLoai;
            this.txtSoLuongCon.Text = sach.SoLuong.ToString();
        }
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            int soLuongMuon = int.Parse(this.txtSoLuongMuon.Text);

            ChiTietPhieuMuon ctPhieuMuon = new ChiTietPhieuMuon
            {
                MaPhieuMuon = this.txtMaPhieuCenter.Text,
                MaSach = this.cbbMaSach.SelectedValue.ToString(),
                SoLuongMuon = int.Parse(this.txtSoLuongMuon.Text)
            };
            this.txtSoLuongCon.Text = (int.Parse(this.txtSoLuongCon.Text) - ctPhieuMuon.SoLuongMuon).ToString();
            var sa = ctPhieuMuon.MaSach;
            bool isContained = false;
            foreach (var ct in this.chiTietPhieuMuons)
            {
                if (!ct.MaPhieuMuon.Equals(ctPhieuMuon.MaPhieuMuon) && ct.MaSach.Equals(ctPhieuMuon.MaSach)) continue;
                ct.SoLuongMuon += ctPhieuMuon.SoLuongMuon;
                isContained = true;
                this.dgvDanhSachMuon.Refresh();
                break;
            }
            if (!isContained) this.chiTietPhieuMuons.Add(ctPhieuMuon);
        }

        private void txtSoLuongMuon_TextChanged(object sender, EventArgs e)
        {
            string soLuongMuon = this.txtSoLuongMuon.Text;
            if (string.IsNullOrWhiteSpace(soLuongMuon) || string.IsNullOrEmpty(soLuongMuon))
            {

                this.btnThemChiTiet.Enabled = false;
            }
            else
            {
                this.btnThemChiTiet.Enabled = true;
            }
        }

        private void btnHuyPhieuMuon_Click(object sender, EventArgs e)
        {
            this.phieuMuonCtrl.DeleteByKey(this.txtMaPhieuLeft.Text);

            this.ClearPhieuMuon();
            this.ClearChiTietPhieuMuon();
            this.ClearThongTinSach();
            this.LoadDanhSachMuon();
        }
        private void ClearPhieuMuon()
        {
            this.txtMaPhieuLeft.Text = string.Empty;
            this.cboMaDG.DataSource = null;
            this.dtpNgayHenTra.Value = DateTime.Now;
            this.ToggleControlPhieuMuon(false);
        }
        private void ClearChiTietPhieuMuon()
        {
            this.txtMaPhieuCenter.Text = string.Empty;
            this.cbbMaSach.DataSource = null;
            this.txtSoLuongMuon.Text = string.Empty;
        }
        private void ClearThongTinSach()
        {
            this.txtMaSach.Text = string.Empty;
            this.txtTenSach.Text = string.Empty;
            this.txtTacGia.Text = string.Empty;
            this.txtTheLoai.Text = string.Empty;
            this.txtSoLuongCon.Text = string.Empty;
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachMuon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowCount = this.dgvDanhSachMuon.Rows.Count;
            if (rowCount > 0)
            {
                this.btnChoMuon.Enabled = true;
            }
            else
            {
                this.btnChoMuon.Enabled = false;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
