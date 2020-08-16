using UniverSity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UniverSity.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        {

        }


        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Courses>  Courses { get; set; }

        public DbSet<Cv> Cvs { get; set; }

        public DbSet<Publications> Publications { get; set; }

        public DbSet<OfficeHours> Officehours { get; set; }

        public DbSet<Post> Posts { get; set; }

         }
}
