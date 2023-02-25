using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Pradeep_DotNet_Developer.EntityFrameworkCore;
using Pradeep_DotNet_Developer.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Pradeep_DotNet_Developer.Web.Tests
{
    [DependsOn(
        typeof(Pradeep_DotNet_DeveloperWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Pradeep_DotNet_DeveloperWebTestModule : AbpModule
    {
        public Pradeep_DotNet_DeveloperWebTestModule(Pradeep_DotNet_DeveloperEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Pradeep_DotNet_DeveloperWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Pradeep_DotNet_DeveloperWebMvcModule).Assembly);
        }
    }
}