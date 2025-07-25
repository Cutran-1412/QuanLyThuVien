
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Models.Sachs
{
    internal class SachDAO : DAO<Sach>
    {
        public override bool Delete(string key)
        {
            using (DataContext context = new DataContext())
            {
                Sach sach= context.Sachs.Find(key);
                if(sach != null)
                {
                    context.Sachs.Remove(sach);
                    context.SaveChanges();
                    return true;
                }
                return false;
                
            }
        }

        public override Sach FindByKey(string key)
        {
            using (DataContext context = new DataContext())
            {
                return context.Sachs.Find(key);
            }
        }

        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<Sach> GetData()
        {
            using (DataContext context = new DataContext())
            {
                return context.Sachs.ToList();
            }
        }

        public override bool Insert(Sach model)
        {
            using (DataContext context = new DataContext())
            {
                context.Sachs.Add(model);
                context.SaveChanges();
                return true;
            }
        }   
        public override bool Update(Sach model)
        {
            using (DataContext context = new DataContext())
            {
                context.Sachs.Update(model);
                context.SaveChanges();
                return true;
            }
        }
        public override List<Sach> Search(string luachon, string value)
        {
            using(DataContext context = new DataContext())
            {
                switch(luachon)
                {
                    case "Mã sách":
                        return context.Sachs
                            .Where(s =>s.MaSach.ToLower().Contains(value.ToLower()))
                            .ToList();  
                    case "Tên sách":
                        return context.Sachs
                            .Where(s => s.TenSach.ToLower().Contains(value.ToLower()))
                            .ToList();

                    case "Nhà xuất bản":
                        return context.Sachs
                            .Where(s => s.NhaXuatBan.ToLower().Contains(value.ToLower()))
                            .ToList();
                        
                    case "Thể loại":
                        return context.Sachs
                            .Where(s => s.TheLoai.ToLower().Contains(value.ToLower()))
                            .ToList();
                    default: return null; 
                }
            }
        }
    }
}