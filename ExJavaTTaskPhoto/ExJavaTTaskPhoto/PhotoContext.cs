using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExJavaTeam.Models;

namespace ExJavaTTaskPhoto
{
    public class PhotoContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}