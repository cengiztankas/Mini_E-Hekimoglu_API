using E_HekimogluAPI.Application.Repositories.KoliKategoriRepo;
using E_HekimogluAPI.Domain.Entities.KutuKoli;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.KoliKategoriRepo
{
    public class KoliKategoriReadRepository : ReadRepository<KoliKategori>, IKoliKategoriReadRepository
    {
        public KoliKategoriReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
