using Abp.Domain.Entities.Auditing;
using System;

namespace Pradeep_DotNet_Developer.State
{
    public class State : FullAuditedEntity<Guid>
    {
        public string StateName { get; set; }
        public Guid CountryId { get; set; }
        public Country.Country Country { get; set; }

    }
}
