using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Pradeep_DotNet_Developer.EntityFrameworkCore
{
    public static class Pradeep_DotNet_DeveloperDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Pradeep_DotNet_DeveloperDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Pradeep_DotNet_DeveloperDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
