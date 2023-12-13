using Day20_Sabrin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sabrin.MyDbContext
{
     class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-IFPCQQN\\MSSQLS ;Initial Catalog=Makeen_Day_21;Integrated Security=True;");
        }

     

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Projects> Project { get; set; }

    }
}
