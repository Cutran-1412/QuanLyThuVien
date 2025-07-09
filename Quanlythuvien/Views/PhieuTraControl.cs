
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
        private PhieuTra phieuTra;
        private PhieuMuonController phieuMuonCtrl = new PhieuMuonController();
        private PhieuTraController phieuTraCtrl = new PhieuTraController();

        private ChiTietPhieuTraController chiTietPhieuTraCtrl = new ChiTietPhieuTraController();
        private ChiTietPhieuMuonController chiTietPhieuMuonCtrl = new ChiTietPhieuMuonController();
        public PhieuTraControl()
        {
            InitializeComponent();
        }
        private string SinhMaPhieuTra()
        {
            int cnt = this.phieuTraCtrl.GetCount() + 1;
            return "PT" + cnt;
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
            int soLuongTra = int.Parse(this.txtSoLuongTra.Text);
            this.phieuTra = this.phieuTraCtrl.FindByKey(this.txtMaPhieuTra.Text);
            if (phieuTra == null)
            {
                this.phieuTra = new PhieuTra
                {
                    MaPhieuTra = this.SinhMaPhieuTra(),
                    MaPhieuMuon = maPhieuMuon,
                    NgayTra = DateTime.Now.Date,
                    ChiTietPhieuTras = new List<ChiTietPhieuTra>()
                };
                this.phieuTraCtrl.Insert(phieuTra);
                this.txtMaPhieuTra.Text = this.phieuTra.MaPhieuTra;
            }
            this.chiTietPhieuMuonCtrl.TraSach(maPhieuMuon, maSach, soLuongTra);
            this.LoadChiTietPhieuMuon(maPhieuMuon);

            var ctPhieuTra = new ChiTietPhieuTra
            {
                MaPhieuTra = this.phieuTra.MaPhieuTra,
                MaSach = maSach,
                SoLuong = soLuongTra
            };
            this.chiTietPhieuTraCtrl.Insert(ctPhieuTra);
            this.phieuTra.ChiTietPhieuTras.Add(ctPhieuTra);
            MessageBox.Show("Đã thêm sách vào phiếu trả");

        }
    }
}