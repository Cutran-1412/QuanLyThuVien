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
        private PhieuTraController phieuMuonCtrl = new();
        private PhieuMuonController PhieuMuon = new();
        private SachController sachCtrl = new();
        private Quanlythuvien.Models.PhieuTras.PhieuTra phieutra;
        private BindingList<ChiTietPhieuTra> ctPhieuMuons = new();
        public ucPhieuTraExtra(Models.PhieuTras.PhieuTra phieutra)
        {
            InitializeComponent();
            this.phieutra = phieutra;
        }
        private void LoadMaPhieuMuon()
        {
            

        }
        private void ucPhieuTraExtra_Load(object sender, EventArgs e)
        {
            if (this.phieutra != null)
            {
                this.gtxtmaphieutra.Text = this.phieutra.MaPhieuTra;
                this.gcbomaphieumuon.SelectedValue = this.phieutra.MaPhieuMuon;
                this.gdtpngaytra.Value = this.phieutra.NgayTra;
                this.gtxttienphat.Text = this.phieutra.TienPhat.ToString();
                //this.SetReadOnly();
                //this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.phieuMuon.ChiTietPhieuMuons);
            }
            else
            {
                //this.SinhMaPhieuMuon();
                //this.LoadMaSach();
                //this.gdgvSach.DataSource = this.ctPhieuMuons;
            }
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTra());
            }
        }
    }
}
