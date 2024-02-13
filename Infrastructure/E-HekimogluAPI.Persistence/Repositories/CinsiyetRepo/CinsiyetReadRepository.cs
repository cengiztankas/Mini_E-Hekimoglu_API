using E_HekimogluAPI.Application.Repositories.CinsiyetRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.CinsiyetRepo
{
    public class CinsiyetReadRepository : ReadRepository<Cinsiyet>, ICinsiyetReadRepository
    {
        public CinsiyetReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
