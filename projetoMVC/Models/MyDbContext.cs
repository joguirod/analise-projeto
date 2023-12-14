using Microsoft.EntityFrameworkCore;

namespace projetoMVC.Models{
    public class MyDbContext : DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<SalesRecord> SalesRecords {get; set;}
        public DbSet<Seller> Seller {get; set;}
        public DbSet<Department> Department {get; set;}
    }
}