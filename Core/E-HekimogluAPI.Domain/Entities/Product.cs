using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? Description { get; set; }

        public int? Stock { get; set; }
        public double? OldPrice { get; set; }
        public decimal? Price{ get; set; }
        public int? SalesAmount { get; set; }

        public bool? IsHome { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsKargoBedava { get; set; }
        public bool? IsIndirimde { get; set; }

        //ilişki
        public Marka? Markas { get; set; }
        public List<Beden>? Bedens { get; set; }
        public  List<Material>? Materyals { get; set; }
        public List<Renk>? Renks { get; set; }
        public List<Category>? Categories { get; set; }
        public Cinsiyet? Cinsiyet { get; set; }

    }
}
