﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Models.DocGias;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Quanlythuvien.Models.PhieuTras;
using System.ComponentModel;

namespace Quanlythuvien.Models.PhieuMuons
{
    public class PhieuMuon : Model    
    {
        [Key]
        [Required, StringLength(12, MinimumLength = 3)]
        [DisplayName("Mã phiếu mượn")]
        public string MaPhieuMuon { get; set; }

        [ForeignKey(nameof(DocGia))]
        [DisplayName("Mã độc giả")]
        public string MaDocGia { get; set; } 
        public DocGia? DocGia { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayName("Ngày mượn")]
        public DateTime NgayMuon { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();
        
        public List<PhieuTra>? PhieuTras { get; set; }
        [DisplayName("Ngày hẹn trả")]
        public DateTime NgayPhaiTra { get; set; }
    }
}
