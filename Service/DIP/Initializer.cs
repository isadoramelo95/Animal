using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Context;
using Service.Interface;
using Repository.Interfaces;

namespace Service.DIP
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AnimalContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IAnimalRepository<Animal>), typeof(AnimalRepository));
            services.AddScoped(typeof(IAnimalService<Animal>), typeof(AnimalService));
        }
    }
}
