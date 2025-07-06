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
        //private bool siderbarExpand;
        //private void timechuyen_Tick(object sender, EventArgs e)
        //{
        //    if (siderbarExpand)
        //    {
        //        fmenu.Width += siderbarExpand ? -3 : 3;
        //        if (fmenu.Width == fmenu.MinimumSize.Width)
        //        {
        //            siderbarExpand = false;
        //            timechuyen.Stop();
        //        }
        //    }
        //    else
        //    {
        //        fmenu.Width += siderbarExpand ? -3 : 3;
        //        if (fmenu.Width == fmenu.MaximumSize.Width)
        //        {
        //            siderbarExpand = true;
        //            timechuyen.Stop();
        //        }
        //    }
        //}

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            timechuyen.Start();
            ucMain myPanel = new ucMain();
            pamain.Controls.Add(myPanel);
        }

        private void ibtndocgia_Click(object sender, EventArgs e)
        {
            //if(fmenu.Width == fmenu.MaximumSize.Width)
            //{
            //    timechuyen.Start();
            //    ucAdmin myPanel = new ucAdmin();
            //    pamain.Controls.Add(myPanel);
            //}
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
            ShowControl(new ucDocgia());
        }

        private void pamain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
