﻿using E_HekimogluAPI.Application.Repositories.TutkalRepo;
using E_HekimogluAPI.Domain.Entities.TutkalMalzemesi;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.TutkalRepo
{
    public class TutkalReadRepository : ReadRepository<Tutkal>, ITutkalReadRepository
    {
        public TutkalReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
