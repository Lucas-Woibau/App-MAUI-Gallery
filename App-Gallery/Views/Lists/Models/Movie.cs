using System;
using System.Collections.Generic;
using static App_Gallery.Views.Lists.Models.Movie;

namespace App_Gallery.Views.Lists.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }

        public class GroupMovie : List<Movie>
        {
            public string CompanyName { get; set; }
        }


    }

    public class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGroup = new GroupMovie() { CompanyName = "Disney" };

            disneyGroup.Add(new Movie { Id = 1, Name = "The Matrix", Description = "A hacker discovers reality is a simulation.", Duration = TimeSpan.FromMinutes(136), LaunchYear = 1999 });
            disneyGroup.Add(new Movie { Id = 2, Name = "Inception", Description = "A thief who steals corporate secrets through dream-sharing.", Duration = TimeSpan.FromMinutes(148), LaunchYear = 2010 });
            disneyGroup.Add(new Movie { Id = 3, Name = "Interstellar", Description = "A team travels through a wormhole in space.", Duration = TimeSpan.FromMinutes(169), LaunchYear = 2014 });


            var paramountGroup = new GroupMovie() { CompanyName = "Paramount" };
            paramountGroup.Add(new Movie { Id = 4, Name = "The Godfather", Description = "The aging patriarch transfers control to his son.", Duration = TimeSpan.FromMinutes(175), LaunchYear = 1972 });
            paramountGroup.Add(new Movie { Id = 5, Name = "Shutter Island", Description = "A detective investigates a disappearance in an asylum.", Duration = TimeSpan.FromMinutes(138), LaunchYear = 2010 });
            paramountGroup.Add(new Movie { Id = 6, Name = "Avengers: Endgame", Description = "Heroes unite to reverse Thanos' actions.", Duration = TimeSpan.FromMinutes(181), LaunchYear = 2019 });

            List<GroupMovie> list = new List<GroupMovie>() { disneyGroup, paramountGroup };

            return list;
        }

        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();

            list.Add(new Movie { Id = 7, Name = "Fight Club", Description = "An insomniac meets a soap salesman and forms an underground club.", Duration = TimeSpan.FromMinutes(139), LaunchYear = 1999 });
            list.Add(new Movie { Id = 8, Name = "Parasite", Description = "A poor family infiltrates a wealthy household.", Duration = TimeSpan.FromMinutes(132), LaunchYear = 2019 });
            list.Add(new Movie { Id = 9, Name = "The Shawshank Redemption", Description = "Two imprisoned men bond over years.", Duration = TimeSpan.FromMinutes(142), LaunchYear = 1994 });
            list.Add(new Movie { Id = 10, Name = "Dune", Description = "A noble family becomes embroiled in a war for control over a desert planet.", Duration = TimeSpan.FromMinutes(155), LaunchYear = 2021 });
            list.Add(new Movie { Id = 11, Name = "The Prestige", Description = "Two magicians engage in a rivalry.", Duration = TimeSpan.FromMinutes(130), LaunchYear = 2006 });
            list.Add(new Movie { Id = 12, Name = "Coco", Description = "A boy journeys to the Land of the Dead to discover his family's history.", Duration = TimeSpan.FromMinutes(105), LaunchYear = 2017 });
            list.Add(new Movie { Id = 13, Name = "Soul", Description = "A jazz musician gets a second chance at life.", Duration = TimeSpan.FromMinutes(100), LaunchYear = 2020 });
            list.Add(new Movie { Id = 14, Name = "Blade Runner 2049", Description = "A new blade runner unearths secrets from the past.", Duration = TimeSpan.FromMinutes(164), LaunchYear = 2017 });
            list.Add(new Movie { Id = 15, Name = "Tenet", Description = "A secret agent manipulates the flow of time to prevent global catastrophe.", Duration = TimeSpan.FromMinutes(150), LaunchYear = 2020 });

            return list;
        }
    }
}
