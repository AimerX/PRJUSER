using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.Entities
{
    public class Role:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
