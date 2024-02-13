using E_HekimogluAPI.Application.Repositories.MaterialRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.MaterialRepo
{
    public class MaterialReadRepository : ReadRepository<Material>, IMaterialReadRepository
    {
        public MaterialReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
