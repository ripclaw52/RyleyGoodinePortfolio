using RyleyGoodinePortfolio.Models;

namespace RyleyGoodinePortfolio.Data
{
    public static class ProjectRepository
    {
        public static List<Project> GetAll() =>
            new()
            {
                // Bus Seating Widget
            new Project
            {
                Slug="bus-seating-widget",
                Title="Bus Seating Widget",
                ThumbnailUrl="https://cdn.imgchest.com/files/650518e5a396.png",

                Summary=
                    "Admin-editable modular seat reservation tool.",

                Description=
                    "Built using Blazor and MySQL to support reservation workflows.",

                Technologies=
                new()
                {
                    "Blazor",
                    "C#",
                    "MySQL"
                }
            },

            // Fighting Game Prototype
            new()
            {
                Slug = "fighting-game-prototype",

                Title = "Fighting Game Prototype",

                Summary =
                    "Smash-inspired Unity fighting game prototype.",

                Description =
                    "Designed combat systems, animations, and mechanics.",

                Technologies = new()
                {
                    "Unity",
                    "C#",
                    "Blender"
                }
            },

            // Pokémon Capstone Project
            new()
            {
                Slug = "pokemon-capstone",

                Title = "Pokémon Capstone Project",

                Summary =
                    "Turn-based systems project emphasizing persistence and UX.",

                Description =
                    "Focused on gameplay architecture and user experience.",

                Technologies = new()
                {
                    "C#",
                    "Game Design"
                }
            },

            // art Work
            new()
            {
                Slug = "art-work",

                Title = "Art Work",

                Summary =
                    "Personal artwork of images and videos",

                Description =
                    "Personal artwork of images and videos.",

                Technologies = new()
                {
                    "Illustrator",
                    "Photoshop",
                    "XD",
                    "After Effects",
                    "Premiere Pro"
                },

                Media = new()
                {
                    /* VIDEOS */
                    // Weight of Love - Black Keys - Kinetic Typography
                    new() {
                        Type=MediaType.Video,
                        Url="https://geo.dailymotion.com/player.html?video=xa6wl5g",
                        Caption="Weight of Love by the Black Keys - Kinetic Typography",
                    },

                    // Pulp Fiction - Kinetic Typography
                    new() {
                        Type=MediaType.Video,
                        Url="https://dai.ly/xa63mio",
                        Caption="Pulp Fiction - Kinetic Typography"
                    },

                    // Life and Death of a Star
                    new()
                    {
                        Type=MediaType.Video,
                        Url="https://geo.dailymotion.com/player.html?video=xa6wkte",
                        Caption="Life and Death of a Star"
                    },

                    /* IMAGES */
                }
            },


            };
    }
}
