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
    public class CinsiyetWriteRepository : WriteRepository<Cinsiyet>, ICinsiyetWriteRepository
    {
        public CinsiyetWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
