using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities.Kesimhane
{
    public class KesimKategori : BaseEntity
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<KesimMalzeme> KesimMalzemes { get; set; }
    }
}
