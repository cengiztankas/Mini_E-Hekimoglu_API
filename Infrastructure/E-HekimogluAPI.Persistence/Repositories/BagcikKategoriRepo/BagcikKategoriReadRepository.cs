using E_HekimogluAPI.Application.Repositories.BagcikKategoriRepo;
using E_HekimogluAPI.Domain.Entities.BagcikMalzemesi;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.BagcikKategoriRepo
{
    public class BagcikKategoriReadRepository : ReadRepository<BagcikKategori>,IBagcikKategoriReadRepository
    {
        public BagcikKategoriReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
