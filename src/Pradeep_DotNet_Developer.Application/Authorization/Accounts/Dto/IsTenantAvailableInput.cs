using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Pradeep_DotNet_Developer.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
