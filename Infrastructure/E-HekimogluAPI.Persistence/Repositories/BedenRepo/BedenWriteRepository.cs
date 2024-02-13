using E_HekimogluAPI.Application.Repositories.BedenRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.BedenRepo
{
    public class BedenWriteRepository : WriteRepository<Beden>, IBedenWriteRepository
    {
        public BedenWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
