using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Views.ucFrom.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views.ucFrom.PhieuMuon
{
    public partial class ucPhieuMuon : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new PhieuMuonController();
        public ucPhieuMuon()
        {
            InitializeComponent();
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuMuonExtra(null));
            }
        }

        private void ucPhieuMuon_Load(object sender, EventArgs e)
        {
            this.LoadPhieuMuon();
        }
        private void LoadPhieuMuon()
        {
            this.dgvPhieuMuon.DataSource = this.phieuMuonCtrl.GetData();
            this.dgvPhieuMuon.Columns["DocGia"].Visible = false;
        }
        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            if (this.dgvPhieuMuon.CurrentRow == null) return;
            int row = this.dgvPhieuMuon.CurrentRow.Index;
            string maPhieu = this.dgvPhieuMuon.Rows[row].Cells[0].Value.ToString();
            Quanlythuvien.Models.PhieuMuons.PhieuMuon phieuMuon = this.phieuMuonCtrl.FindByKey(maPhieu);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuMuonExtra(phieuMuon));
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            int row = this.dgvPhieuMuon.CurrentRow.Index;
            string maPhieu = this.dgvPhieuMuon.Rows[row].Cells[0].Value.ToString();
            if (this.phieuMuonCtrl.DeleteByKey(maPhieu))
            {

                string text = "Đã xóa phiếu mượn thành công";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                this.LoadPhieuMuon();
            }
        }
    }
}