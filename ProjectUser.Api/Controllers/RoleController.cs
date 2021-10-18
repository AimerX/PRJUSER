using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectUser.Services.Roles;
using ProjectUser.Services.Roles.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly ILogger<RoleService> _logger;
        public RoleController(IRoleService roleService, ILogger<RoleService> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRoleRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var returnValue = await _roleService.Create(request);
                if (returnValue == 0)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
