using System.Threading.Tasks;
using Abp.Application.Services;
using Pradeep_DotNet_Developer.Authorization.Accounts.Dto;

namespace Pradeep_DotNet_Developer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
