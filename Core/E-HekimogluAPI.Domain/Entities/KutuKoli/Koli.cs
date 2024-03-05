using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.KutuKoli
{
    public class Koli:BaseEntity
    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Gramaj { get; set; }
        public KoliKategori KoliKategori { get; set; }
    }
}
