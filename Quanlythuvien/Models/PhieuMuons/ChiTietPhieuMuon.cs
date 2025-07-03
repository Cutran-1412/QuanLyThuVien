using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.PhieuMuons
{
    internal class ChiTietPhieuMuon
    {
        public string Id { get; set; }
        public string PhieuMuonId { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        [ForeignKey(nameof(Sach))]
        public string MaSach{ get; set; }
        public Sach Sach { get; set; }
        public DateTime? NgayTra { get; set; }
    }
}
