using FunAtWork.Core.Repositories;
using FunAtWork.Infrastructure.FunAtWorkDb;
using FunAtWork.Infrastructure.Identity;
using FunAtWork.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FunAtWork.Infrastructure.Extensions
{
    public static class InfraServices
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Veritabanı bağlamını ekleyin
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("IdentityConnection")));

            // Identity hizmetlerini ekleyin
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<IdentityDbContext>()
                    .AddDefaultTokenProviders();

            // Genel repository arayüzünü ve implementasyonunu ekleyin
            services.AddScoped(typeof(IRepository<>), typeof(ApplicationDbBaseRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(IdentityDbBaseRepository<>));

            // Özel repository arayüzlerini ve implementasyonlarını ekleyin
            services.AddScoped<IContestRepository, ContestRepository>();

            // Diğer altyapı hizmetlerini burada ekleyebilirsiniz
            // Örneğin, cache, loglama, vb.

            return services;
        }
    }
}