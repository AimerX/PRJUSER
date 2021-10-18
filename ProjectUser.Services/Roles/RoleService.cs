using ProjectUser.Common.Enums;
using ProjectUser.Data.DataBaseContext;
using ProjectUser.Data.Entities;
using ProjectUser.Services.Roles.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUser.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly DataContext _dataContext;
        public RoleService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<int> Create(CreateRoleRequest request)
        {
            var newRole = new Role()
            {
                DateCreated = DateTime.Now,
                Name = request.Name,
                Status = ActiveStatus.Active,
                Description = request.Description
            };
            _dataContext.Roles.Add(newRole);
            int returnValue = await _dataContext.SaveChangesAsync();
            return returnValue;
        }

        public Task<int> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetAllPaging()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update()
        {
            throw new NotImplementedException();
        }
    }
}
