
﻿using Quanlythuvien.Models;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
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
        public virtual List<T> Search(string luachon, string value)
        {
            return this.dao.Search(luachon, value);
        }
        public virtual T? GetLast()
        {
            return this.dao.GetLast();
        }
    }
}