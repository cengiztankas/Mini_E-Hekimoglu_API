using E_HekimogluAPI.Domain.Entities.BagcikMalzemesi;
using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.BagcikMalzemesi
{
    public class Bagcik:BaseEntity
    {
        public string Barkod { get; set; }
        public string Adı { get; set; }
        public string Aciklama { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public BagcikKategori  BagcikKategori { get; set; }
        public Renk Renk { get; set; }
    }
}
