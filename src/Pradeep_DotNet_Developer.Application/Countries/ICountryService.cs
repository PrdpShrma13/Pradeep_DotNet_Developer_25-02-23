using Abp.Application.Services;
using Pradeep_DotNet_Developer.Roles.Dto;
using System;

namespace Pradeep_DotNet_Developer.Countries
{
    public interface ICountryService : IAsyncCrudAppService<Dtos.CountryDto, Guid, PagedRoleResultRequestDto, Dtos.AddCountryDto, Dtos.UpdateCountryDto>
    {
        
    }
}
