using Abp.Authorization;
using Learn_ABP.Authorization.Roles;
using Learn_ABP.Authorization.Users;

namespace Learn_ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
