using Abp.MultiTenancy;
using Pradeep_DotNet_Developer.Authorization.Users;

namespace Pradeep_DotNet_Developer.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
