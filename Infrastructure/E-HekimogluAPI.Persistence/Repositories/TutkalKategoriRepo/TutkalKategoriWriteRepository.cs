using E_HekimogluAPI.Application.Repositories.TutkalKategoriRepo;
using E_HekimogluAPI.Domain.Entities.TutkalMalzemesi;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.TutkalKategoriRepo
{
    public class TutkalKategoriWriteRepository : WriteRepository<TutkalKategori>, ITutkalKategoriWriteRepository
    {
        public TutkalKategoriWriteRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
