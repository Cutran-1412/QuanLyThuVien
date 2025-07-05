using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Controllers;
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
        private PhieuMuonController phieuMuonCtrl = new PhieuMuonController();
        private PhieuTraController phieuTraCtrl = new PhieuTraController();
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
