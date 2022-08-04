using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Concat.Concats
{
    public class CreateUpdateConcatDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string LastName { get; set; }

        [Required]
        public ConcatType Type { get; set; } = ConcatType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(11)]
        public string phone { get; set; }
    }
}
