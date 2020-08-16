using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniverSity.DataAccess.Data;
using UniverSity.Models;

namespace UniverSity.DataAccess.Intliazer
{
    public class DbInitializer : IDbIntializer
    {
        private  ApplicationDbContext _db;
        private  UserManager<IdentityUser> _userManager;
        private  RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public void Intialize()
        {
           
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }

            catch (Exception ex)
            {

            }

            if (_db.Roles.Any(r => r.Name == "User")) return;
            _roleManager.CreateAsync(new IdentityRole("User")).GetAwaiter().GetResult();
            _userManager.CreateAsync(new IdentityUser
            {
                Email = "Admin@gmail.com",
                EmailConfirmed = true,
                UserName = "Admin@gmail.com"

            }, "Admin@123").GetAwaiter().GetResult();
            _db.SaveChanges();


            Courses coure = new Courses()
            {
                Name = "Course1",
                Description = "sdasdasjdasjdasd"
            };
            _db.Courses.Add(coure);

            Courses course2 = new Courses()
            {
                Name = "Course1",
                Description = "sdasdasjdasjdasd"
            };
            _db.Courses.Add(coure);

          
            _db.SaveChanges();




        }
    }
}
