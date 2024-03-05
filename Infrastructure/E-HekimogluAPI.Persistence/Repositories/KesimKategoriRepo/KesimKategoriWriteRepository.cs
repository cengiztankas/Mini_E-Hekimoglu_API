using E_HekimogluAPI.Application.Repositories.KesimKategoriRepo;
using E_HekimogluAPI.Domain.Entities.Kesimhane;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.KesimKategoriRepo
{
    public class KesimKategoriWriteRepository : WriteRepository<KesimKategori>, IKesimKategoriWriteRepository
    {
        public KesimKategoriWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
