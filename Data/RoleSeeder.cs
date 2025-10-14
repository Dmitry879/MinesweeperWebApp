using Microsoft.AspNetCore.Identity;
using MinesweeperWebApp.Constants;

namespace MinesweeperWebApp.Data
{
    public class RoleSeeder
    {
        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (! await roleManager.RoleExistsAsync(Roles.Admin))
               await roleManager.CreateAsync(new IdentityRole(Roles.Admin));

            if (!await roleManager.RoleExistsAsync(Roles.Player))
                await roleManager.CreateAsync(new IdentityRole(Roles.Player));
        }
    }
}
