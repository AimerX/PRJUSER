using Microsoft.EntityFrameworkCore;
using ProjectUser.Common.Enums;
using ProjectUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.DataBaseContext
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Role1",
                    Description = "son test role 1",
                    Status = ActiveStatus.Active,
                    DateCreated = DateTime.Now
                },
                new Role()
                {
                    Id = 2,
                    Name = "Role2",
                    Description = "son test role 2",
                    Status = ActiveStatus.Active,
                    DateCreated = DateTime.Now
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "DHS",
                    UserName = "sondh13",
                    PassWord = "1234",
                    Status = ActiveStatus.Active,
                    DateCreated = DateTime.Now
                },
                new User()
                {
                    Id = 2,
                    Name = "DHS2",
                    UserName = "sondh13_2",
                    PassWord = "12345",
                    Status = ActiveStatus.Active,
                    DateCreated = DateTime.Now,
                }
                );

        }
    }
}
