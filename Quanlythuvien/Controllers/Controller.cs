
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
        public virtual bool Update(T model)
        {
            return this.dao.Update(model);
        }
        public virtual bool DeleteByKey(string key)
        {
            return this.dao.Delete(key);
        }
    }
}