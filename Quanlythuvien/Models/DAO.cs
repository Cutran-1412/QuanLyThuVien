<<<<<<< HEAD
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
    }
}
=======
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
    }
}
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
