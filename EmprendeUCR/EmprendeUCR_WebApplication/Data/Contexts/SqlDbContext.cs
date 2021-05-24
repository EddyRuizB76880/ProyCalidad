using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Contexts
{
    public class SqlServerDbContext:DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
           : base(options)
        {
        }
            public DbSet<Province> Province { get; set; }
            public DbSet<District> District { get; set; }
            public DbSet<Canton> Canton { get; set; } 
            public DbSet<User> User { get; set; }
    }
}