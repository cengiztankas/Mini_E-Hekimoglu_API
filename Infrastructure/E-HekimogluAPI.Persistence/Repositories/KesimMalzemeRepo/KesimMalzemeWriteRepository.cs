using E_HekimogluAPI.Application.Repositories.KesimMalzemeRepo;
using E_HekimogluAPI.Domain.Entities.Kesimhane;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.KesimMalzemeRepo
{
    public class KesimMalzemeWriteRepository : WriteRepository<KesimMalzeme>, IKesimMalzemeWriteRepository
    {
        public KesimMalzemeWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
