using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=IAGTY16;initial catalog=CoreProjeDB2;integrated security=True");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
