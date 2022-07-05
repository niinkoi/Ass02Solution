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
    public class MemberConfiguration : IEntityTypeConfiguration<MemberObject>
    {
        public void Configure(EntityTypeBuilder<MemberObject> builder)
        {
            builder
                .Property(member => member.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(member => member.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(member => member.City)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(member => member.Country)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(member => member.Password)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
