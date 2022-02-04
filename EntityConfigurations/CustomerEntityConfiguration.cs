using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerAPI.EntityConfigurations {
   public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer> {
      public void Configure(EntityTypeBuilder<Customer> builder) {
         builder.ToTable("customers", "sales");
         builder.Property(x => x.CustomerId).HasColumnName("customer_id");
         builder.Property(x => x.FirstName).HasColumnName("first_name");
         builder.Property(x => x.LastName).HasColumnName("last_name");
         builder.Property(x => x.Phone).HasColumnName("phone");
         builder.Property(x => x.Email).HasColumnName("email");
         builder.Property(x => x.Street).HasColumnName("street");
         builder.Property(x => x.City).HasColumnName("city");
         builder.Property(x => x.State).HasColumnName("state");
         builder.Property(x => x.ZipCode).HasColumnName("zip_code");
         builder.HasKey(c => c.CustomerId);
      }
   }
}
