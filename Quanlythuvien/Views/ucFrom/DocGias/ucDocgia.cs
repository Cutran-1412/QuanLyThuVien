using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Views.ucFrom.DocGias;

namespace Quanlythuvien.Views.ucFrom
{
    public partial class ucDocgia : UserControl
    {
        public ucDocgia()
        {
            InitializeComponent();
            Load_Bang();
        }
        private readonly DocGiaController dg = new DocGiaController();
        private void Load_Bang()
        {
            dtDocgia.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private void Load_Data()
        {
            dtDocgia.DataSource = dg.Get_DocGia();
            dtDocgia.Columns["SoDienThoai"].Visible = false;
            dtDocgia.Columns["Email"].Visible = false;
            dtDocgia.Columns["SoSachMuonToiDa"].Visible = false;
            dtDocgia.Columns["PhieuMuon"].Visible = false;   
        }
        private void ucDocgia_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            int row = this.dtDocgia.CurrentRow.Index;
            string ma = this.dtDocgia.Rows[row].Cells[0].Value.ToString();
            DocGia? docgia = dg.Get_DocGia_Ma(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucDocgiaExtra(docgia,0));
            }
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucDocgiaExtra(null,1));
            }
        }

        private void gbtnsua_Click(object sender, EventArgs e)
        {
            int row = this.dtDocgia.CurrentRow.Index;
            string ma = this.dtDocgia.Rows[row].Cells[0].Value.ToString();
            DocGia docgia = dg.Get_DocGia_Ma(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucDocgiaExtra(docgia,-1));
            }
        }

        private void gtxttim_TextChanged(object sender, EventArgs e)
        {
            dtDocgia.DataSource = dg.Search_Docgia(gcboluachon.Text, gtxttim.Text);
            dtDocgia.Columns["SoDienThoai"].Visible = false;
            dtDocgia.Columns["Email"].Visible = false;
            dtDocgia.Columns["SoSachMuonToiDa"].Visible = false;
            dtDocgia.Columns["PhieuMuon"].Visible = false;
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            int row = this.dtDocgia.CurrentRow.Index;
            string ma = this.dtDocgia.Rows[row].Cells[0].Value.ToString();
            string text = "Bạn chắc chắn muốn xóa độc giả mã " + ma +" ?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (new frmMain().Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                string text1 = "Xóa thành công độc giả có mã " + ma;
                string caption1 = "Cảnh báo";
                MessageDialogButtons button1 = MessageDialogButtons.OK;
                MessageDialogIcon icon1 = MessageDialogIcon.Information;
                new frmMain().Msgbox(text1, caption1, button1, icon1);
                dg.Delete_Docgia(ma);
                Load_Data();
            }  
        }
    }
}
