using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Models;
using WebApplication03.Models.MyModels;
using WebApplication03.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EnquiryModel> EnquiryModels { get; set; }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
       
        base.OnModelCreating(builder);
        builder.Entity<EnquiryModel>().ToTable("EnquiryModel");
        
    }
        public DbSet<Studentss> Studentss { get; set; }
        public DbSet<Studentssss> Studentssss { get; set; }
    }
    public class Student  
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Studen
    {
       
        public string Name { get; set; }
    }
    public class Studentssss
    {
        [Key]
        public int Studentss { get; set; }
        public string Name { get; set; }
    }
    public class Studentss
    {
        public int StudentssID { get; set; }
        public string Name { get; set; }
    }
    public class Studentsst
    {
        public int UID { get; set; }
        public string Name { get; set; }
    }
}
