using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class ReCapProjectcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapDB;Trusted_connection=true");


        } 
        public DbSet <Car> Car { get; set; }
        public DbSet<Color> color { get; set; }
        public DbSet<Brand>  Brand { get; set; }


    }
}
