using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Admins
{
    internal class Admin
    {
        [Key]
        [DisplayName("Số thứ tự")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Tài khoản")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
    }
}
