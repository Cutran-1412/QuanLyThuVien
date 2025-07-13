using Quanlythuvien.Controllers;
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
        public ucPhieuTra()
        {
            InitializeComponent();
        }
        private PhieuTraController phieuTraCtrl = new PhieuTraController();
        private void Load_Data()
        {
            this.dtphieutra.DataSource = phieuTraCtrl.GetData();
            dtphieutra.Columns["PhieuMuon"].Visible = false;
        }
        private void ucPhieuTra_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            int row = this.dtphieutra.CurrentRow.Index;
            string maPhieu = this.dtphieutra.Rows[row].Cells[0].Value.ToString();
            Quanlythuvien.Models.PhieuTras.PhieuTra phieutra = this.phieuTraCtrl.FindByKey(maPhieu);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTraExtra(phieutra));
            }
        }
    }
}
