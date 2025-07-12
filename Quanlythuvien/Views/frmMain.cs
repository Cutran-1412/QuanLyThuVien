using System;
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
using Quanlythuvien.Views.ucFrom.Sachs;

namespace Quanlythuvien.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timethoigian.Start();
            timechuyen.Interval = 15;

            CreateMarquee();
            timerChayChu.Interval = 20;
            timerChayChu.Tick += timerChayChu_Tick;
            timerChayChu.Start();

            timerdoimau.Interval = 300;
            timerdoimau.Tick += timerdoimau_Tick;
            timerdoimau.Start();
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
        private void timethoigian_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private bool siderbarExpand = true;


        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            timechuyen.Start();
            ShowControl(new ucMain());
        }

        private void ibtndocgia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pamain.Controls.Clear();
            ucAdmin myPanel = new ucAdmin();
            pamain.Controls.Add(myPanel);
        }
        public void ShowControl(UserControl uc)
        {
            pamain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pamain.Controls.Add(uc);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pamain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnSach_Click(object sender, EventArgs e)
        {
            ShowControl(new ucSach());
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            ShowControl(new ucPhieuMuon());
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
                Text = "Code by: Trần Xuân Cư - Hoàng Thanh Chiến - Nguyễn Qúy Cường",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = colors[0],
                Top = 5,
                Left = pcodeby.Width
            };

            pcodeby.Controls.Add(lblcodeby);
        }
        private void timerChayChu_Tick(object sender, EventArgs e)
        {
            lblcodeby.Left -= 2;

            if (lblcodeby.Right < 0)
            {
                lblcodeby.Left = pcodeby.Width;
            }
        }

        private void timerdoimau_Tick(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            lblcodeby.ForeColor = colors[colorIndex];
            lblchao.ForeColor = colors[colorIndex];
        }

        private void gbtnadmin_Click(object sender, EventArgs e)
        {
            if (fmenu.Width == fmenu.MaximumSize.Width)
            {
                timechuyen.Start();
                ShowControl(new ucAdmin());
            }
        }

        private void timechuyen_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                // Đang mở → thu nhỏ
                fmenu.Width -= 3;
                if (fmenu.Width <= fmenu.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    timechuyen.Stop();
                }
            }
            else
            {
                // Đang thu nhỏ → mở ra
                fmenu.Width += 3;
                if (fmenu.Width >= fmenu.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    timechuyen.Stop();
                }
            }
        }

        private void gbtndocgia_Click(object sender, EventArgs e)
        {
            if (fmenu.Width == fmenu.MaximumSize.Width)
            {
                timechuyen.Start();
                ShowControl(new ucDocgia());
            }
        }
    }
}
