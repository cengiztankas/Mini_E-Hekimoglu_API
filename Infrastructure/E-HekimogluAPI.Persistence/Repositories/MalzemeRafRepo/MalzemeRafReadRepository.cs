﻿using E_HekimogluAPI.Application.Repositories.MalzemeRafRepo;
using E_HekimogluAPI.Domain.Entities.Kesimhane;
using E_HekimogluAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Repositories.MalzemeRafRepo
{
    public class MalzemeRafReadRepository : ReadRepository<MalzemeRaf>, IMalzemeRafReadRepository
    {
        public MalzemeRafReadRepository(EHekimogluApiDbContext context) : base(context)
        {
        }
    }
}
