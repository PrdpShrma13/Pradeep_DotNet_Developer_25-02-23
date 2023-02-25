using System.Threading.Tasks;
using Abp.Application.Services;
using Pradeep_DotNet_Developer.Sessions.Dto;

namespace Pradeep_DotNet_Developer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
