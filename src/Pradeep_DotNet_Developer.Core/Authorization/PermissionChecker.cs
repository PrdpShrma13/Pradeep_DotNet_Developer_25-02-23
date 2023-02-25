using Abp.Authorization;
using Pradeep_DotNet_Developer.Authorization.Roles;
using Pradeep_DotNet_Developer.Authorization.Users;

namespace Pradeep_DotNet_Developer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
