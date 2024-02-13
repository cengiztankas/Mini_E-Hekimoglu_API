using E_HekimogluAPI.Application.Repositories.RenkRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.RenkRepo
{
    public class RenkReadRepository : ReadRepository<Renk>, IRenkReadRepository
    {
        public RenkReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
