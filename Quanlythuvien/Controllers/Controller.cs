using Quanlythuvien.Models;
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
