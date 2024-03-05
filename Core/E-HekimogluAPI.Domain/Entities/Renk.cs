using E_HekimogluAPI.Domain.Entities.BagcikMalzemesi;
using E_HekimogluAPI.Domain.Entities.Common;
using E_HekimogluAPI.Domain.Entities.Kesimhane;
using E_HekimogluAPI.Domain.Entities.Taban;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities
{
    public class Renk:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string RenkKodu { get; set; }
        public bool? IsApproved { get; set; }
        public List<Product>? products { get; set; }
        public List<KesimMalzeme> RenkKesimMalzemes { get; set; }
        public List<TabanKayıt> TabanKayıts { get; set; }
        public List<Bagcik> Bagciks { get; set; }
    }
}
