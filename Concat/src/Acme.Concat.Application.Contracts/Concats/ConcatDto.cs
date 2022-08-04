using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Concat.Concats
{
    public class ConcatDto:AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public ConcatType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string phone { get; set; }
    }
}
