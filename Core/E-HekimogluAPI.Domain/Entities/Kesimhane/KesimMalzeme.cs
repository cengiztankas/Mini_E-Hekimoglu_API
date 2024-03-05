using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.Kesimhane
{
    public class KesimMalzeme : BaseEntity
    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Miktar { get; set; }
        public decimal GelisFiyat { get; set; }
        public decimal Gramaj { get; set; }
        public KesimKategori KesimKategori { get; set; }
        public Renk Renk { get; set; }
        public MalzemeRaf MalzemeRaf { get; set; }
    }
}
