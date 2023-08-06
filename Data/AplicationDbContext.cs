using auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace auth.Data
{
    public class AplicationDbContext : IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MovieDetail> MovieDetail { get; set; }
        public DbSet<ApplicationUsers> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieDetail>().HasData(
                new MovieDetail { Id = 1, MovieName = "Avenger End Game", Description = "the planet's first line of defense against the most powerful threats in the universe", Rating = 8, Url = "https://lumiere-a.akamaihd.net/v1/images/p_avengersendgame_19751_e14a0104.jpeg?region=0%2C0%2C540%2C810" }
                );
            modelBuilder.Entity<MovieDetail>().HasData(
               new MovieDetail { Id = 2, MovieName = "Harry Potter and the Philosopher's Stone", Description = "Harry Potter and the Philosopher's Stone (released in the United States and India as Harry Potter and the Sorcerer's Stone) is a 2001 fantasy film directed by Chris Columbus and produced by David Heyman, from a screenplay by Steve Kloves, based on the 1997 novel of the same name by J. K. Rowling.", Rating = 9, Url = "https://images.moviesanywhere.com/143cdb987186a1c8f94d4f18de211216/fdea56fa-2703-47c1-8da8-70fc5382e1ea.webp?h=375&resize=fit&w=250" }
               );
        }
    }
}
