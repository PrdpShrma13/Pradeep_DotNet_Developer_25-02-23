using Abp.Application.Services.Dto;
using System;

namespace Pradeep_DotNet_Developer.Countries.Dtos
{
    public class CountryDto : EntityDto<Guid>
    {
        public string CountryName { get; set; }
    }
}
