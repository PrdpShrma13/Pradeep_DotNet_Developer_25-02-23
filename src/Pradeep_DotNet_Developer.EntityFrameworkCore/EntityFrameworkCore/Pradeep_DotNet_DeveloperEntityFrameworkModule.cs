using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Pradeep_DotNet_Developer.EntityFrameworkCore.Seed;

namespace Pradeep_DotNet_Developer.EntityFrameworkCore
{
    [DependsOn(
        typeof(Pradeep_DotNet_DeveloperCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Pradeep_DotNet_DeveloperEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Pradeep_DotNet_DeveloperDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Pradeep_DotNet_DeveloperDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Pradeep_DotNet_DeveloperDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Pradeep_DotNet_DeveloperEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
