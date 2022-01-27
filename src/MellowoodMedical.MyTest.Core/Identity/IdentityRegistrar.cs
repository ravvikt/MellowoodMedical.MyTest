using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MellowoodMedical.MyTest.Authorization;
using MellowoodMedical.MyTest.Authorization.Roles;
using MellowoodMedical.MyTest.Authorization.Users;
using MellowoodMedical.MyTest.Editions;
using MellowoodMedical.MyTest.MultiTenancy;

namespace MellowoodMedical.MyTest.Identity
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
