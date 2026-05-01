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
                        "Built using Blazor and SQL to support reservation workflows.",

                    Technologies=
                    new()
                    {
                        "Blazor",
                        "C#",
                        "SQL"
                    }
                },

                // Fighting Game Prototype
                new Project()
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
                new Project()
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
                new Project()
                {
                    Slug = "art-work",
                    Title = "Art Work",
                    ThumbnailUrl = "https://cdn.imgchest.com/files/6ca130d0df7f.png",

                    Summary = "Personal artwork of images and videos",

                    Description = "Personal artwork of images and videos.",

                    Technologies = new()
                    {
                        "Illustrator",
                        "Photoshop",
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
                            Technologies = new()
                            {
                                "After Effects",
                                "Premiere Pro",
                            },
                        },

                        // Pulp Fiction - Kinetic Typography
                        new() {
                            Type=MediaType.Video,
                            Url="https://dai.ly/xa63mio",
                            Caption="Pulp Fiction - Kinetic Typography",
                            Technologies = new()
                            {
                                "After Effects",
                                "Premiere Pro",
                            },
                        },

                        // Life and Death of a Star
                        new()
                        {
                            Type=MediaType.Video,
                            Url="https://geo.dailymotion.com/player.html?video=xa6wkte",
                            Caption="Life and Death of a Star",
                            Technologies = new()
                            {
                                "After Effects",
                            },
                        },

                        /* IMAGES */
                        new()
                        {
                            // blue superman stencil
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/0ba5de1ba153.png",
                            Caption="Blue Superman Stencil",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },

                        new()
                        {
                            // andy warhol superman stencil
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/650518e5a396.png",
                            Caption="Andy Warhol Superman Stencil",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },

                        new()
                        {
                            // arkham batman stencil
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/73c42cf36999.png",
                            Caption="Arkham Batman Stencil",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // arkham batman symbol stencil
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/25f336dac9ec.png",
                            Caption="Arkham Batman Symbol Stencil",
                            Technologies = new()
                            {
                                "Illustrator",
                                "Photoshop",
                            },
                        },
                    
                        new()
                        {
                            // arkham joker high-detail abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/8537dca1dff6.png",
                            Caption="Arkham Joker High-Detail Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // green lantern 1
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/3e78fb9255cf.png",
                            Caption="Green Lantern 1",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // clone trooper abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/b72492fda2f3.png",
                            Caption="Clone Trooper Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // hexagon pattern abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/bfd61a46ab39.png",
                            Caption="Hexagon Pattern Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // optical illusion abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/74b907fbb261.png",
                            Caption="Optical Illusion Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // green lantern 2
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/ed87d011259c.png",
                            Caption="Green Lantern 2",
                            Technologies = new()
                            {
                                "Illustrator",
                                "Photoshop",
                            },
                        },
                    
                        new()
                        {
                            // colour wheel abtract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/ad0f66557f24.png",
                            Caption="Colour Wheel Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // destiny exo head abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/a5c66a3d8bfe.png",
                            Caption="Destiny Exo Head Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // destiny vandal head abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/5fb7317d2e09.png",
                            Caption="Destiny Vandal Head Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // destiny vandal head close-up abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/01c897067abb.png",
                            Caption="Destiny Vandal Head Close-Up Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    
                        new()
                        {
                            // destiny vandal head abstract andy warhol rainbow
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/2a22736e26ba.png",
                            Caption="Destiny Vandal Head Abstract Andy Warhol Rainbow",
                            Technologies = new()
                            {
                                "Illustrator",
                                "Photoshop",
                            },
                        },
                    
                        new()
                        {
                            // flash lightning bold abstract
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/caa7e03c1c7c.png",
                            Caption="Flash Lightning Bold Abstract",
                            Technologies = new()
                            {
                                "Illustrator",
                                "Photoshop",
                            },
                        },
                    
                        new()
                        {
                            // superman stencil negative
                            Type=MediaType.Image,
                            Url="https://cdn.imgchest.com/files/f569b1bafcff.png",
                            Caption="Superman Stencil Negative",
                            Technologies = new()
                            {
                                "Illustrator",
                            },
                        },
                    }
                },


            };
    }
}
