using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Pradeep_DotNet_Developer.Authorization.Users;
using Pradeep_DotNet_Developer.Editions;

namespace Pradeep_DotNet_Developer.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
