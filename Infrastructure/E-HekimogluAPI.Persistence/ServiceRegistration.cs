using E_HekimogluAPI.Application.Repositories;
using E_HekimogluAPI.Application.Repositories.BedenRepo;
using E_HekimogluAPI.Application.Repositories.CategoryRepo;
using E_HekimogluAPI.Application.Repositories.CinsiyetRepo;
using E_HekimogluAPI.Application.Repositories.MarkaRepo;
using E_HekimogluAPI.Application.Repositories.MaterialRepo;
using E_HekimogluAPI.Application.Repositories.ProductRepo;
using E_HekimogluAPI.Application.Repositories.RenkRepo;
using E_HekimogluAPI.Persistence.Context;
using E_HekimogluAPI.Persistence.Repositories;
using E_HekimogluAPI.Persistence.Repositories.BedenRepo;
using E_HekimogluAPI.Persistence.Repositories.CategoryRepo;
using E_HekimogluAPI.Persistence.Repositories.CinsiyetRepo;
using E_HekimogluAPI.Persistence.Repositories.MarkaRepo;
using E_HekimogluAPI.Persistence.Repositories.MaterialRepo;
using E_HekimogluAPI.Persistence.Repositories.ProductRepo;
using E_HekimogluAPI.Persistence.Repositories.RenkRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EHekimogluApiDbContext>(option => option.UseMySql(Configuration.GetConnectionString, 
                ServerVersion.AutoDetect(Configuration.GetConnectionString)));

            services.AddScoped<IBedenReadRepository, BedenReadRepository>();
            services.AddScoped<IBedenWriteRepository, BedenWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICinsiyetReadRepository,CinsiyetReadRepository>();
            services.AddScoped<ICinsiyetWriteRepository,CinsiyetWriteRepository>();
            services.AddScoped<IMarkaReadRepository,MarkaReadRepository>();
            services.AddScoped<IMaterialWriteRepository, MaterialWriteRepository>();
            services.AddScoped<IMaterialReadRepository,MaterialReadRepository>();
            services.AddScoped<IMaterialWriteRepository,MaterialWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
            services.AddScoped<IRenkReadRepository,RenkReadRepository>();
            services.AddScoped<IRenkWriteRepository,RenkWriteRepository>();

        }
    }
}
