using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Concrete.EntityFramework
{
   public class LibraryContextDb:DbContext
    {
        public LibraryContextDb():base(@"server=ASUS-PC\MSSQLSERVER01;database=LibraryDb;uid=admin;pwd=01031994;")
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}
