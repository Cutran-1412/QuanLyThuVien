<<<<<<< HEAD
﻿using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
=======
﻿using Quanlythuvien.Models.PhieuMuons;
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    internal class PhieuMuonController : Controller<PhieuMuon>
<<<<<<< HEAD
    {
       public PhieuMuonController() {
            this.dao = new PhieuMuonDAO();
        }

=======
    {
       public PhieuMuonController() {
            this.dao = new PhieuMuonDAO();
        }

        public override int GetCount()
        {
            return this.dao.GetCount();
        }

        public override List<PhieuMuon> GetData()
        {
            return this.dao.GetData();
        }
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
    }
}
