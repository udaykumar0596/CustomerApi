using CustomerAPI.EntityConfigurations;
using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Data {
   public class Context : DbContext {
      public Context(DbContextOptions<Context> options) : base(options) {
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {
         modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
      }

      public DbSet<Customer> Customers { get; set; }
   }
}
