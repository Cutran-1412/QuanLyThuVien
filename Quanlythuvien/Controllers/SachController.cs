﻿using Quanlythuvien.Models.Sachs;
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
        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<Sach> GetData()
        {
            return this.dao.GetData();
        }
    }
}
