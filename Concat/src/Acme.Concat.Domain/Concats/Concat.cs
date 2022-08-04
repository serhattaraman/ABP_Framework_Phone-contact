using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Concat.Concats
{
    public class Concat:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public ConcatType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string phone { get; set; }
    }
}
