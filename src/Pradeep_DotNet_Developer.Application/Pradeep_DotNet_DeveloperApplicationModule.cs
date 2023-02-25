using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Pradeep_DotNet_Developer.Authorization;

namespace Pradeep_DotNet_Developer
{
    [DependsOn(
        typeof(Pradeep_DotNet_DeveloperCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Pradeep_DotNet_DeveloperApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Pradeep_DotNet_DeveloperAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Pradeep_DotNet_DeveloperApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
