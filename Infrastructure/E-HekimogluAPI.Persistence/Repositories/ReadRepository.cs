using E_HekimogluAPI.Application.Repositories;
using E_HekimogluAPI.Domain.Entities.Common;
using E_HekimogluAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
    {
        private readonly EHekimogluApiDbContext _context;
        public ReadRepository(EHekimogluApiDbContext context)
        {
            _context = context;   
        }
        
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }
    }
}
