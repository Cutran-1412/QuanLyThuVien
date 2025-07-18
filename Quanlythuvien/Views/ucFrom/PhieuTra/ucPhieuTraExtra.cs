using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;
using Quanlythuvien.Views.ucFrom.PhieuMuon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanlythuvien.Views.ucFrom.PhieuTra
{
    public partial class ucPhieuTraExtra : UserControl
    {
        private PhieuTraController phieuTraCtrl = new();
        private PhieuMuonController phieuMuonCtrl = new();
        private ChiTietPhieuMuonController ctPhieuMuonCtrl = new();
        private ChiTietPhieuTraController ctPhieuTraCtrl = new();
        private SachController sachCtrl = new();
        private BindingList<ChiTietPhieuTra> ctPhieuMuons = new();
        private Quanlythuvien.Models.PhieuTras.PhieuTra phieuTra;
        public ucPhieuTraExtra(Models.PhieuTras.PhieuTra phieutra)
        {
            InitializeComponent();
            this.phieuTra = phieutra;

            dgvDanhSachMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private void ucPhieuTraExtra_Load(object sender, EventArgs e)
        {
            if (this.phieuTra != null)
            {
                this.gtxtmaphieutra.Text = this.phieuTra.MaPhieuTra;
                this.gcboMaPhieuMuon.SelectedValue = this.phieuTra.MaPhieuMuon;
                this.gdtpNgaytra.Value = this.phieuTra.NgayTra;


                this.LoadMaPhieuMuon();
                this.SetReadOnly();
                this.gcboMaPhieuMuon.SelectedValue = phieuTra.MaPhieuMuon;
                this.ctPhieuMuons = new BindingList<ChiTietPhieuTra>(this.phieuTra.ChiTietPhieuTras);


            }
            else
            {
                this.SinhMaPhieuTra();
                this.LoadMaPhieuMuonChuaTra();
                this.gdtpNgaytra.Value = DateTime.Now.Date;

            }
            this.dgvDanhSachMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
        private void SetReadOnly()
        {
            foreach (Control ct in this.ggrbTtPhieuTra.Controls)
            {
                ct.Enabled = false;
            }
            this.gtxtmaphieutra.Enabled = true;
            this.gtxtmaphieutra.ReadOnly = true;
            this.gtxtMasach.ReadOnly = true;
            this.gtxtTenSach.ReadOnly = true;
            this.gtxtSlMuon.ReadOnly = true;
            this.gtxtTienphat.ReadOnly = true;
            this.gbtnTraSach.Enabled = false;
            gbtnThoat.Enabled = true;

        }
        private void LoadMaPhieuMuon()
        {
            this.gcboMaPhieuMuon.DataSource = this.phieuMuonCtrl.GetData();
            this.gcboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.ValueMember = "MaPhieuMuon";
        }
        private void LoadMaPhieuMuonChuaTra()
        {
            this.gcboMaPhieuMuon.DataSource = this.phieuMuonCtrl.GetPhieuMuonChuaTra();
            this.gcboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.ValueMember = "MaPhieuMuon";



        }
        public void SinhMaPhieuTra()
        {
            var phieuCuoi = this.phieuTraCtrl.GetLast();
            int nextNumber = 1;
            if (phieuCuoi != null)
            {
                string numberPart = phieuCuoi.MaPhieuTra.Substring(2);
                if (int.TryParse(numberPart, out nextNumber))
                {
                    nextNumber = nextNumber + 1;
                }
            }
            this.gtxtmaphieutra.Text = "PT" + nextNumber;
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTra());
            }
        }

        private void gcboMaPhieuMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gcboMaPhieuMuon.SelectedValue is string maPhieu)
            {
                this.LoadDanhSachMuon(maPhieu);
            }

        }
        private void LoadDanhSachMuon(string maPhieuMuon)
        {
            this.dgvDanhSachMuon.DataSource = this.phieuMuonCtrl.FindByKey(maPhieuMuon).ChiTietPhieuMuons;
            this.dgvDanhSachMuon.Columns["MaPhieuMuon"].Visible = false;
            this.dgvDanhSachMuon.Columns["PhieuMuon"].Visible = false;
            this.dgvDanhSachMuon.Columns["Sach"].Visible = false;
          
        }

        private void dgvDanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvDanhSachMuon.CurrentRow.Index;
            this.gtxtMasach.Text = this.dgvDanhSachMuon.Rows[index].Cells["MaSach"].Value.ToString();
            this.gtxtTenSach.Text = this.dgvDanhSachMuon.Rows[index].Cells["TenSach"].Value.ToString();
            this.gtxtSlMuon.Text = this.dgvDanhSachMuon.Rows[index].Cells["SoLuongMuon"].Value.ToString();
            this.TinhTienPhat();
            if (Convert.ToBoolean(this.dgvDanhSachMuon.Rows[index].Cells["DaTra"].Value))
            {
                this.gbtnTraSach.Enabled = false;
            }
            else if(this.phieuTra ==null)
            {
                this.gbtnTraSach.Enabled = true;
            }
        }
        private void TinhTienPhat()
        {
            var phieuMuon = this.phieuMuonCtrl.FindByKey(this.gcboMaPhieuMuon.SelectedValue.ToString());
            int soNgayTre = (this.gdtpNgaytra.Value - phieuMuon.NgayPhaiTra).Days;
            float tienPhatMoiQuyen = 1000;
            int slMuon = int.Parse(this.gtxtSlMuon.Text);
            this.gtxtTienphat.Text = (soNgayTre * tienPhatMoiQuyen * slMuon).ToString();
        }

        private void gbtnTraSach_Click(object sender, EventArgs e)
        {
            if (this.phieuTra == null)
            {
                this.phieuTra = new Models.PhieuTras.PhieuTra
                {
                    MaPhieuTra = this.gtxtmaphieutra.Text,
                    MaPhieuMuon = this.gcboMaPhieuMuon.SelectedValue.ToString(),
                    NgayTra = this.gdtpNgaytra.Value,

                };
            }

            ChiTietPhieuTra ctPhieuTra = new ChiTietPhieuTra
            {
                MaPhieuTra = this.phieuTra.MaPhieuTra,
                MaSach = this.gtxtMasach.Text,
                //   TienPhat = decimal.Parse(this.gtxttienphat.Text)
            };

            if (this.phieuTraCtrl.FindByKey(this.phieuTra.MaPhieuTra) != null)
            {
                this.phieuTraCtrl.Update(phieuTra);
            }
            else
            {
                this.phieuTraCtrl.Insert(this.phieuTra);
            }
            this.ctPhieuTraCtrl.Insert(ctPhieuTra);
            string text = "Đã trả sách thành công";
            string caption = "Thông báo";
            MessageDialogButtons button = MessageDialogButtons.OK;
            MessageDialogIcon icon = MessageDialogIcon.Information;
            new frmMain().Msgbox(text, caption, button, icon);
            this.gcboMaPhieuMuon.Enabled = false;
            this.LoadDanhSachMuon(this.gcboMaPhieuMuon.SelectedValue.ToString());
        }

        private void gbtnThoat_Click_1(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTra());
            }
        }

        private void dgvDanhSachMuon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvDanhSachMuon.ClearSelection();
            this.dgvDanhSachMuon.CurrentCell = null;
        }
    }
}
