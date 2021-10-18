using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectUser.Services.Roles.Dtos
{
    public class CreateRoleRequest
    {
        [Required(ErrorMessage = "BPNDT")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
