using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.TutkalMalzemesi
{
    public class Tutkal:BaseEntity
    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public decimal Adet { get; set; }
        public string Gramaj { get; set; }
        public decimal fiyat { get; set; }

        public TutkalKategori  TutkalKategori { get; set; }
    }
}
