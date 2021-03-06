using AllService.Domain;
using Microsoft.EntityFrameworkCore;





namespace AllService.Repository
{
    public class ApplicationDbContext: DbContext
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<DescriptionService> DescriptionsService { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
   
    
    }

}
