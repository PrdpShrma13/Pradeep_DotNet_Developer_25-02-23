using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Pradeep_DotNet_Developer.Configuration.Dto;

namespace Pradeep_DotNet_Developer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Pradeep_DotNet_DeveloperAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
