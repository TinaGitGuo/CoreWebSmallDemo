using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication07to4.Models;

namespace WebApplication07to4.Data
{
    public class ApplicationDbContext2 : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options)
            : base(options)
        {
            
        }
        public DbSet<stur> sturs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
    public class stur
    {
       int id { get; set; }
    }
}
