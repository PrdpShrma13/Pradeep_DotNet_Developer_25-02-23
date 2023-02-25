using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Pradeep_DotNet_Developer.Authorization.Roles;
using Pradeep_DotNet_Developer.Authorization.Users;
using Pradeep_DotNet_Developer.MultiTenancy;

namespace Pradeep_DotNet_Developer.EntityFrameworkCore
{
    public class Pradeep_DotNet_DeveloperDbContext : AbpZeroDbContext<Tenant, Role, User, Pradeep_DotNet_DeveloperDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Country.Country> Countries { get; set; }
        public DbSet<State.State> states { get; set; }
        public Pradeep_DotNet_DeveloperDbContext(DbContextOptions<Pradeep_DotNet_DeveloperDbContext> options)
            : base(options)
        {
        }
    }
}
