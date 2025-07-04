using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Models;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Views
{
    public partial class PhieuTraControl : UserControl
    {
        public PhieuTraControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PhieuTraControl_Load(object sender, EventArgs e)
        {
            this.LoadPhieuMuon();
        }
        private void LoadPhieuMuon()
        {
            using (DataContext context = new DataContext())
            {
                List<PhieuMuon> pms = context.PhieuMuons.ToList();
                this.cboPhieuMuon.DataSource = pms;
                this.cboPhieuMuon.DisplayMember = "MaPhieuMuon";
                this.cboPhieuMuon.ValueMember = "MaPhieuMuon";

            }

        }


        private void cboPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhieuMuon = this.cboPhieuMuon.SelectedValue.ToString();
            this.LoadSach(maPhieuMuon);
        }
        private void LoadSach(string maPhieuMuon)
        {
            using (DataContext context = new DataContext())
            {
                PhieuMuon pm = context.PhieuMuons
                    .Include(ph => ph.ChiTietPhieuMuons)
                    .ThenInclude(ct => ct.Sach)
                    .FirstOrDefault(pm => pm.MaPhieuMuon.Equals(maPhieuMuon));

                if (pm != null)
                {
                    List<Sach> sachs = new List<Sach>();
                    foreach (ChiTietPhieuMuon ct in pm.ChiTietPhieuMuons)
                    {
                        sachs.Add(ct.Sach);
                    }

                    this.dgvSach.DataSource = sachs;
                }

            }
        }
    }
}
