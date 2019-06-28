using Identity_User_Framework.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_User_Framework.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context, 
                                    UserManager<ApplicationUser> userManager,
                                    RoleManager<ApplicationRole> roleManger)
        {
            //Ensure that databas is created
            context.Database.EnsureCreated();

            string adminId1 = "";
            string adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the member role";

            string password = "Nauman@123";

            if(await roleManger.FindByNameAsync(role1) == null)
            {
                // This is application role constructor
                await roleManger.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if(await roleManger.FindByNameAsync(role2) == null)
            {
                await roleManger.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }


            // Creating the user
            if(await userManager.FindByNameAsync("naumanm355@gmail.com") == null) ///if this is not then
            {   // then instantiate the user
                var user = new ApplicationUser
                {
                    UserName = "naumanm355@gmail.com",
                    Email = "naumanm355@gmail.com",
                    FirstName = "Nauman",
                    LastName = "Malik",
                    Street = "Street15",
                    City = "Lahore",
                    Province = "Punjab"
                };
                //create the user
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }


            // second user
            if(await userManager.FindByNameAsync("onlinework355@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "onlinework355@gmail.com",
                    Email = "onlinework355@gmail.com",
                    FirstName = "Shan",
                    LastName = "Khan",
                    Street = "Street16",
                    City = "Ali Pur",
                    Province = "Punjab",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

            // Third User
            if(await userManager.FindByNameAsync("usamazulfi@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "usamazulfi@gmail.com",
                    Email = "usamazulfi@gmail.com",
                    FirstName = "Usama",
                    LastName = "Zulfiqar",
                    Street = "street 12",
                    City = "Khanewal",
                    Province = "Punjab",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            // Fourth User
            if (await userManager.FindByNameAsync("numanuet@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "numanuet@gmail.com",
                    Email = "numanuet@gmail.com",
                    FirstName = "Usama",
                    LastName = "Zulfiqar",
                    Street = "street 12",
                    City = "Khanewal",
                    Province = "Punjab",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }

    }
}
