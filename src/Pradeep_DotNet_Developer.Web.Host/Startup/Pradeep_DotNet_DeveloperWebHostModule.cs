using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Pradeep_DotNet_Developer.Configuration;

namespace Pradeep_DotNet_Developer.Web.Host.Startup
{
    [DependsOn(
       typeof(Pradeep_DotNet_DeveloperWebCoreModule))]
    public class Pradeep_DotNet_DeveloperWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Pradeep_DotNet_DeveloperWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Pradeep_DotNet_DeveloperWebHostModule).GetAssembly());
        }
    }
}
