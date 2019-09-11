using Abp.Authorization;
using abp.graphql-boilerplate.Authorization.Roles;
using abp.graphql-boilerplate.Authorization.Users;

namespace abp.graphql-boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
