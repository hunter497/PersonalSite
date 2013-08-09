using System;
using PersonalSite.Domain.Entities;
using System.Data.Entity;

namespace PersonalSite.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
