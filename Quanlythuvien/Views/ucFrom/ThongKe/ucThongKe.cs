using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views.ucFrom.ThongKe
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
            grbngay.Checked = true;
            pngay.Visible = false;
            ptt.Visible = false;
        }
        private void grbngay_CheckedChanged(object sender, EventArgs e)
        {
            pngay.Visible = true;
            ptt.Visible = false;
        }

        private void gratuan_CheckedChanged(object sender, EventArgs e)
        {
            pngay.Visible = false;
            ptt.Visible = true;
        }

        private void grathang_CheckedChanged(object sender, EventArgs e)
        {
            pngay.Visible = false;
            ptt.Visible = true;
        }
    }
}
