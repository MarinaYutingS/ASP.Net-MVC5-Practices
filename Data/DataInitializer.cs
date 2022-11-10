using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace PetShop.Data
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //initialize roleStore and roleManager to create a new "Admin" role
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);

            var adminRole = new IdentityRole { Name = "Admin" };
            roleManager.Create(adminRole);

            //create a test user who is over 18 years old
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            ApplicationUser testUser = new ApplicationUser
            {
                UserName = "test@test.com",
                DateofBirth = new DateTime(2000, 1, 1)
            };
            userManager.Create(testUser, "test1234");
            userManager.AddToRole(testUser.Id, "Admin");

           /* //create a pet who does not have an owner
            context.Pets.Add(new Pet { petID = 1, Breed = "Dog", isMale = false, petName = "Alexy" });

            //create a pet who is owned by the test user
            context.Pets.Add(new Pet { petID = 2, Breed = "Cat", isMale = true, petName = "Caffe", Owner = testUser });
*/

            Pet pet1 = new Pet { petName = "Alexy", Breed = "Test Breed Dog", Owner = null, petAge = 2 };
            Pet pet2 = new Pet { petName = "Caffe", Breed = "Test Brreed Cat", Owner = testUser, petAge = 5 };

            context.Pets.Add(pet1);
            context.Pets.Add(pet2);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}