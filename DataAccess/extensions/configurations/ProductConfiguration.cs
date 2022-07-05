using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.extensions.configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductObject>
    {
    public void Configure(EntityTypeBuilder<ProductObject> builder)
        {
            builder
                .Property(product => product.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(product => product.Weight)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(product => product.UnitPrice)
                .IsRequired();

            builder
                .Property(product => product.UnitInStock)
                .IsRequired();
        }
    }
}
