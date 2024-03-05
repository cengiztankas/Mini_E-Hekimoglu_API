using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.Taban
{
    public class TabanKategori:BaseEntity
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<TabanKayıt> TabanKayıts { get; set; }
    }
}
