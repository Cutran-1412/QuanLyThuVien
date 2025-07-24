using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Metadata;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Views.ucFrom.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
namespace Quanlythuvien.Views.ucFrom.PhieuMuon
{
    public partial class ucPhieuMuonExtra : UserControl
    {
        private PhieuMuonController phieuMuonCtrl = new();
        private ChiTietPhieuMuonController ctPhieuMuonCtrl= new();
        private DocGiaController docGiaCtrl = new();
        private SachController sachCtrl = new();
        private Quanlythuvien.Models.PhieuMuons.PhieuMuon phieuMuon;
        private BindingList<ChiTietPhieuMuon> ctPhieuMuons = new();
        public ucPhieuMuonExtra(Models.PhieuMuons.PhieuMuon phieuMuon)
        {
            InitializeComponent();
            this.phieuMuon = phieuMuon;
            this.LoadMaDocGia();
            gdgvCtMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;

        }

        private void ucPhieuMuonExtra_Load(object sender, EventArgs e)
        {
            if (this.phieuMuon != null)
            {
                this.gtxtMaPhieu.Text = this.phieuMuon.MaPhieuMuon;
                this.gcboMaDG.SelectedValue = this.phieuMuon.MaDocGia;
                this.gdtpNgayMuon.Value = this.phieuMuon.NgayMuon;
                this.gdtpNgayHenTra.Value = this.phieuMuon.NgayPhaiTra;
                this.SetReadOnly();
                this.ctPhieuMuons = new BindingList<ChiTietPhieuMuon>(this.phieuMuon.ChiTietPhieuMuons);
                this.LoadSachMuon(true);
            }
            else
            {
                this.SinhMaPhieuMuon();
                this.LoadDtp();
                this.gdgvCtMuon.DataSource = this.ctPhieuMuons;
                this.LoadSachMuon(false);

            }

            this.LoadMaSach();
        }
        private void LoadDtp()
        {
            this.gdtpNgayMuon.Value = DateTime.Now;
            this.gdtpNgayHenTra.Value = DateTime.Now;
        }
        private void LoadMaSach()
        {
            this.gcboMaSach.DropDownHeight = this.gcboMaSach.ItemHeight * 5;
            this.gcboMaSach.DataSource = this.sachCtrl.GetData();
            this.gcboMaSach.DisplayMember = "MaSach";
            this.gcboMaSach.ValueMember = "MaSach";
            this.gcboMaSach.SelectedIndex = -1;
        }
        private void SetReadOnly()
        {
            this.gtxtMaPhieu.ReadOnly = true;
            this.gcboMaDG.Enabled = false;
            this.gdtpNgayMuon.Enabled = false;
            this.gdtpNgayHenTra.Enabled = false;
            foreach (Control ct in this.ggrbCnPhieuMuon.Controls)
            {
                ct.Enabled = false;
            }
            foreach (Control ct in this.ggrbCnChitiet.Controls)
            {
                ct.Enabled = false;
            }
            this.lblSoLuongMuon.Enabled = true;
            gbtnThoat.Enabled = true;
        }
        private void LoadSachMuon(bool isReadonly)
        {
            gdgvCtMuon.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            this.gdgvCtMuon.DataSource = this.ctPhieuMuons;
            this.gdgvCtMuon.Columns["MaSach"].FillWeight = 90;
            this.gdgvCtMuon.Columns["TenSach"].FillWeight = 150;
            this.gdgvCtMuon.Columns["SoLuongMuon"].FillWeight = 80;
            this.gdgvCtMuon.Columns["DaTra"].FillWeight = 65;
            this.gdgvCtMuon.Columns["MaPhieuMuon"].Visible = false;
            this.gdgvCtMuon.Columns["PhieuMuon"].Visible = false;
            this.gdgvCtMuon.Columns["Sach"].Visible = false;
            this.gdgvCtMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            if (!isReadonly)
            {
                this.gdgvCtMuon.Columns["DaTra"].Visible = false;
                DataGridViewButtonColumn colButton = new DataGridViewButtonColumn();
                colButton.Name = "btnXoa";                // Tên cột (dùng trong code)
                colButton.HeaderText = "Thao tác";       // Tiêu đề cột
                colButton.Text = "  Xóa  ";
                colButton.Width = 120;// Chữ hiển thị trên nút
                colButton.UseColumnTextForButtonValue = true; // Dùng text trên tất cả cell
                colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
                colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 204);
                colButton.FillWeight = 80;

                colButton.FlatStyle = FlatStyle.Flat; // Bắt buộc phải để Flat để đổi màu
                colButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 102);   // đỏ nhạt
                colButton.DefaultCellStyle.ForeColor = Color.White;                   // chữ trắng
                colButton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 180, 130); // khi chọn
                colButton.DefaultCellStyle.SelectionForeColor = Color.White;

                this.gdgvCtMuon.Columns.Add(colButton);
            }
            else
            {
                this.gdgvCtMuon.Columns["DaTra"].Visible = true;      
            }
        }
        private void ClearPhieuMuon()
        {
            this.gtxtMaPhieu.Text = string.Empty;
            this.gcboMaDG.SelectedItem = null;
            this.gdtpNgayMuon.Value = DateTime.Now;
            this.gdtpNgayHenTra.Value = DateTime.Now;

        }
        public void SinhMaPhieuMuon()
        {
            var phieuCuoi = this.phieuMuonCtrl.GetLast();
            int nextNumber = 1;
            if (phieuCuoi != null)
            {
                string numberPart = phieuCuoi.MaPhieuMuon.Substring(2);
                if (int.TryParse(numberPart, out nextNumber))
                {
                    nextNumber = nextNumber + 1;
                }
            }
            this.gtxtMaPhieu.Text = "PM" + nextNumber;
        }

        private void LoadMaDocGia()
        {
            this.gcboMaDG.DataSource = this.docGiaCtrl.Get_DocGia();
            this.gcboMaDG.DisplayMember = "MaDocGia";
            this.gcboMaDG.ValueMember = "MaDocGia";
            this.gcboMaDG.DropDownHeight = this.gcboMaDG.ItemHeight * 5;
            this.gcboMaDG.SelectedIndex = -1;
            

        }

        private void gbtnLuu_Click(object sender, EventArgs e)
        {
            if (!this.IsFilledAll()) return;
            var maDocGia = this.gcboMaDG.SelectedValue.ToString();
            var docGia = this.docGiaCtrl.Get_DocGia_Ma(maDocGia);
            int soLuongDaMuon = this.ctPhieuMuonCtrl.GetTongSoLuongDaMuon(maDocGia);
            int muonThem = 0;
            foreach (var ct in this.ctPhieuMuons)
            {
                muonThem += ct.SoLuongMuon;
            }
            if (soLuongDaMuon+muonThem> docGia.SoSachMuonToiDa)
            {
                // thông báo thêm thành công
                string text = $"Độc giả đã mượn {soLuongDaMuon} quyển chỉ còn được mượn thêm {docGia.SoSachMuonToiDa-soLuongDaMuon} quyển !";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                
                return;
            }
            Quanlythuvien.Models.PhieuMuons.PhieuMuon phieuMuon = new Models.PhieuMuons.PhieuMuon()
            {
                MaPhieuMuon = this.gtxtMaPhieu.Text,
                MaDocGia = this.gcboMaDG.SelectedValue.ToString(),
                NgayMuon = this.gdtpNgayMuon.Value.Date,
                NgayPhaiTra = this.gdtpNgayHenTra.Value.Date,
                ChiTietPhieuMuons = this.ctPhieuMuons.ToList(),
            };
            if (this.phieuMuonCtrl.Insert(phieuMuon))
            {
                // thông báo thêm thành công
                string text = "Đã thêm phiếu mượn thành công";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                if (TopLevelControl is frmMain main)
                {
                    main.ShowControl(new ucPhieuMuon());
                }
            }
        }
        private bool IsFilledAll()
        {
            if (this.gcboMaDG.SelectedValue == null)
            {
                string text = "Vui lòng chọn mã độc giả";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                return false;
            }
            if (this.ctPhieuMuons == null || this.ctPhieuMuons.Count == 0)
            {
                string text = "Chưa có sách nào được chọn";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Information;
                new frmMain().Msgbox(text, caption, button, icon);
                return false;
            }
            return true;
        }
        private void gbtnThemSach_Click(object sender, EventArgs e)
        {
            int soLuongMuon;

            if (!new frmMain().Check_Null(gtxtSoLuongMuon, "Vui lòng nhập số lượng"))
            {
                return;
            }
            if (!int.TryParse(this.gtxtSoLuongMuon.Text, out soLuongMuon) || soLuongMuon <= 0)
            {
                string text = "Vui lòng nhập số lượng là số nguyên dương";
                string caption = "Thông báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Error;
                new frmMain().Msgbox(text, caption, button, icon);
                return;
            }
        

            int slTonKho = this.GetSoLuongTonKho(this.gcboMaSach.SelectedValue.ToString());
            if (soLuongMuon > slTonKho)
            {
                if(slTonKho==0)
                {
                    string text = "Sách đã hết không thể thêm";
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Warning;
                    new frmMain().Msgbox(text, caption, button, icon);
                }
                else
                {
                    string text = "Số lượng sách mượn vượt quá sách còn lại ";
                    string caption = "Thông báo";
                    MessageDialogButtons button = MessageDialogButtons.OK;
                    MessageDialogIcon icon = MessageDialogIcon.Warning;
                    new frmMain().Msgbox(text, caption, button, icon);
                }
                 return;
            }
            var sach = this.sachCtrl.FindByKey(this.gcboMaSach.SelectedValue.ToString());
           
            ChiTietPhieuMuon ctPhieuMuon = new ChiTietPhieuMuon
            {
                MaPhieuMuon = this.gtxtMaPhieu.Text,
                MaSach = this.gcboMaSach.SelectedValue.ToString(),
                SoLuongMuon = soLuongMuon,
                Sach = sach
            };
            var sa = ctPhieuMuon.MaSach;
            bool isContained = false;
            foreach (var ct in this.ctPhieuMuons)
            {
                if (!ct.MaPhieuMuon.Equals(ctPhieuMuon.MaPhieuMuon) || !ct.MaSach.Equals(ctPhieuMuon.MaSach)) continue;
                ct.SoLuongMuon += ctPhieuMuon.SoLuongMuon;
                isContained = true;

                break;
            }
            if (!isContained)
                this.ctPhieuMuons.Add(ctPhieuMuon);
            this.UpdateSoLuongTonKho();
            this.gdgvCtMuon.Refresh();

        }

        private void gbtnThoat_Click(object sender, EventArgs e)
        {
            if (TopLevelControl is frmMain main)
            {
                main.ShowControl(new ucPhieuMuon());
            }
        }

        private void gcboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSoLuongTonKho();
        }
        private void UpdateSoLuongTonKho()
        {

            glblsoluongcon.Visible = true;
            glblsoluongcon.Text = "Số lượng tồn kho :" + this.GetSoLuongTonKho(gcboMaSach.Text);

        }
        private int GetSoLuongTonKho(string maSach)
        {
            var sach = this.sachCtrl.FindByKey(gcboMaSach.Text);
            if (sach == null) return 0;
            int slCon = sach.SoLuong;
            if (this.phieuMuon == null)
            {
                foreach (var ct in this.ctPhieuMuons)
                {
                    if (ct.MaSach != sach.MaSach) continue;
                    slCon -= ct.SoLuongMuon;
                }
            }
           return slCon;
        }

        private void gdgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gdgvCtMuon.CurrentRow == null) return;
            int index = this.gdgvCtMuon.CurrentRow.Index;
            this.gcboMaSach.SelectedValue = this.gdgvCtMuon.Rows[index].Cells["MaSach"].Value;
            this.gtxtSoLuongMuon.Text = this.gdgvCtMuon.Rows[index].Cells["SoLuongMuon"].Value.ToString();
            if (this.gdgvCtMuon.Columns["btnXoa"] != null && e.ColumnIndex == this.gdgvCtMuon.Columns["btnXoa"].Index)
            {
                this.ctPhieuMuons.RemoveAt(e.RowIndex);
                this.UpdateSoLuongTonKho();
            }
        }

        private void ggrbCnChitiet_Click(object sender, EventArgs e)
        {

        }

        private void gdgvCtMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void gbtnXoa_Click(object sender, EventArgs e)
        {
            if (this.gdgvCtMuon.CurrentRow == null) return;
            int index = this.gdgvCtMuon.CurrentRow.Index;
            string maSach = this.gdgvCtMuon.Rows[index].Cells["MaSach"].Value.ToString();
            foreach (var ct in this.ctPhieuMuons)
            {
                if (ct.MaSach != maSach) continue;
                ctPhieuMuons.Remove(ct);
                break;
            }
        }

        private void gtxtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
