using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Pradeep_DotNet_Developer.MultiTenancy;

namespace Pradeep_DotNet_Developer.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
