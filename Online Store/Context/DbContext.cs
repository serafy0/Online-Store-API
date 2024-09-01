using Microsoft.EntityFrameworkCore;
using Online_Store.Entities;

namespace Online_Store.Context
{


    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test;ConnectRetryCount=0");
        }

        public DbSet<Product> Product { get; set; } = default!;

public DbSet<Online_Store.Entities.Order> Order { get; set; } = default!;

public DbSet<Online_Store.Entities.Customer> Customer { get; set; } = default!;


    }
}

