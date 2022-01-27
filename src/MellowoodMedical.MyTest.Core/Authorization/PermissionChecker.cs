using Abp.Authorization;
using MellowoodMedical.MyTest.Authorization.Roles;
using MellowoodMedical.MyTest.Authorization.Users;

namespace MellowoodMedical.MyTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
