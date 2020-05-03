using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Invitor.Model.Data
{
    public class InvitorDbContextExtensions
    {
        public static void Seed(DbContext contect) { }
        public async static Task SeedRoles(RoleManager<IdentityRole> RoleMgr)
        {
            IdentityResult roleResult;
            string[] roleNames = { "Admin", "Student", "Docent" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleMgr.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleMgr.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
        public async static Task SeedUsers(UserManager<Person> userMgr) {
            
            var user = new Person()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Docent@MCT",
                Name = "docent",
                Email = "Docent@MCT"
            };
            var userExist = await userMgr.GetEmailAsync(user);
            if (userExist == null)
            {
                var userResult = await userMgr.CreateAsync(user, "Docent@1");
                var roleResult = await userMgr.AddToRoleAsync(user, "Admin");
                if (!userResult.Succeeded || !roleResult.Succeeded)
                {
                    throw new InvalidOperationException("Failed to build user and roles");
                }
            }
           
        }
    }
}
