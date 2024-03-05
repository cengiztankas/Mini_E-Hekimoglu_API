using E_HekimogluAPI.Application.Repositories.TabanKayitRepo;
using E_HekimogluAPI.Domain.Entities.Taban;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.TabanKayitRepo
{
    public class TabanKayitWriteRepository : WriteRepository<TabanKayıt>, ITabanKayitWriteRepository
    {
        public TabanKayitWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
