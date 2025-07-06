using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace Quanlythuvien.Views
{
    public partial class PhieuTraControl : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new PhieuMuonController();
        private PhieuTraController phieuTraCtrl = new PhieuTraController();
        PhieuTra phieuTra = new PhieuTra();
        private ChiTietPhieuTraController chiTietPhieuTraCtrl = new ChiTietPhieuTraController();
        private ChiTietPhieuMuonController chiTietPhieuMuonCtrl = new ChiTietPhieuMuonController();
        int cnt = 0;
        public PhieuTraControl()
        {
            InitializeComponent();
            this.SinhMaPhieuTra();
            this.cnt = this.chiTietPhieuTraCtrl.GetCount();
        }
        private void SinhMaPhieuTra()
        {
            int cnt = this.phieuTraCtrl.GetCount() + 1;
            this.phieuTra.MaPhieuTra = "PT" + cnt;
            this.txtMaPhieuTra.Text = this.phieuTra.MaPhieuTra;
        }
        private void LoadChiTietPhieuMuon(string maPhieuMuon)
        {
            PhieuMuon phieuMuon = this.phieuMuonCtrl.FindByKey(maPhieuMuon);
            if (phieuMuon == null)
            {
                //không tìm thấy phiếu mượn trên database
                return;
            }
            this.dgvChiTietPhieuMuon.DataSource = phieuMuon.ChiTietPhieuMuons;
            this.dgvChiTietPhieuMuon.Columns["PhieuMuon"].Visible = false;
            this.dgvChiTietPhieuMuon.Columns["Sach"].Visible = false;
            this.dgvChiTietPhieuMuon.Columns["Id"].Visible = false;

        }
        private void LoadPhieuMuon()
        {
            this.dgvPhieuMuon.DataSource = this.phieuMuonCtrl.GetData();
            dgvPhieuMuon.Columns["DocGia"].Visible = false;
        }

        private void PhieuTraControl_Load(object sender, EventArgs e)
        {
            this.LoadPhieuMuon();

        }
        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = this.dgvPhieuMuon.CurrentRow.Index;
            var maPhieuMuon = this.dgvPhieuMuon.Rows[row].Cells[0].Value.ToString();
            this.LoadChiTietPhieuMuon(maPhieuMuon);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            int row = this.dgvChiTietPhieuMuon.CurrentRow.Index;
            var maSach = this.dgvChiTietPhieuMuon.Rows[row].Cells["MaSach"].Value.ToString();
            var maPhieuMuon = this.dgvChiTietPhieuMuon.Rows[row].Cells["MaPhieuMuon"].Value.ToString();
            var ctPhieuMuonId = this.dgvChiTietPhieuMuon.Rows[row].Cells[0].Value.ToString();
            var daTra = bool.Parse(this.dgvChiTietPhieuMuon.Rows[row].Cells["DaTra"].Value.ToString());
            if (daTra)
            {
                //thong bao sach da duoc tra
                return;
            }
            this.chiTietPhieuMuonCtrl.TraSach(ctPhieuMuonId);
            this.LoadChiTietPhieuMuon(maPhieuMuon);
            ChiTietPhieuTra chiTietPhieuTra
                = new ChiTietPhieuTra
                {
                    Id = "CT" + (++cnt),
                    MaPhieuTra = this.phieuTra.MaPhieuTra,
                    MaSach = maSach,
                    NgayTra = this.dtpNgayTra.Value.Date,
                };

            this.phieuTra.MaPhieuMuon = maPhieuMuon;
            this.phieuTra.ChiTietPhieuTras.Add(chiTietPhieuTra);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.phieuTra.NgayTra = this.dtpNgayTra.Value.Date;
            this.phieuTraCtrl.Insert(this.phieuTra);
        }
    }
}
