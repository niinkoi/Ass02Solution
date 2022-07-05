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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetailObject>
    {
        public void Configure(EntityTypeBuilder<OrderDetailObject> builder)
        {
            builder
                .Property(orderDetail => orderDetail.UnitPrice)
                .IsRequired();

            builder
                .Property(orderDetail => orderDetail.Quantity)
                .IsRequired();

            builder
                .Property(orderDetail => orderDetail.Discount)
                .IsRequired();
        }
    }
}
