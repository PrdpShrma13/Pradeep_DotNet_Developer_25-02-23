using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradeep_DotNet_Developer.Country
{
    public class Country : FullAuditedEntity<Guid>
    {
        public string CountryName { get; set; }
        public ICollection<State.State> States { get; set; }

    }
}
