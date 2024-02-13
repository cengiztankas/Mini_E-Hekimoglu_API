using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities
{
    public class Material:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool? IsApproved { get; set; }
        public List<Product>? Products { get; set; }
    }
}
