using Microsoft.AspNetCore.Identity;
using SistemaVentas.Core.Application.Enums;
using SistemaVentas.Infrastructure.Identity.Entities;
using StockApp.Core.Application.Enums;

namespace SistemaVentas.Infrastructure.Identity.Seeds.Users
{
    public class DefaultSuperAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser defaultUser = new()
            {
                UserName = "SuperAdmin",
                Email = "SuperAdmin@gmail.com",
                FirstName = "admin",
                LastName = "admin",
                Status = (int)EnumUserStatus.ACTIVE,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "123Pa$$Word!");
                await userManager.AddToRoleAsync(defaultUser, EnumUserRoles.SUPERADMIN.ToString());
            }
        }
    }
}
