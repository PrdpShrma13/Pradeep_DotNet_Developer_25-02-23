using Abp.Application.Services;
using Abp.Domain.Repositories;
using Pradeep_DotNet_Developer.Countries.Dtos;
using Pradeep_DotNet_Developer.Roles.Dto;
using System;

namespace Pradeep_DotNet_Developer.Countries
{
    public class CountryService : AsyncCrudAppService<Country.Country, CountryDto, Guid, PagedRoleResultRequestDto, AddCountryDto, UpdateCountryDto>, ICountryService
    {
        public CountryService(IRepository<Country.Country, Guid> repository) : base(repository)
        {
        }
    }
}
