using E_HekimogluAPI.Application.Repositories.TabanKategoriRepo;
using E_HekimogluAPI.Domain.Entities.Taban;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.TabanKategoriRepo
{
    public class TabanKategoriReadRepository : ReadRepository<TabanKategori>, ITabanKategoriReadRepository
    {
        public TabanKategoriReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
