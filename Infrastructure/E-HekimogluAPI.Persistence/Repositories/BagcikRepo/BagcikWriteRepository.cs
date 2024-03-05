using E_HekimogluAPI.Application.Repositories.BagcikRepo;
using E_HekimogluAPI.Domain.Entities.BagcikMalzemesi;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.BagcikRepo
{
    public class BagcikWriteRepository : WriteRepository<Bagcik>, IBagcikWriteRepository
    {
        public BagcikWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
