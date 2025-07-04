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

        private void timethoigian_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private bool siderbarExpand;
        private void timechuyen_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                fmenu.Width += siderbarExpand ? -3 : 3;
                if (fmenu.Width == fmenu.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    timechuyen.Stop();
                }
            }
            else
            {
                fmenu.Width += siderbarExpand ? -3 : 3;
                if (fmenu.Width == fmenu.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    timechuyen.Stop();
                }
            }
        }

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            timechuyen.Start();
        }

        private void ibtndocgia_Click(object sender, EventArgs e)
        {
            if(fmenu.Width == fmenu.MaximumSize.Width)
            {
                timechuyen.Start();
                Docgia myPanel = new Docgia();
                pamain.Controls.Add(myPanel);
            }
        }

    }
}
