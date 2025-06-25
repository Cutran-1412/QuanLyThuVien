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

namespace Quanlythuvien.Views.Login
{
    public partial class Adminshow : Form
    {
        public Adminshow()
        {
            InitializeComponent();
            dataadmin.CellFormatting += dataadmin_CellFormatting;
        }



        private void cboanhien_CheckedChanged(object sender, EventArgs e)
        {
            new LoginManagement().An_Hien(txtpass);
        }

        private void Adminshow_Load(object sender, EventArgs e)
        {
            new LoginManagement().Load_Admin(dataadmin);
        }

        private void dataadmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataadmin.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            new LoginManagement().Insert_Admin(txtuser, txtpass);
            new LoginManagement().Load_Admin(dataadmin);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            new LoginManagement().Update(txtuser, txtpass, dataadmin);
            new LoginManagement().Load_Admin(dataadmin);
        }

        private void dataadmin_SelectionChanged(object sender, EventArgs e)
        {
            new LoginManagement().Show_Details(txtma, txtuser, txtpass, dataadmin);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            new LoginManagement().Delete(dataadmin);
            new LoginManagement().Load_Admin(dataadmin);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
