using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryPattern.Business.Domain;

namespace RepositoryPattern.DataAccess.EntityConfigurations
{
    public class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired();

            builder.HasData(
                new Category { Id = 1, Name = "Kategori 1" },
                new Category { Id = 2, Name = "Kategori 2" },
                new Category { Id = 3, Name = "Kategori 3" },
                new Category { Id = 4, Name = "Kategori 4" }
                
                );
        }
    }
}
