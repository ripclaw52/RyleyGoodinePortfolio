namespace RyleyGoodinePortfolio.Models
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

            new()
            {
                Slug = "portfolio-site",

                Title = "Portfolio Website",

                Summary =
                    "Responsive Blazor portfolio with reusable components.",

                Description =
                    "Built with layouts, reusable cards, and case study routing.",

                Technologies = new()
                {
                    "Blazor",
                    "CSS",
                    "Razor"
                }
            }


            };
    }
}
