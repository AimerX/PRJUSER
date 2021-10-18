using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectUser.Common.Enums;
using ProjectUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().IsUnicode(true).HasMaxLength(20);
            builder.Property(p => p.UserName).IsRequired().IsUnicode(true).HasMaxLength(25);
            builder.Property(p => p.PassWord).IsRequired().IsUnicode(false);
            builder.Property(p => p.Status).IsRequired().HasDefaultValue(ActiveStatus.InActive);
            builder.Property(p => p.DateCreated).IsRequired();
            builder.HasOne(p => p.Role);
            //builder.Property(p => p.UpdateAt).IsRequired().HasDefaultValue(DateTime.Now);
            //builder.Property(p => p.DeleteAt).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
