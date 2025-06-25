using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Login;

namespace Quanlythuvien.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=ADMIN-PC;Initial Catalog=Quanlythuvien;Integrated Security=True;Trust Server Certificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>().HasData(
                new Admin { id = 1, username = "Admin1", password = "2004"},
                new Admin { id = 2, username = "Admin2", password = "2004" },
                new Admin { id = 3, username = "Admin3", password = "2004" },
                new Admin { id = 4, username = "Admin4", password = "2004" },
                new Admin { id = 5, username = "Admin5", password = "2004" },
                new Admin { id = 6, username = "Admin6", password = "2004" },
                new Admin { id = 7, username = "Admin7", password = "2004" },
                new Admin { id = 8, username = "Admin8", password = "2004" },
                new Admin { id = 9, username = "Admin9", password = "2004" },
                new Admin { id = 10, username = "Admin110", password = "2004" }
            );
        }
    }
}
