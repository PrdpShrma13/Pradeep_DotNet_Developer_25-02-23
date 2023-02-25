using Abp.Application.Services;
using Abp.Domain.Repositories;
using Pradeep_DotNet_Developer.Roles.Dto;
using Pradeep_DotNet_Developer.States.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradeep_DotNet_Developer.States
{
    public class StateService : AsyncCrudAppService<State.State, StateDtos, Guid, PagedRoleResultRequestDto, AddStateDto, UpdateStateDto>, IStateService
    {
        public StateService(IRepository<State.State, Guid> repository) : base(repository)
        {
        }
    }
}
