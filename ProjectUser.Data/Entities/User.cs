using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Data.Entities
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Role Role { get; set; }
    }
}
