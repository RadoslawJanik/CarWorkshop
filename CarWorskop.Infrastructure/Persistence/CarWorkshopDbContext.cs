using Microsoft.EntityFrameworkCore;

namespace CarWorskop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : DbContext
            
       
    {

        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options) { }

        public DbSet<CarWorkshop.Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()

                .OwnsOne(c => c.ContactDetails);
        }

    }
}