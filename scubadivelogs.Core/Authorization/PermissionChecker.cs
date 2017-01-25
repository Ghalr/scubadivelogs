using Abp.Authorization;
using scubadivelogs.Authorization.Roles;
using scubadivelogs.MultiTenancy;
using scubadivelogs.Users;

namespace scubadivelogs.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
