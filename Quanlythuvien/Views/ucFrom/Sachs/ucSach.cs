using Guna.UI2.WinForms;
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
        private SachController sachCtrl = new SachController();
        public ucSach()
        {
            InitializeComponent();
            dtsach.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.LoadSach(this.sachCtrl.GetData());
        }
        private void LoadSach(List<Sach> sachs)
        {

            this.dtsach.DataSource = sachs;
            if (sachs == null) return;
            this.dtsach.Columns[2].Visible = false;
            this.dtsach.Columns[6].Visible = false;
            this.dtsach.Columns[7].Visible = false;
        }

        private void gbtnThongtin_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            Sach sach = this.sachCtrl.FindByKey(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(sach,0));
            }
        }

        private void gbtnthem_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(null,1)); ;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gbtnsua_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            Sach sach = this.sachCtrl.FindByKey(ma);
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucSachExtra(sach,-1));
            }
        }

        private void gbtnxoa_Click(object sender, EventArgs e)
        {
            int row = this.dtsach.CurrentRow.Index;
            string ma = this.dtsach.Rows[row].Cells[0].Value.ToString();
            string text = "Bạn chắc chắn muốn xóa sách có mã " + ma + " ?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (new frmMain().Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                string text1 = "Xóa thành công sách có mã " + ma;
                string caption1 = "Thông báo";
                MessageDialogButtons button1 = MessageDialogButtons.OK;
                MessageDialogIcon icon1 = MessageDialogIcon.Information;
                new frmMain().Msgbox(text1, caption1, button1, icon1);
                this.sachCtrl.DeleteByKey(ma);
                this.LoadSach(this.sachCtrl.GetData());
            }   
        }

        private void gtxttim_TextChanged(object sender, EventArgs e)
        {
            int luachon = this.gcboLuachon.SelectedIndex;
            if (luachon == -1)
            {
                return;
            }
            this.LoadSach(this.sachCtrl.Search(this.gcboLuachon.Items[luachon].ToString(), gtxttim.Text.Trim()));
        }
    }
}
