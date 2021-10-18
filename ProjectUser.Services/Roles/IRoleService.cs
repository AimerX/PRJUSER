using ProjectUser.Services.Roles.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUser.Services.Roles
{
    public interface IRoleService
    {
        Task<int> Create(CreateRoleRequest request);
        Task<int> Update();
        Task<int> Delete();
        Task<int> GetAllPaging();
    }
}
