using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;

namespace Quanlythuvien.Models.PhieuTras
{
<<<<<<< HEAD
    public class PhieuTra
=======
    public class PhieuTra :Model
>>>>>>> d7b609e91d416c009426a33e96e3610c3d612981
    {
        [Key]
        [Required, StringLength(12, MinimumLength = 3)]
        public string MaPhieuTra { get; set; }

        [ForeignKey(nameof(PhieuMuon))]
        public string MaPhieuMuon { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }

        [Range(0, double.MaxValue)] 
        public decimal TienPhat { get; set; }

    }
}
