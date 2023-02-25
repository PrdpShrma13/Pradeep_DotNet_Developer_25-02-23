using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Pradeep_DotNet_Developer.Authorization;
using Pradeep_DotNet_Developer.Authorization.Roles;
using Pradeep_DotNet_Developer.Authorization.Users;
using Pradeep_DotNet_Developer.Editions;
using Pradeep_DotNet_Developer.MultiTenancy;

namespace Pradeep_DotNet_Developer.Identity
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
