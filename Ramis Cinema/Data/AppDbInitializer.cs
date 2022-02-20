using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ramis_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ramis_Cinema.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Locations.Any())
                {
                    context.Locations.AddRange(new List<Location>()
                    {
                        new Location()
                        {
                            Name = "Scandic Hotel",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Desc = "Rymlig salong med massa stolar"
                        }
                    });
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        { 
                            Name = "Actor 1",
                            Desc = "This is the Bio of the first actor",
                            ImgURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        }

                    });
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Desc = "This is the Bio of the first actor",
                            ImgURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        }
                    });
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Id = 1,
                            Title = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            Start = DateTime.Now.AddDays(-10),
                            End = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            CategoryId = 1
                        }
                    });
                }
                if (!context.ActorsMovies.Any())
                {
                    
                }
                context.SaveChanges();

            }

        }
    }
}
