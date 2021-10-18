using ProjectUser.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateDeleted { get; set; }
        public ActiveStatus Status { get; set; }
    }
}
