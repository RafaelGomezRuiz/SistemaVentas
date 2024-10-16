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
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
