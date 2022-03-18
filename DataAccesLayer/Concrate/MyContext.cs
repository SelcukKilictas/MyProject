using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrate
{
    public class MyContext:DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
           optionsBuilder.UseSqlServer("server=DESKTOP-9EHVTPP;database=MyProjectDb; integrated security=true;");
            
      }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Commnets { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }


    }
}
