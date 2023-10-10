using Core.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mohamed",
                    Email = "MohamdeHamdy@gmail.com",
                    UserName = "MohamdeHamdy@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Mohamed",
                        LastName = "Hamdy",
                        Street = "45 street",
                        City = "Raselbar",
                        State = "EG",
                        ZipCode = "71111"

                    }
                };
                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }

}