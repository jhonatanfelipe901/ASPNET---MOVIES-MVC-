using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;


namespace MvcMovie.Models
{
    public class SeedData
    {
   
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new MvcMovieContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MvcMovieContext>>()))
                {
                    // Procurar pelos Filmes
                    if (context.Movie.Any())
                    {
                        return;   // DB foi criado
                    }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "Harry e Sally - Feitos Um para o Outro",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Comédia Romântica",
                            Rating = "4",
                            Price = 7.99M
                        },

                        new Movie
                        {
                            Title = "Caça Fantasmas",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comédia",
                            Rating = "3",
                            Price = 8.99M
                        },

                        new Movie
                        {
                            Title = "Caça Fantasmas 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Rating = "4",
                            Price = 9.99M
                        },

                        new Movie
                        {
                            Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Ocidental",
                            Rating = "5",
                            Price = 3.99M
                        },

                        new Movie
                        {
                            Title = "Scooby Doo",
                            ReleaseDate = DateTime.Parse("1989-1-11"),
                            Genre = "Comédia",
                            Rating = "5",
                            Price = 7.99M
                        }
                        
                    );
                    context.SaveChanges();
                }
            }
        }
    }





