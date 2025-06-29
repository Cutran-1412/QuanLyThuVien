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
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
