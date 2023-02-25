using Abp.AutoMapper;
using Pradeep_DotNet_Developer.Authentication.External;

namespace Pradeep_DotNet_Developer.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
