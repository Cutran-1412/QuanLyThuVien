using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;
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
using System.Xml.Linq;

namespace Quanlythuvien.Views.ucFrom.PhieuTra
{
    public partial class ucPhieuTraExtra : UserControl
    {
        private PhieuTraController phieuTraCtrl = new();
        private PhieuMuonController phieuMuonCtrl = new();
        private ChiTietPhieuMuonController ctPhieuMuonCtrl = new();
        private ChiTietPhieuTraController ctPhieuTraCtrl = new();
        private SachController sachCtrl = new();
        private BindingList<ChiTietPhieuTra> ctPhieuTras = new();
        private BindingList<ChiTietPhieuMuon> ctPhieuMuons = new();
        private Quanlythuvien.Models.PhieuTras.PhieuTra phieuTra;
        public ucPhieuTraExtra(Models.PhieuTras.PhieuTra phieutra)
        {
            InitializeComponent();
            this.phieuTra = phieutra;


        }

        private void ucPhieuTraExtra_Load(object sender, EventArgs e)
        {


            if (this.phieuTra != null)
            {
                this.gtxtMaPhieuTra.Text = this.phieuTra.MaPhieuTra;
                this.gcboMaPhieuMuon.SelectedValue = this.phieuTra.MaPhieuMuon;
                this.gdtpNgaytra.Value = this.phieuTra.NgayTra;


                this.LoadMaPhieuMuon();
                this.SetReadOnly();

                this.ctPhieuTras = new BindingList<ChiTietPhieuTra>(this.phieuTra.ChiTietPhieuTras);

                this.LoadDanhSachTra(new BindingList<ChiTietPhieuTra>(this.ctPhieuTraCtrl.Search("Mã phiếu mượn", this.phieuTra.MaPhieuMuon)));

            }
            else
            {
                this.SinhMaPhieuTra();
                this.LoadMaPhieuMuonChuaTra();
                this.gdtpNgaytra.Value = DateTime.Now.Date;
                this.LoadDanhSachTra(this.ctPhieuTras);


            }

        }
        private void SetReadOnly()
        {
            foreach (Control ct in this.ggrbTtPhieuTra.Controls)
            {
                ct.Enabled = false;
            }
            this.gbtnTraSach.Enabled = false;
            gbtnThoat.Enabled = true;

        }
        private void LoadMaPhieuMuon()
        {
            this.gcboMaPhieuMuon.DataSource = this.phieuMuonCtrl.GetData();
            this.gcboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.ValueMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.SelectedValue = phieuTra.MaPhieuMuon;
            this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.ctPhieuMuonCtrl.Search("", this.gcboMaPhieuMuon.SelectedValue.ToString()));

        }
        private void LoadMaPhieuMuonChuaTra()
        {
            this.gcboMaPhieuMuon.DataSource = this.phieuMuonCtrl.GetPhieuMuonChuaTra();
            this.gcboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.ValueMember = "MaPhieuMuon";
            this.gcboMaPhieuMuon.SelectedIndex = -1;
            this.gcboMaPhieuMuon.DropDownHeight = this.gcboMaPhieuMuon.ItemHeight * 5;


        }
        public void SinhMaPhieuTra()
        {
            var phieuCuoi = this.phieuTraCtrl.GetLast();
            int nextNumber = 1;
            if (phieuCuoi != null)
            {
                string numberPart = phieuCuoi.MaPhieuTra.Substring(2);
                if (int.TryParse(numberPart, out nextNumber))
                {
                    nextNumber = nextNumber + 1;
                }
            }
            this.gtxtMaPhieuTra.Text = "PT" + nextNumber;
        }

        private void gbtnthoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTra());
            }
        }

        private void gcboMaPhieuMuon_SelectedValueChanged(object sender, EventArgs e)
        {

            if (gcboMaPhieuMuon.SelectedValue is string maPhieu)
            {
                var ctPhieuMuon = this.phieuMuonCtrl.FindByKey(maPhieu).ChiTietPhieuMuons;
                if (string.IsNullOrEmpty(maPhieu)) return;
                this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.ctPhieuMuonCtrl.Search("", this.gcboMaPhieuMuon.SelectedValue.ToString()));
                this.LoadDanhSachMuon(new BindingList<ChiTietPhieuMuon>(ctPhieuMuon));

            }
        }
        private void LoadDanhSachMuon(BindingList<ChiTietPhieuMuon> cts)
        {
            this.dgvDanhSachMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDanhSachMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dgvDanhSachMuon.AlternatingRowsDefaultCellStyle = new();
            this.ctPhieuMuons = cts;
            var dsChiTiet = cts;

            // Lọc chỉ lấy những cái chưa trả (DaTra == false)
            var dsChuaTra = dsChiTiet.Where(ct => ct.DaTra == false).ToList();

            // Gán datasource cho DataGridView
            if (this.phieuTra == null)
            {
                this.dgvDanhSachMuon.DataSource = dsChuaTra;
                this.dgvDanhSachMuon.Columns["DaTra"].Visible = false;
            }
            else
            {
                this.dgvDanhSachMuon.DataSource = dsChiTiet;
            }
            this.dgvDanhSachMuon.Columns["MaPhieuMuon"].Visible = false;
            this.dgvDanhSachMuon.Columns["PhieuMuon"].Visible = false;

            this.dgvDanhSachMuon.Columns["Sach"].Visible = false;

            DataGridViewButtonColumn colButton = new DataGridViewButtonColumn();
            colButton.Name = "btnThem";                // Tên cột (dùng trong code)
            colButton.HeaderText = "Thao tác";       // Tiêu đề cột
            colButton.Text = "  Thêm  ";
            colButton.Width = 100;// Chữ hiển thị trên nút
            colButton.UseColumnTextForButtonValue = true; // Dùng text trên tất cả cell
            colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
            colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 204);
            colButton.FillWeight = 80;

            colButton.FlatStyle = FlatStyle.Flat; // Bắt buộc phải để Flat để đổi màu
            colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 102);   // đỏ nhạt
            colButton.DefaultCellStyle.ForeColor = Color.White;                   // chữ trắng
            colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 180, 130); // khi chọn
            colButton.DefaultCellStyle.SelectionForeColor = Color.White;

            if (this.dgvDanhSachMuon.Columns["btnThem"] == null && this.phieuTra == null)
            {
                this.dgvDanhSachMuon.Columns.Add(colButton);

            }


        }
        private void LoadDanhSachTra(BindingList<ChiTietPhieuTra> cts)
        {
            this.gdgvDanhSachTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdgvDanhSachTra.AlternatingRowsDefaultCellStyle = null;
            this.gdgvDanhSachTra.DataSource = cts;
            this.gdgvDanhSachTra.Columns["MaPhieuTra"].Visible = false;
            this.gdgvDanhSachTra.Columns["PhieuTra"].Visible = false;
            this.gdgvDanhSachTra.Columns["Sach"].Visible = false;

            DataGridViewButtonColumn colButton = new DataGridViewButtonColumn();
            colButton.Name = "btnXoa";                // Tên cột (dùng trong code)
            colButton.HeaderText = "Thao tác";       // Tiêu đề cột
            colButton.Text = "  Xóa ";
            colButton.Width = 100;// Chữ hiển thị trên nút
            colButton.UseColumnTextForButtonValue = true; // Dùng text trên tất cả cell
            colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
            colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 204);
            colButton.FillWeight = 80;

            colButton.FlatStyle = FlatStyle.Flat; // Bắt buộc phải để Flat để đổi màu
            colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 102);   // đỏ nhạt
            colButton.DefaultCellStyle.ForeColor = Color.White;                   // chữ trắng
            colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 180, 130); // khi chọn
            colButton.DefaultCellStyle.SelectionForeColor = Color.White;

            if (this.gdgvDanhSachTra.Columns["btnXoa"] == null && this.phieuTra == null)
            {
                this.gdgvDanhSachTra.Columns.Add(colButton);

            }


        }

        private void dgvDanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSachMuon.CurrentRow == null) return;
            int index = this.dgvDanhSachMuon.CurrentRow.Index;
            if (this.dgvDanhSachMuon.Columns["btnThem"] != null && e.ColumnIndex == this.dgvDanhSachMuon.Columns["btnThem"].Index)
            {
                var sach = sachCtrl.FindByKey(this.dgvDanhSachMuon.Rows[index].Cells["MaSach"].Value.ToString());
                var phieuMuon = this.phieuMuonCtrl.FindByKey(this.gcboMaPhieuMuon.SelectedValue.ToString());
                int soNgayTre = (this.gdtpNgaytra.Value - phieuMuon.NgayPhaiTra).Days;
                if(soNgayTre <0) soNgayTre = 0;
                var ctPhieuTra = new ChiTietPhieuTra
                {
                    MaPhieuTra = this.gtxtMaPhieuTra.Text,
                    MaSach = this.dgvDanhSachMuon.Rows[index].Cells["MaSach"].Value.ToString(),
                    soLuongTra = Convert.ToInt32(this.dgvDanhSachMuon.Rows[index].Cells["SoLuongMuon"].Value.ToString()),
                    Sach = sach,
                    TienPhat = soNgayTre * 1000

                };

                var maSach = this.dgvDanhSachMuon.Rows[index].Cells["MaSach"].Value.ToString();
                var ct = this.ctPhieuMuons.Where(ct => ct.MaSach.Equals(maSach)).FirstOrDefault();

                foreach (var i in this.ctPhieuMuons)
                {
                    string ma = i.MaSach;
                    int a = 0;
                }
                this.ctPhieuMuons.Remove(ct);
                this.ctPhieuTras.Add(ctPhieuTra);
                this.LoadDanhSachMuon(this.ctPhieuMuons);

            }

        }

        private void gbtnTraSach_Click(object sender, EventArgs e)
        {
            if (this.gcboMaPhieuMuon.SelectedValue == null)
            {
                string text = "Vui lòng chọn phiếu mượn";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                return;
            }
            if (this.ctPhieuTras == null || this.ctPhieuTras.Count == 0)
            {
                string text = "Chưa có sách nào được chọn để trả";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                new frmMain().Msgbox(text, caption, button, icon);
                return;
            }
            this.phieuTra = new Models.PhieuTras.PhieuTra
            {
                MaPhieuTra = this.gtxtMaPhieuTra.Text,
                MaPhieuMuon = this.gcboMaPhieuMuon.SelectedValue.ToString(),
                NgayTra = this.gdtpNgaytra.Value,
                ChiTietPhieuTras = this.ctPhieuTras.ToList()
            };
            if (this.phieuTraCtrl.Insert(this.phieuTra))
            {
                string text = "Đã trả sách thành công";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                if (TopLevelControl is frmMain main)
                {
                    main.ShowControl(new ucPhieuTra());
                }
            }


        }

        private void gbtnThoat_Click_1(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuTra());
            }
        }

        private void dgvDanhSachMuon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvDanhSachMuon.ClearSelection();
            this.dgvDanhSachMuon.CurrentCell = null;
        }

        private void dgvDanhSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdgvDanhSachTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gdgvDanhSachTra.CurrentRow == null) return;
            int index = this.gdgvDanhSachTra.CurrentRow.Index;
            if (this.gdgvDanhSachTra.Columns["btnXoa"] != null && e.ColumnIndex == this.gdgvDanhSachTra.Columns["btnXoa"].Index)
            {
                var sach = sachCtrl.FindByKey(this.gdgvDanhSachTra.Rows[index].Cells["MaSach"].Value.ToString());
                var ctPhieuMuon = new ChiTietPhieuMuon
                {
                    MaPhieuMuon = this.gcboMaPhieuMuon.SelectedValue.ToString(),
                    MaSach = this.gdgvDanhSachTra.Rows[index].Cells["MaSach"].Value.ToString(),
                    Sach = sach,
                    SoLuongMuon = Convert.ToInt32(this.gdgvDanhSachTra.Rows[index].Cells["SoLuongTra"].Value.ToString()),

                };
                this.ctPhieuMuons.Add(ctPhieuMuon);
                var maSach = this.gdgvDanhSachTra.Rows[index].Cells["MaSach"].Value.ToString();
                var ct = this.ctPhieuTras.Where(ct => ct.MaSach == maSach).FirstOrDefault();

                this.ctPhieuTras.Remove(ct);
                this.LoadDanhSachMuon(this.ctPhieuMuons);
                this.LoadDanhSachTra(this.ctPhieuTras);
            }
        }

        private void gcboMaPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gcboMaPhieuMuon.SelectedValue is string maPhieu)
            {
                var ctPhieuMuon = this.phieuMuonCtrl.FindByKey(maPhieu).ChiTietPhieuMuons;
                if (string.IsNullOrEmpty(maPhieu)) return;
                this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.ctPhieuMuonCtrl.Search("", this.gcboMaPhieuMuon.SelectedValue.ToString()));
                this.LoadDanhSachMuon(new BindingList<ChiTietPhieuMuon>(ctPhieuMuon));

            }
            else
            {
                this.ctPhieuMuons.Clear();
                this.LoadDanhSachMuon(this.ctPhieuMuons);
            }
        }

        private void dgvDanhSachMuon_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
