using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
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
        public string MaPhieuMuon { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        //Sách
        [ForeignKey(nameof(Sach))]
        public string MaSach{ get; set; }
        public Sach Sach { get; set; }
        //
        public int SoLuongMuon { get; set; }
        public int  SoLuongDaTra{ get; set; }
    }                                                   
}
