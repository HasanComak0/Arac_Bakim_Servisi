using Microsoft.EntityFrameworkCore;

namespace KurtOtomotiv.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {

        }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
