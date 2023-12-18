using MovieTickets.Data.Enums;
using MovieTickets.Models;
using System;

namespace MovieTickets.Data
{
    public class AppDbInit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Penn Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Penn Cinema, IMAX options."
                        },
                        new Cinema()
                        {
                            Name = "Movie House",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Movie House Cinemas, great deals."
                        },
                        new Cinema()
                        {
                            Name = "Great Lakes Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Cinema on the Great Lakes, bring a coat!"
                        },
                        new Cinema()
                        {
                            Name = "State Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "We serve gin!"
                        },
                        new Cinema()
                        {
                            Name = "Nazareth",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "The home of Christian cinema."
                        },
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Matt LeBlanc",
                            Bio = "Matthew Steven LeBlanc; born July 25, 1967) is an American actor. He garnered global recognition " +
                            "with his portrayal of Joey Tribbiani in the NBC sitcom Friends and in its spin-off series, Joey.",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Chris Tucker",
                            Bio = "Christopher Tucker (born August 31, 1971) is an American stand-up comedian and actor. Tucker made" +
                            " his debut in 1992 as a stand-up performer on the HBO comedy series Def Comedy Jam, where he frequently" +
                            " appeared on the show during the 1990s.",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "Angelina Jolie; born Angelina Jolie Voight; June 4, 1975) is an American actress, filmmaker and h" +
                            "umanitarian. The recipient of numerous accolades, including an Academy Award and three Golden Globe Awa" +
                            "rds, she has been named Hollywood's highest-paid actress multiple times.",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Jim Carrey",
                            Bio = "James Eugene Carrey; born January 17, 1962) is a Canadian-American actor and comedian. Known for " +
                            "his energetic slapstick performances, Carrey first gained recognition in 1990, after landing a role in " +
                            "the American sketch comedy television series In Living Color (1990–1994). ",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Will Smith",
                            Bio = "Willard Carroll Smith II (born September 25, 1968) is an American actor, rapper and film producer" +
                            ". He has received multiple accolades, including an Academy Award, a Golden Globe Award, a Screen Actors" +
                            " Guild Award, a BAFTA Award, and four Grammy Awards. As of 2023, his films have grossed over $9.3 billi" +
                            "on globally, making him one of Hollywood's most bankable stars.",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Directors
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            FullName = "Christopher Nolan",
                            ProfilePicture = "https://en.wikipedia.org/wiki/Christopher_Nolan#/media/File:Christopher_Nolan_Cannes_2018.jpg",
                            Bio = "Christopher Edward Nolan CBE (born 30 July 1970) is a British and " +
                            "American filmmaker. Known for his Hollywood blockbusters with complex storytel" +
                            "ling, Nolan is considered a leading filmmaker of the 21st century; his films h" +
                            "ave grossed $5 billion worldwide. The recipient of many accolades, he has been" +
                            " nominated for five Academy Awards, five BAFTA Awards and six Golden Globe Awa" +
                            "rds."
                        },
                        new Director()
                        {
                            FullName = "Quentin Tarantino",
                            ProfilePicture = "https://en.wikipedia.org/wiki/Quentin_Tarantino#/media/File:Quentin_Tarantino_by_Gage_Skidmore.jpg",
                            Bio = "Quentin Jerome Tarantino; born March 27, 1963) is an American film" +
                            " director, screenwriter, producer, and actor. His films are characterized by s" +
                            "tylized violence, extended dialogue including a pervasive use of profanity, an" +
                            "d references to popular culture."
                        },
                        new Director()
                        {
                            FullName = "Martin Scorsese",
                            ProfilePicture = "https://en.wikipedia.org/wiki/Martin_Scorsese#/media/File:Martin_Scorsese_Berlinale_2010_(cropped2).jpg",
                            Bio = "Martin Charles Scorsese; born November 17, 1942) is an American an" +
                            "d Italian film director, producer, screenwriter and actor. Scorsese emerged as" +
                            " one of the major figures of the New Hollywood era. He is the recipient of man" +
                            "y major accolades, including an Academy Award, four BAFTA Awards, three Emmy A" +
                            "wards, a Grammy Award, three Golden Globe Awards, and two Directors Guild of A" +
                            "merica Awards."
                        },
                        new Director()
                        {
                            FullName = "Akira Kurosawa",
                            ProfilePicture = "https://en.wikipedia.org/wiki/Akira_Kurosawa#/media/File:Akirakurosawa-onthesetof7samurai-1953-page88.jpg",
                            Bio = "Akira Kurosawa[note 1] (黒澤明 or 黒沢明, Kurosawa Akira, March 23, " +
                            "1910 – September 6, 1998) was a Japanese filmmaker and painter who directed 30" +
                            " films in a career spanning over five decades. He is widely regarded as one of" +
                            " the greatest and most influential filmmakers in the history of cinema. Kurosa" +
                            "wa displayed a bold, dynamic style, strongly influenced by Western cinema yet " +
                            "distinct from it; he was involved with all aspects of film production."
                        },
                        new Director()
                        {
                            FullName = "Stanley Kubrick",
                            ProfilePicture = "https://en.wikipedia.org/wiki/Stanley_Kubrick#/media/File:Kubrick_on_the_set_of_Barry_Lyndon_(1975_publicity_photo)_crop.jpg",
                            Bio = "Stanley Kubrick; July 26, 1928 – March 7, 1999) was an American fi" +
                            "lm director, producer, screenwriter and photographer. Widely considered one of" +
                            " the greatest filmmakers of all time, his films—almost all of which are adapta" +
                            "tions of novels or short stories—cover a wide range of genres and feature inno" +
                            "vative cinematography, dark humor, realistic attention to detail and extensive" +
                            " set designs."
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Oppenheimer",
                            Description = "Oppenheimer description",
                            Price = 25,
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQb0niU5_-nJcGruRTitqp6LWLeP5Av8LnPWcJ4eUz8avZ9zpXb",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            DirectorId = 1,
                            MovieCategory = Enums.MovieCategory.Documentary,
                        },
                        new Movie()
                        {
                            Name = "Shark Tale",
                            Description = "Shark Tale description",
                            Price = 10,
                            ImageURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQcmRkpEqH_qF4QtihXT-ZWceDSNCB2ykx0lunl4xgjBlBhKCjS",
                            StartDate = DateTime.Now.AddDays(1),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            DirectorId = 2,
                            MovieCategory = Enums.MovieCategory.Comedy,
                        },
                        new Movie()
                        {
                            Name = "Full Metal Jacket",
                            Description = "Full Metal Jacket description",
                            Price = 15,
                            ImageURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQCoX_bNtrmtT1mU-gop7cHh2zz1P8FDL3lrvx0ThbP9di-cqf5",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 1,
                            DirectorId = 3,
                            MovieCategory = Enums.MovieCategory.Action,
                        },
                        new Movie()
                        {
                            Name = "Seven Samurai",
                            Description = "Seven Samurai description",
                            Price = 12.5,
                            ImageURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQagsS7mewXV9XF8Hya8qgiOz6N58oPB5Tg624ERla2YtEnF_ZW",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            DirectorId = 4,
                            MovieCategory = Enums.MovieCategory.Action,
                        },
                        new Movie()
                        {
                            Name = "Django Unchained",
                            Description = "Django Unchained description",
                            Price = 22.5,
                            ImageURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSnm2FczCxSnt69XUZqqI5-sfy66SvjiV0du9mfUKRRCGqVAurt",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(25),
                            CinemaId = 1,
                            DirectorId = 5,
                            MovieCategory = Enums.MovieCategory.Drama,
                        },
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                    });
                    context.SaveChanges();

                }

            }
        }
    }
}
