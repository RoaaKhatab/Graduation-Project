using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SchoolGuide3.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<Users> UserAccount { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<WishList> WishList { get; set; }

    }
}