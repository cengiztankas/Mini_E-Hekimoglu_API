using E_HekimogluAPI.Application.Repositories.MarkaRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.MarkaRepo
{
    public class MarkaWriteRepository : WriteRepository<Marka>, IMarkaWriteRepository
    {
        public MarkaWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
