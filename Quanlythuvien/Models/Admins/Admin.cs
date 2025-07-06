using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Admins
{
    internal class Admin
    {
        [Key]
<<<<<<< HEAD
        [Column("id")]
=======
        [DisplayName("Số thứ tự")]
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
        public int Id { get; set; }
        [Required]
        [DisplayName("Tài khoản")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
    }
}
