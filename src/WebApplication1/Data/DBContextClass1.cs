using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
   public class DBContextClass1 : DbContext
    {
        public DBContextClass1(DbContextOptions<DBContextClass1> options)
            : base(options)
        {

        }
        //public DBContextClass1()
        // : base("name=DBContextClass1")
        //{
        //}
        //public DbSet<> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new Exception("error");
            //throw new UnintentionalCodeFirstException();
        }
    }
}
