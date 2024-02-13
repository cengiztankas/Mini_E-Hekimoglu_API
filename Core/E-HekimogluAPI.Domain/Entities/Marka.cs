using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities
{
    public class Marka:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool? IsHome { get; set; }
        public bool? IsApproved { get; set; }
        public List<Product>? products { get; set; }
    }
}
