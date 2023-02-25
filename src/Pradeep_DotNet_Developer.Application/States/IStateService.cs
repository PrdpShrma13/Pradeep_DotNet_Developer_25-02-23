using Abp.Application.Services;
using Pradeep_DotNet_Developer.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradeep_DotNet_Developer.States
{
    public interface IStateService : IAsyncCrudAppService<Dtos.StateDtos, Guid, PagedRoleResultRequestDto, Dtos.AddStateDto, Dtos.UpdateStateDto>
    {
    }
}
