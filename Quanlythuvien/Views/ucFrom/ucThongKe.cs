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
            glbldausach.Text = "Số lượng đầu sách :"+tkctr.Soluongdausach().ToString();
            glblsoluongsach.Text = "Số lượng sách :" + tkctr.Soluongsach().ToString();
            glbltongiatri.Text = "Tổng giá trị :" + tkctr.Tongtiensach().ToString();
            glblsoluongsachcon.Text = "Số lượng sách còn :" + tkctr.Soluongsachcon().ToString();
            glblsoluongsachcon.Text = "Số lượng sách còn :" + tkctr.Soluongsachcon().ToString();
            glblsoluongsachdangmuon.Text = "Số lượng sách đang mượn :" + tkctr.Soluongsachmuon().ToString();
            dtdsdangmuon.DataSource = tkctr.GetPhieuMuon();
            dtdsdangmuon.Columns["PhieuMuon"].Visible = false;
            dtdsdangmuon.Columns["Sach"].Visible = false;
            dtdsdangmuon.Columns["DaTra"].Visible = false;
            dtdsdangmuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private void Load_DocGia()
        {
            glbldocgia.Text = "Số lượng độc giả :" + tkctr.Soluongdocgia().ToString();
            glbltongphieudangmuon.Text = "Tổng phiếu đang mượn :" + tkctr.Soluongdocgiadangmuon().ToString();
            glbltongtien.Text = "Tổng tiền phạt :" + tkctr.Tongtienphat().ToString();
            glbltongtraquahan.Text = "Số lượng sách trả quá hạn :" + tkctr.Soluongquahan().ToString();
            dtsachquahan.DataSource = tkctr.GetPhieuTra();
            dtsachquahan.Columns["TenSach"].Visible = false;
            dtsachquahan.Columns["soLuongTra"].Visible = false;
            dtsachquahan.Columns["Sach"].Visible = false;
            dtsachquahan.Columns["PhieuTra"].Visible = false;
            dtsachquahan.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            Load_Sach();
            Load_DocGia();
        }
    }
}
