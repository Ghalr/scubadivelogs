using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using scubadivelogs.Authorization.Roles;
using scubadivelogs.Roles.Dto;

namespace scubadivelogs.Roles
{
    /* THIS IS JUST A SAMPLE. */
    public class RoleAppService : scubadivelogsAppServiceBase,IRoleAppService
    {
        private readonly RoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;

        public RoleAppService(RoleManager roleManager, IPermissionManager permissionManager)
        {
            _roleManager = roleManager;
            _permissionManager = permissionManager;
        }

        public async Task UpdateRolePermissions(UpdateRolePermissionsInput input)
        {
            var role = await _roleManager.GetRoleByIdAsync(input.RoleId);
            var grantedPermissions = _permissionManager
                .GetAllPermissions()
                .Where(p => input.GrantedPermissionNames.Contains(p.Name))
                .ToList();

            await _roleManager.SetGrantedPermissionsAsync(role, grantedPermissions);
        }
    }
}