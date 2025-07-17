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
            this.LoadMaPhieuMuon();
            dgvDanhSachMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private void ucPhieuTraExtra_Load(object sender, EventArgs e)
        {
            if (this.phieuTra != null)
            {
                this.gtxtmaphieutra.Text = this.phieuTra.MaPhieuTra;
                this.gcboMaPhieuMuon.SelectedValue = this.phieuTra.MaPhieuMuon;
                this.gdtpngaytra.Value = this.phieuTra.NgayTra;

                this.SetReadOnly();
                this.LoadMaPhieuMuonChuaTra();
                this.gcboMaPhieuMuon.SelectedValue = phieuTra.MaPhieuMuon;
                this.ctPhieuMuons = new BindingList<ChiTietPhieuTra>(this.phieuTra.ChiTietPhieuTras);
            }
            else
            {
                this.SinhMaPhieuTra();
                this.LoadMaPhieuMuonChuaTra();
                this.gdtpngaytra.Value = DateTime.Now.Date;

            }
        }
        private void SetReadOnly()
        {
            foreach (Control ct in this.ggrbTtPhieuTra.Controls)
            {
                ct.Enabled = false;
            }
            foreach (Control ct in this.ggrbChucnang.Controls)
            {
                ct.Enabled = false;
            }
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

        private void gbtnthem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {
        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {

        }

        private void gbtnsua_Click(object sender, EventArgs e)
        {

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

        private void gcboMaPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dgvDanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvDanhSachMuon.CurrentRow.Index;
            this.gtxtMasach.Text = this.dgvDanhSachMuon.Rows[index].Cells["MaSach"].Value.ToString();
            this.gtxtTenSach.Text = this.dgvDanhSachMuon.Rows[index].Cells["TenSach"].Value.ToString();
            this.gtxtSlMuon.Text = this.dgvDanhSachMuon.Rows[index].Cells["SoLuongMuon"].Value.ToString();
            this.cbDaTra.Checked = Convert.ToBoolean(this.dgvDanhSachMuon.Rows[index].Cells["DaTra"].Value);
            var phieuMuon = this.phieuMuonCtrl.FindByKey(this.gcboMaPhieuMuon.SelectedValue.ToString());
            int soNgayTre = (this.gdtpngaytra.Value - phieuMuon.NgayMuon).Days;
            float tienPhatMoiQuyen = 1000;
            int slMuon = int.Parse(this.gtxtSlMuon.Text);
            this.gtxtTienphat.Text = (soNgayTre * tienPhatMoiQuyen * slMuon).ToString();
        }

        private void dgvDanhSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gbtnTraSach_Click(object sender, EventArgs e)
        {
            if (this.phieuTra == null)
            {
                this.phieuTra = new Models.PhieuTras.PhieuTra
                {
                    MaPhieuTra = this.gtxtmaphieutra.Text,
                    MaPhieuMuon = this.gcboMaPhieuMuon.SelectedValue.ToString(),
                    NgayTra = this.gdtpngaytra.Value,

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
    }
}
