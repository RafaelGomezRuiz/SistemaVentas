using Microsoft.AspNetCore.Identity;
using StockApp.Core.Application.Enums;

namespace SistemaVentas.Infrastructure.Identity.Seeds
{
    public class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(EnumUserRoles.SUPERADMIN.ToString()));
            await roleManager.CreateAsync(new IdentityRole(EnumUserRoles.ADMIN.ToString()));
            await roleManager.CreateAsync(new IdentityRole(EnumUserRoles.BASIC.ToString()));
        }
    }
}
