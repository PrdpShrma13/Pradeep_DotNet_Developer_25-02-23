using System.Threading.Tasks;
using Pradeep_DotNet_Developer.Configuration.Dto;

namespace Pradeep_DotNet_Developer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
