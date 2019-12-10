using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryPattern.Business.Domain;

namespace RepositoryPattern.DataAccess.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired();

            builder.HasData(
            new Product(){Id = 1,Name = "Ürün 1",CategoryId = 1},
            new Product(){Id = 2,Name = "Ürün 2",CategoryId = 2},
            new Product(){Id = 3,Name = "Ürün 3",CategoryId = 3},
            new Product(){Id = 4,Name = "Ürün 4",CategoryId = 4}
                );
        }
    }
}
