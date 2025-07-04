﻿using Quanlythuvien.Controllers;
using Quanlythuvien.Models;
using Quanlythuvien.Models.PhieuMuons;
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
    public partial class PhieuMuonForm : Form
    {
        private PhieuMuon phieuMuon = new PhieuMuon();
        private PhieuMuonController phieuMuonctrl = new PhieuMuonController();
        private SachController sachCtrl = new SachController();
        private DocGiaController docGiaCtrl = new DocGiaController();
        int cnt = 0;
        public PhieuMuonForm()
        {
            InitializeComponent();
            this.SinhMaPhieu();
        }
        private void SinhMaPhieu()
        {
            int cnt = this.phieuMuonctrl.GetCount() + 1;
            this.phieuMuon.MaPhieuMuon = "PM" + cnt;
            this.txtMaPhieu.Text = this.phieuMuon.MaPhieuMuon;
        }
        private void phieumuon_Load(object sender, EventArgs e)
        {
            this.LoadSach();
            this.LoadDocGia();
        }
        private void LoadSach()
        {
            this.dgvSach.DataSource = this.sachCtrl.GetData();
        }
        private void LoadDocGia()
        {
            this.dgvDocGia.DataSource = this.docGiaCtrl.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (DataContext context = new DataContext())
            {
                int rowSelected = this.dgvSach.CurrentRow.Index;
                string maSach = this.dgvSach.Rows[rowSelected].Cells[0].Value.ToString();
                ChiTietPhieuMuon ct = new ChiTietPhieuMuon { Id = "CT" + (++cnt), MaSach = maSach, PhieuMuonId = this.phieuMuon.MaPhieuMuon, NgayTra = null };
                context.ChiTietPhieuMuons.Add(ct);
                this.phieuMuon.ChiTietPhieuMuons.Add(ct);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                this.phieuMuon.NgayMuon = this.dtpNgayMuon.Value;

                context.PhieuMuons.Add(this.phieuMuon);
                context.SaveChanges();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
