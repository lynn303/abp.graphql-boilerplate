using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using abp.graphql-boilerplate.Authorization;
using abp.graphql-boilerplate.Authorization.Roles;
using abp.graphql-boilerplate.Authorization.Users;
using abp.graphql-boilerplate.Editions;
using abp.graphql-boilerplate.MultiTenancy;

namespace abp.graphql-boilerplate.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
