using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarWorskop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext :IdentityDbContext
            
       
    {

        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options) { }

        public DbSet<CarWorkshop.Domain.Entities.CarWorkshop> CarWorkshops { get; set; }
        public DbSet<CarWorkshop.Domain.Entities.CarWorkshopService> Services { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            SeedUsersAndRoles(modelBuilder);

            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()

                .OwnsOne(c => c.ContactDetails);

            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()
             .HasMany(c => c.Services)
             .WithOne(s => s.CarWorkshop)
             .HasForeignKey(s => s.CarWorkshopId);
        }

       private void SeedUsersAndRoles(ModelBuilder modelBuilder)
        {
            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Moderator", NormalizedName = "MODERATOR" },
                new IdentityRole { Id = "2", Name = "Owner", NormalizedName = "OWNER" }
            );
            var passwordHasher = new PasswordHasher<IdentityUser>();
            // Seed users
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "moderator@example.com",
                    NormalizedUserName = "MODERATOR@EXAMPLE.COM",
                    Email = "Moderator@example.com",
                    NormalizedEmail = "MODERATOR@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Test5%"),
                },
                new IdentityUser
                {
                    Id = "2",
                    UserName = "owner@example.com",
                    NormalizedUserName = "OWNER@EXAMPLE.COM",
                    Email = "owner@example.com",
                    NormalizedEmail = "OWNER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Test5%"),
                }
            );

            // Connect users to roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" }, // User 1 is a Moderator
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" }  // User 2 is an Owner
            );
        }




    }
}