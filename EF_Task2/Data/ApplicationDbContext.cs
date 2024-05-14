using EF_Task2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Users> users {  get; set; }
        public DbSet<Blog> blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=EF_Task2; trusted_connection=true; TrustServerCertificate=true");
        }
    }
}
