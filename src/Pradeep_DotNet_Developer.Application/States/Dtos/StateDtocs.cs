using Abp.Application.Services.Dto;
using System;

namespace Pradeep_DotNet_Developer.States.Dtos
{
    public class StateDtos : EntityDto<Guid>
    {
        public string StateName { get; set; }
        public Guid CountryId { get; set; }
    }
}
