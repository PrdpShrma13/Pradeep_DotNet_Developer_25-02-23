using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Pradeep_DotNet_Developer.Authorization.Roles;
using Pradeep_DotNet_Developer.Authorization.Users;
using Pradeep_DotNet_Developer.Configuration;
using Pradeep_DotNet_Developer.Localization;
using Pradeep_DotNet_Developer.MultiTenancy;
using Pradeep_DotNet_Developer.Timing;

namespace Pradeep_DotNet_Developer
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Pradeep_DotNet_DeveloperCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Pradeep_DotNet_DeveloperLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Pradeep_DotNet_DeveloperConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = Pradeep_DotNet_DeveloperConsts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = Pradeep_DotNet_DeveloperConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Pradeep_DotNet_DeveloperCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
