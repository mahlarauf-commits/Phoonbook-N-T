using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace DAL.DataBase
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SOFT-3;Initial Catalog=mahla;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet <Contact> Contacts { get; set; }
    }
}
