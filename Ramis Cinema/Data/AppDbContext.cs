using Microsoft.EntityFrameworkCore;
using Ramis_Cinema.Models;

namespace Ramis_Cinema.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mB)
        {
            mB.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            mB.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies).HasForeignKey(m => m.MovieId) ;
            mB.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovies).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(mB);
        }

        public DbSet<Actor> Actors  { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Producer> Producers { get; set; }




    }
}
