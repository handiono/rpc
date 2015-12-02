using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lybrary.Web.DataContexts
{
    public class LibraryDb : DbContext 
    {
        public LibraryDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}