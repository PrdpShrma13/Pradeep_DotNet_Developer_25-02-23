using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pradeep_DotNet_Developer.Configuration;
using Pradeep_DotNet_Developer.Web;

namespace Pradeep_DotNet_Developer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Pradeep_DotNet_DeveloperDbContextFactory : IDesignTimeDbContextFactory<Pradeep_DotNet_DeveloperDbContext>
    {
        public Pradeep_DotNet_DeveloperDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Pradeep_DotNet_DeveloperDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Pradeep_DotNet_DeveloperDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Pradeep_DotNet_DeveloperConsts.ConnectionStringName));

            return new Pradeep_DotNet_DeveloperDbContext(builder.Options);
        }
    }
}
