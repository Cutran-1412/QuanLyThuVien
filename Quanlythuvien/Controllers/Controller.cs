<<<<<<< HEAD
﻿using Quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
 
    public abstract class Controller<T>
    {
        protected DAO<T> dao;
        public virtual List<T> GetData()
        {
            return this.dao.GetData();
        }
        public virtual int GetCount()
        {
            return this.dao.GetCount();
        }
        public virtual bool Insert(T model)
        {
            return this.dao.Insert(model);
        }
        public virtual T FindByKey(string key)
        {
            return this.dao.FindByKey(key);
        }
    }
}
=======
﻿using Quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
 
    public abstract class Controller<T>
    {
        protected DAO<T> dao;   
        public abstract List<T> GetData();
        public abstract int GetCount();
        
    }
}
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
