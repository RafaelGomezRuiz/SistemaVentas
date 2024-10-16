using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.Core.Application.Helpers;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Infrastructure.Persistence.Contexts;
using SistemaVentas.Infrastructure.Persistence.Repositories;

namespace SistemaVentas.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Database
            if (configuration.GetValue<bool>("UseInMemmoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(
                    options => options.UseInMemoryDatabase("SistemaVentas"));
            }
            else
            {
                string? connectionString = configuration.GetConnection("SqlServerConnection");
                services.AddDbContext<ApplicationContext>(options =>
                    options.UseSqlServer(connectionString, assembly =>
                        assembly.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)
                ));
            }
            #endregion


            #region Repositories
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IInventarioRepository, InventarioRepository>();
            services.AddTransient<ICarritoCompraRepository, CarritoCompraRepository>();
            services.AddTransient<IVentaRepository, VentaRepository>();
            services.AddTransient<IDirecionRepository, DireccionRepository>();
            #endregion
        }
    }
}
