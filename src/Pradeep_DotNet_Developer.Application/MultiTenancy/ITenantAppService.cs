using Abp.Application.Services;
using Pradeep_DotNet_Developer.MultiTenancy.Dto;

namespace Pradeep_DotNet_Developer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

