using System.Threading.Tasks;
using Abp.Application.Services;
using scubadivelogs.Roles.Dto;

namespace scubadivelogs.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
