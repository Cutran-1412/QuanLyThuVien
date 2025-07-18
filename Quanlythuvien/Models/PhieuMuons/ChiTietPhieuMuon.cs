using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.PhieuMuons
{
    public class ChiTietPhieuMuon : Model
    {


        //Phiếu mượn
        [ForeignKey(nameof(PhieuMuon))]
        [DisplayName("Mã phiếu mượn")]
        public string MaPhieuMuon { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        //Sách
        [ForeignKey(nameof(Sach))]
        [DisplayName("Mã sách")]
        public string MaSach{ get; set; }
        [NotMapped]
        [DisplayName("Tên sách")]
        public string TenSach => Sach != null ? Sach.TenSach : "";
        public Sach Sach { get; set; }
        //
        [DisplayName("Sl mượn")]
        public int SoLuongMuon { get; set; }
        [DisplayName("Đã trả")]
        public bool DaTra{ get; set; }
    }
}
