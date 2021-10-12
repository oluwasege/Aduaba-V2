using Aduaba.Entities.Enums;
using Aduaba.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aduaba.Entities.Models;
using Aduaba.Core.Util;
using static Aduaba.Core.Util.Constants;

namespace Aduaba.Core.EFCore
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<ApplicationUser>userManager,RoleManager<IdentityRole>roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //Seed Default User
            var defaultAdmin = new ApplicationUser
            {
                UserName = Authorization.default_admin,
                Email = Authorization.default_admin_email,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var defaultUser = new ApplicationUser
            {
                UserName = Authorization.default_username,
                Email = Authorization.default_email,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            if(userManager.Users.All(x=>x.Id!=defaultAdmin.Id))
            {
                await userManager.CreateAsync(defaultAdmin, Authorization.default_admin_password);
                await userManager.AddToRoleAsync(defaultAdmin, Authorization.default_admin_role.ToString());
            }
            if (userManager.Users.All(x => x.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, Authorization.default_password);
                await userManager.AddToRoleAsync(defaultUser, Authorization.default_role.ToString());
            }
        }
    }
}
