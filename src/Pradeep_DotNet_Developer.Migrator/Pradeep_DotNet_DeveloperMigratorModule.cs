using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Pradeep_DotNet_Developer.Configuration;
using Pradeep_DotNet_Developer.EntityFrameworkCore;
using Pradeep_DotNet_Developer.Migrator.DependencyInjection;

namespace Pradeep_DotNet_Developer.Migrator
{
    [DependsOn(typeof(Pradeep_DotNet_DeveloperEntityFrameworkModule))]
    public class Pradeep_DotNet_DeveloperMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Pradeep_DotNet_DeveloperMigratorModule(Pradeep_DotNet_DeveloperEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Pradeep_DotNet_DeveloperMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Pradeep_DotNet_DeveloperConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Pradeep_DotNet_DeveloperMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
