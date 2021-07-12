using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            this.Database.Connection.ConnectionString = Properties.Settings.Default.MyConnectionString;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Error> Errors { get; set; }

    }
}