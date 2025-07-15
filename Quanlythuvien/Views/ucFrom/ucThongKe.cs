using Quanlythuvien.Controllers;
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
        }
        private ThongKeController tkctr = new ThongKeController();
        private void Load_Sach()
        {
            gtxtslsach.Text = tkctr.Soluongdausach().ToString();
            gtxttslsach.Text = tkctr.Soluongsach().ToString();
            gtxtslsachmuon.Text = tkctr.Soluongsachmuon().ToString();
            gtxtslsachcon.Text = tkctr.Soluongsachcon().ToString();
            gtxttonggiatri.Text = tkctr.Tongtiensach().ToString();
        }
        private void Load_DocGia()
        {
            gtxtsldocgia.Text = tkctr.Soluongdocgia().ToString();
            gtxtsldgmuon.Text = tkctr.Soluongdocgiadangmuon().ToString();
            gtxttongtienphat.Text = tkctr.Tongtienphat().ToString();
            gtxttongtiendanop.Text = tkctr.Tongtienphat().ToString();
        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            Load_Sach();
            Load_DocGia();
        }
    }
}
