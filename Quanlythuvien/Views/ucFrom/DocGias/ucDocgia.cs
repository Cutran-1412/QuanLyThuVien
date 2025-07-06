using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
        private readonly DocGiaController dg = new DocGiaController();

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
        public DocGia docgia = new DocGia();
        private void dtDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDocgia.SelectedRows.Count > 0)
            {
                docgia = dg.Get_DocGia_Ma(dtDocgia.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucDocgiaExtra(docgia));
            }
        }
    }
}
