using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Admins
{
    internal class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username phải từ 3 đến 50 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password không được để trống")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password phải từ 6 đến 100 ký tự")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
