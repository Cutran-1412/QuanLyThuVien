﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models.DocGias;
using Quanlythuvien.Views.ucFrom;
using Quanlythuvien.Views.ucFrom.PhieuMuon;
using Quanlythuvien.Views.ucFrom.PhieuTra;
using Quanlythuvien.Views.ucFrom.Sachs;
using Quanlythuvien.Views.ucFrom.ThongKe;

namespace Quanlythuvien.Views
{
    public partial class frmMain : Form
    {
        public bool check;
        public frmMain()
        {
            InitializeComponent();
        }
        Color[] colors = new Color[]
        {
        ColorTranslator.FromHtml("#F1C40F"), // vàng
        ColorTranslator.FromHtml("#1ABC9C"), // xanh ngọc
        ColorTranslator.FromHtml("#E74C3C"), // đỏ
        ColorTranslator.FromHtml("#9B59B6"), // tím
        ColorTranslator.FromHtml("#3498DB")  // xanh lam
        };
        int colorIndex = 0;
        private void CreateMarquee()
        {
            lblcodeby = new System.Windows.Forms.Label
            {
                Text = "Codeby: Trần Xuân Cư - Hoàng Thanh Chiến - Nguyễn Quý Cường",
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = colors[0],
                Top = 5,
                Left = pcodeby.Width
            };

            pcodeby.Controls.Add(lblcodeby);
        }
        private void timerdoimau_Tick(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            lblcodeby.ForeColor = colors[colorIndex];
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowControl(new ucMain());
            timethoigian.Start();
            CreateMarquee();
            timerChayChu.Interval = 20;
            timerChayChu.Tick += timerChayChu_Tick;
            timerChayChu.Start();

            timerdoimau.Interval = 1000;
            timerdoimau.Tick += timerdoimau_Tick;
            timerdoimau.Start();
            ibtnmuon.Visible = false;
            ibtntra.Visible = false;
            if (!this.check)
            {
                tbtnadmin.Visible = false;
            }
        }
        public DialogResult Msgbox(string text, string caption, MessageDialogButtons buttons, MessageDialogIcon icon)
        {
            var msg = new Guna2MessageDialog
            {
                Text = text,
                Caption = caption,
                Buttons = buttons,
                Icon = icon,
                Style = MessageDialogStyle.Light,
                Parent = this
            };
            return msg.Show();
        }
        public bool Check_Null(Guna2TextBox txtbox, string text)
        {
            if (string.IsNullOrEmpty(txtbox.Text))
            {
                string caption = "Cảnh báo";
                MessageDialogButtons button = MessageDialogButtons.OK;
                MessageDialogIcon icon = MessageDialogIcon.Warning;
                Msgbox(text, caption, button, icon);
                txtbox.Focus();
                return false;
            }
            return true;
        }
        private void timethoigian_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ShowControl(new ucMain());
        }
        public void ShowControl(UserControl uc)
        {
            pamain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pamain.Controls.Add(uc);
        }
        private void timerChayChu_Tick(object sender, EventArgs e)
        {
            lblcodeby.Left -= 2;

            if (lblcodeby.Right < 0)
            {
                lblcodeby.Left = pcodeby.Width;
            }
        }

        private void ibtnmuontra_Click(object sender, EventArgs e)
        {
            ibtnmuon.Visible = !ibtnmuon.Visible;
            ibtntra.Visible = !ibtntra.Visible;
        }
        private void ResetButtonColors()
        {
            Color defaultColor = Color.DodgerBlue;
            Color Colortext = Color.White;
            tbtnadmin.BackColor = defaultColor;
            tbtnadmin.ForeColor = Colortext;
            tbtnadmin.IconColor = Colortext;
            ibtndocgia.BackColor = defaultColor;
            ibtndocgia.ForeColor = Colortext;
            ibtndocgia.IconColor = Colortext;
            ibtnsach.BackColor = defaultColor;
            ibtnsach.ForeColor = Colortext;
            ibtnsach.IconColor = Colortext;
            ibtnmuon.BackColor = defaultColor;
            ibtnmuon.ForeColor = Colortext;
            ibtnmuon.IconColor = Colortext;
            ibtntra.BackColor = defaultColor;
            ibtntra.ForeColor = Colortext;
            ibtntra.IconColor = Colortext;
            ibtnthongke.BackColor = defaultColor;
            ibtnthongke.ForeColor = Colortext;
            ibtnthongke.IconColor = Colortext;

        }
        private void tbtnadmin_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            tbtnadmin.BackColor = Color.White;
            tbtnadmin.ForeColor = Color.Black;
            tbtnadmin.IconColor = Color.Black;
            ShowControl(new ucAdmin());
        }

        private void ibtndocgia_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ibtndocgia.BackColor = Color.White;
            ibtndocgia.ForeColor = Color.Black;
            ibtndocgia.IconColor = Color.Black;
            Thread.Sleep(500);
            ShowControl(new ucDocgia());
        }

        private void ibtnsach_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ibtnsach.BackColor = Color.White;
            ibtnsach.ForeColor = Color.Black;
            ibtnsach.IconColor = Color.Black;
            ShowControl(new ucSach());
        }

        private void ibtnmuon_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ibtnmuon.BackColor = Color.White;
            ibtnmuon.ForeColor = Color.Black;
            ibtnmuon.IconColor = Color.Black;
            ShowControl(new ucPhieuMuon());
        }

        private void ibtntra_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ibtntra.BackColor = Color.White;
            ibtntra.ForeColor = Color.Black;
            ibtntra.IconColor = Color.Black;
            ShowControl(new ucPhieuTra());
        }

        private void ibtnthongke_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ibtnthongke.BackColor = Color.White;
            ibtnthongke.ForeColor = Color.Black;
            ibtnthongke.IconColor = Color.Black;
            ShowControl(new ucThongKe());
        }

        private void ibtnthoat_Click(object sender, EventArgs e)
        {
            string text = "Bạn chắc chắn muốn đăng xuất?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                this.Visible = false;
                new frmLogin().Visible = true;
            }
        }

        private void pcodeby_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string text = "Bạn chắc chắn muốn thoát chương trình?";
            string caption = "Xác nhận";
            MessageDialogButtons button = MessageDialogButtons.OKCancel;
            MessageDialogIcon icon = MessageDialogIcon.Question;
            if (Msgbox(text, caption, button, icon) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
