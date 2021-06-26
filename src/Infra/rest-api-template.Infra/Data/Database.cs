using Microsoft.EntityFrameworkCore;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.Data
{
    public class Database : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public Database(DbContextOptions<Database> options) : base(options){ }
    }
}