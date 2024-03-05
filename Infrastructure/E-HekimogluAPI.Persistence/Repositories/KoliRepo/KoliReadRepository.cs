using E_HekimogluAPI.Application.Repositories.KoliRepo;
using E_HekimogluAPI.Domain.Entities.KutuKoli;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.KoliRepo
{
    public class KoliReadRepository : ReadRepository<Koli>, IKoliReadRepository
    {
        public KoliReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
