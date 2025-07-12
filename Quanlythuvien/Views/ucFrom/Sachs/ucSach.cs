using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Views.ucFrom.DocGias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views.ucFrom.Sachs
{
    public partial class ucSach : UserControl
    {
        private SachController sachController = new SachController();
        public ucSach()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.LoadSach();
        }
        private void LoadSach()
        {
            this.dtsach.DataSource = this.sachController.GetData();
            this.dtsach.Columns[2].Visible = false;
            this.dtsach.Columns[6].Visible = false;
            this.dtsach.Columns[7].Visible = false;
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            Sach sach = this.sachController.FindByKey(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(sach));
            }
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(null)); ;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gbtnsua_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            Sach sach = this.sachController.FindByKey(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(sach));
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            Sach sach = this.sachController.FindByKey(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(sach));
            }
        }
    }
}
