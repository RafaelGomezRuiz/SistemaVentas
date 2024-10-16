using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Infrastructure.Identity.Contexts;
using SistemaVentas.Infrastructure.Identity.Entities;
using SistemaVentas.Infrastructure.Identity.Seeds;
using SistemaVentas.Infrastructure.Identity.Seeds.Users;
using SistemaVentas.Infrastructure.Identity.Services;
using System.Reflection;
using SistemaVentas.Core.Application.Helpers;

namespace SistemaVentas.Infrastructure.Identity
{
    public static class ServiceRegistration
    {
        public static void AddIdentityDependencyWeb(this IServiceCollection services, IConfiguration configuration)
        {
            ContextConfiguration(services, configuration);
            ServiceConfiguration(services);

            #region Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication();
            #endregion
        }

        private static void ContextConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            #region Context
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IdentityContext>(options =>
                {
                    options.UseInMemoryDatabase("IdentityContextInMemory");
                });
            }
            else
            {
                string? connectionString = configuration.GetConnection("IdentityConnection");
                services.AddDbContext<IdentityContext>(options =>
                {
                    options.UseSqlServer(connectionString, a => a.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName));
                });
            }
            #endregion
        }

        private static void ServiceConfiguration(IServiceCollection services)
        {
            //service
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IAccountService, AccountService>();
        }

        public static async Task AddIdentitySeeds(this IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    await DefaultRoles.SeedAsync(roleManager);

                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    await DefaultSuperAdminUser.SeedAsync(userManager);
                }
                catch (Exception ex) { }
            }
        }
    }
}
