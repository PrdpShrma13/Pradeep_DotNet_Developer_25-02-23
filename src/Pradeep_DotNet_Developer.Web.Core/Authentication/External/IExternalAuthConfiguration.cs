using System.Collections.Generic;

namespace Pradeep_DotNet_Developer.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
