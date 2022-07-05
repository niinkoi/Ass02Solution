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
    public class OrderConfiguration : IEntityTypeConfiguration<OrderObject>
    {
        public void Configure(EntityTypeBuilder<OrderObject> builder)
        {
            builder
                .Property(order => order.OrderDate)
                .IsRequired();
        }
    }
}
