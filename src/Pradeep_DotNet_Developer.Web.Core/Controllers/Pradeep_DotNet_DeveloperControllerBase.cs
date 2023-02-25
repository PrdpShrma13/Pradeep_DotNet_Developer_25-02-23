using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Pradeep_DotNet_Developer.Controllers
{
    public abstract class Pradeep_DotNet_DeveloperControllerBase: AbpController
    {
        protected Pradeep_DotNet_DeveloperControllerBase()
        {
            LocalizationSourceName = Pradeep_DotNet_DeveloperConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
