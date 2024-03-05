using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.Taban
{
    public class TabanKayıt:BaseEntity
    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        public int GelisFiyat { get; set; }
        public List<Renk> Renks { get; set; }
        public TabanKategori TabanKategori { get; set; }
    }
}
