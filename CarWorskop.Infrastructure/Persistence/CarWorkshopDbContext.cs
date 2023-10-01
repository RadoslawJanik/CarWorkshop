using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarWorskop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext :IdentityDbContext
            
       
    {

        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options) { }

        public DbSet<CarWorkshop.Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()

                .OwnsOne(c => c.ContactDetails);
        }

    }
}