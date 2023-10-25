using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductID = 1, CategoryID = 2, ProductName = "Computer", Price = 12_700 },
                new Product() { ProductID = 2, CategoryID = 2, ProductName = "Phone", Price = 20_222 },
                new Product() { ProductID = 3, CategoryID = 2, ProductName = "Notebook", Price = 15_000 },
                new Product() { ProductID = 4, CategoryID = 3, ProductName = "Adidas", Price = 100 },
                new Product() { ProductID = 5, CategoryID = 1, ProductName = "Envar Paşa Hatıraları", Price = 120 }
            );
        }
    }
}