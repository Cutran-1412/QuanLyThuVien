using Quanlythuvien.Controllers;
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
        private ChiTietPhieuMuonController chiTietCtrl = new ChiTietPhieuMuonController();
        int cnt = 0;
        public PhieuMuonForm()
        {
            InitializeComponent();
            this.SinhMaPhieu();
            this.cnt = this.chiTietCtrl.GetCount();
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
            int sachRowSelected = this.dgvSach.CurrentRow.Index;
            int docGiaRowSelected = this.dgvDocGia.CurrentRow.Index;
            int soLuong = int.Parse(this.txtSoLuong.Text);
            if (docGiaRowSelected < 0 || docGiaRowSelected > this.dgvDocGia.Rows.Count)
            {
                //Thông báo vui lòng chọn độc giả
                return;
            }
            if (sachRowSelected < 0 || sachRowSelected > this.dgvSach.Rows.Count)
            {
                //Thông báo vui lòng chọn sách
                return;
            }
            this.phieuMuon.MaDocGia = this.dgvDocGia.Rows[docGiaRowSelected].Cells[0].Value.ToString();
            string maSach = this.dgvSach.Rows[sachRowSelected].Cells[0].Value.ToString();
            ChiTietPhieuMuon ct = new ChiTietPhieuMuon { Id = "CT" + (++cnt), MaSach = maSach, MaPhieuMuon = this.phieuMuon.MaPhieuMuon, SoLuong = soLuong };
            this.phieuMuon.ChiTietPhieuMuons.Add(ct);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.phieuMuon.NgayMuon = this.dtpNgayMuon.Value.Date;
            this.phieuMuon.NgayPhaiTra = this.dtpNgaytra.Value.Date;
            this.phieuMuonctrl.Insert(this.phieuMuon);

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
