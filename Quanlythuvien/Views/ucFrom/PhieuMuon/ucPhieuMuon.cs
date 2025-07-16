using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
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
            dgvPhieuMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
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
            gcobotim.DataSource = new DocGiaController().Get_DocGia();
            gcobotim.ValueMember = "MaDocGia";
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
            string text = "Bạn chắc chắn muốn xóa độc giả mã " + maPhieu + " ?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (new frmMain().Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                string text1 = "Đã xóa phiếu mượn thành công có mã : " + maPhieu;
                string caption1 = "Cảnh báo";
                MessageDialogButtons button1 = MessageDialogButtons.OK;
                MessageDialogIcon icon1 = MessageDialogIcon.Information;
                new frmMain().Msgbox(text1, caption1, button1, icon1);
                this.phieuMuonCtrl.DeleteByKey(maPhieu);
                this.LoadPhieuMuon();
            }
        }

        private void gbtnlaydulieu_Click(object sender, EventArgs e)
        {
            this.LoadPhieuMuon();
        }

        private void gbtntimkiem_Click(object sender, EventArgs e)
        {
            this.dgvPhieuMuon.DataSource = this.phieuMuonCtrl.Search("",gcobotim.Text);
            this.dgvPhieuMuon.Columns["DocGia"].Visible = false;
        }
    }
}