using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
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
    public partial class ucPhieuTra : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new();
        private PhieuTraController phieuTraCtrl = new();
        public ucPhieuTra()
        {
            InitializeComponent();
            gdgvPhieuTra.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.LoadCboTimKiem(this.phieuMuonCtrl.GetData());
        }
     
        private void LoadDSPhieuTra(List<Models.PhieuTras.PhieuTra> pts)
        {
            if (pts == null) return;
            this.gdgvPhieuTra.DataSource = pts;
            gdgvPhieuTra.Columns["PhieuMuon"].Visible = false;
        }
        private void ucPhieuTra_Load(object sender, EventArgs e)
        {
            LoadDSPhieuTra(this.phieuTraCtrl.GetData());
          
        }
        private void LoadCboTimKiem(List<Models.PhieuMuons.PhieuMuon> pms)
        {
            pms.Insert(0,new Models.PhieuMuons.PhieuMuon { MaPhieuMuon = "Tất cả" });
            this.gcboTimKiem.DropDownHeight = this.gcboTimKiem.ItemHeight*5;
            this.gcboTimKiem.DataSource = pms;  
            this.gcboTimKiem.DisplayMember = "MaPhieuMuon";
            this.gcboTimKiem.ValueMember = "MaPhieuMuon";
            
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            if (this.gdgvPhieuTra.CurrentRow == null) return;
            int row = this.gdgvPhieuTra.CurrentRow.Index;

            string maPhieu = this.gdgvPhieuTra.Rows[row].Cells[0].Value.ToString();
            Quanlythuvien.Models.PhieuTras.PhieuTra phieutra = this.phieuTraCtrl.FindByKey(maPhieu);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTraExtra(phieutra));
            }
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTraExtra(null));
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            if (this.gdgvPhieuTra.CurrentRow == null) return;
            int row = this.gdgvPhieuTra.CurrentRow.Index;
            var maPhieu = this.gdgvPhieuTra.Rows[row].Cells["MaPhieuTra"].Value.ToString();
            string text = "Bạn chắc chắn muốn xóa piếu trả " + maPhieu + " ?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (new frmMain().Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                if (this.phieuTraCtrl.DeleteByKey(maPhieu))
                {
                    string text1 = $"Đã xóa phiếu trả {maPhieu} thành công";
                    string caption1 = "Cảnh báo";
                    MessageDialogButtons button1 = MessageDialogButtons.OK;
                    MessageDialogIcon icon1 = MessageDialogIcon.Information;
                    new frmMain().Msgbox(text1, caption1, button1, icon1);
                    this.LoadDSPhieuTra(this.phieuTraCtrl.GetData());
                }
            }
        }

        private void gbtntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void gcboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.gcboTimKiem.DataSource == null) return;
            var maPhieuMuon = this.gcboTimKiem.SelectedValue;
            this.LoadDSPhieuTra(this.phieuTraCtrl.Search("MaPhieuMuon",maPhieuMuon.ToString()));
        }
    }
}
