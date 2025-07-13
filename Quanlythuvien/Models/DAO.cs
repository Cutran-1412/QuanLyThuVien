
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    public abstract class DAO<T>
    {
        public abstract List<T> GetData();
        public abstract bool Insert(T model);
        public abstract bool Delete(string key);
        public abstract int GetCount();
        public abstract T FindByKey(string key);
        public virtual bool Update(T model)
        {
            return true;    
        }
        public virtual List<T> Search(string luachon,string value)
        {
            return null;
        }
        public virtual T? GetLast()
        {
            return default;
        }
    }
}
