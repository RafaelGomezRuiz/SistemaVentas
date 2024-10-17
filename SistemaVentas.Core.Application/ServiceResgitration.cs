using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.Services;
using System.Reflection;

namespace SistemaVentas.Infraestructure.Persistence
{
    public static class ServiceResgitration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //there are to especify the asembly
            //services.AddMediatR(Assembly.GetExecutingAssembly());

            #region Services
            //services.AddTransient(typeof(IGenericService<SaveViewModel, ViewModel>), typeof(GenericService<SaveViewModel, ViewModel>));
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IInventarioService, InventarioService>();
            services.AddTransient<IDireccionService, DireccionService>();
            services.AddTransient<ICarritoComprasService, CarritoComprasService>();
            services.AddTransient<IVentaService, VentaService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<ICategoryService, CategoriaService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
