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
    public class BagcikReadRepository : ReadRepository<Bagcik>, IBagcikReadRepository
    {
        public BagcikReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
