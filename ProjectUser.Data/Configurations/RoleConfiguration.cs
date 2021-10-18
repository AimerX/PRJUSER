using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectUser.Common.Enums;
using ProjectUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Status).IsRequired().HasDefaultValue(ActiveStatus.InActive);
            builder.Property(p => p.DateCreated).IsRequired();
            
        }
    }
}
