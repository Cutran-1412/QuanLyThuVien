using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    internal class SachController : Controller<Sach>
    {
        public SachController()
        {
            this.dao = new SachDAO();
        }
    }
}   
