using Quanlythuvien.Models.PhieuTras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    internal class PhieuTraController:Controller<PhieuTra>
    {
        public PhieuTraController()
        {
            this.dao = new PhieuTraDAO();
        }

    }
}
