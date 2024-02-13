using E_HekimogluAPI.Application.Repositories.CategoryRepo;
using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.CategoryRepo
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
