using Microsoft.VisualBasic;
using RyleyGoodinePortfolio.Models;
using System.Buffers.Text;
using System.Data;
using System.Linq.Expressions;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RyleyGoodinePortfolio.Data
{
    public static class ProjectRepository
    {
        public static List<Project> GetAll() =>
            new()
            {
                // Edmonton Property Assessment Tool
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

                // Property Assessment Tool City of Edmonton
                new Project()
                {
                    Slug = "property-assessment-tool",

                    Title = "Property Assessment Tool City of Edmonton",

                    // card description
                    Summary = "This project is an interactive dashboard that combines property values, crime data, " +
                    "and cultural insights to help users evaluate and compare neighbourhoods in Edmonton. By visualizing" +
                    " complex data in a clear, accessible way, it simplifies the decision-making process when choosing" +
                    " where to live.",

                    // paragraph
                    Description = "Moving to a new city is a complex and stressful process that requires evaluating factors" +
                    " like housing costs, safety, and cultural fit, yet this information is often scattered and difficult to" +
                    " interpret. This project presents a data visualization dashboard focused on Edmonton that consolidates " +
                    "property values, recent crime data, and neighbourhood language distribution into an interactive, " +
                    "user-friendly interface. By combining map - based exploration with dynamic charts and filters, the " +
                    "application allows users to easily compare neighbourhoods and gain meaningful insights without needing" +
                    " specialized knowledge.Built using Python, pandas, Plotly, and Dash, the dashboard emphasizes clarity, " +
                    "interactivity, and accessibility, though it currently relies on static datasets and has room for future " +
                    "enhancements such as real - time data integration, expanded property details, and improved mapping " +
                    "features.",

                    Technologies = new()
                    {
                        "python",
                        "html",
                        "css",
                        "pycharm",
                        "acrobat",
                        "excel",
                        "word",

                    },

                    // each string is a paragraph of content for the project page
                    ProjectContent = new()
                    {
                        new Details("p", "Moving to a new city or neighbourhood can be a complex and stressful process, " +
                            "requiring individuals to evaluate multiple factors such as housing affordability, safety, and " +
                            "cultural fit.However, much of this information is often fragmented across different platforms or " +
                            "presented in ways that are difficult to interpret. This project introduces a data-driven " +
                            "dashboard designed to consolidate and visualize key neighbourhood insights, helping users make " +
                            "more informed decisions about where to live."),
                        new Details("p", "At its core, the dashboard leverages principles of information visualization to " +
                            "transform raw data into intuitive, interactive visuals. Similar to how stock market dashboards " +
                            "simplify complex financial data through graphs and colour cues, this application presents " +
                            "neighbourhood data in a clear and accessible format. By combining multiple datasets into a single " +
                            "interface, users can quickly grasp trends and comparisons without needing specialized knowledge."),
                        new Details("p", "The application focuses specifically on the city of Edmonton, using datasets that " +
                            "include current property assessment values, recent crime reports from the past 90 days, and " +
                            "census data on language distribution from 2016. Property values provide insight into the relative " +
                            "cost and desirability of neighbourhoods, while crime data offers a perspective on safety. " +
                            "Language distribution helps users understand the cultural composition of communities, which can " +
                            "be especially important for those seeking a sense of belonging or cultural familiarity."),
                        new Details("p", "The design of the dashboard emphasizes clarity, usability, and visual hierarchy. " +
                            "Inspired by tools such as COVID-19 dashboards and mapping platforms like Google Maps, the " +
                            "interface integrates a geographic map with supporting charts and filters. Users can explore " +
                            "neighbourhoods spatially, filter by property value ranges, and view crime data plotted directly " +
                            "on the map. Additional visual elements, such as colour coding and whitespace, are used " +
                            "strategically to reduce visual clutter and highlight important information."),
                        new Details("p", "Interactivity is a key feature of the system. Users can select neighbourhoods " +
                            "through a search bar or directly on the map, triggering updates across multiple visual " +
                            "components. Crime data is broken down into categories and subcategories, allowing for deeper " +
                            "analysis through selectable filters and dynamically generated graphs. A separate comparison view " +
                            "enables users to evaluate multiple neighbourhoods side by side, focusing on metrics like average " +
                            "property value and language distribution."),
                        new Details("p", "From a technical standpoint, the application is built using Python and several " +
                            "supporting libraries. Data is processed using pandas, while visualizations are created with " +
                            "Plotly. The Dash framework is used to render the interactive web interface, integrating charts, " +
                            "maps, and UI components such as dropdown menus and radio buttons. Geographic data is incorporated " +
                            "through GeoJSON to accurately map neighbourhood boundaries."),
                        new Details("p", "Despite its functionality, the project has several limitations. The datasets are " +
                            "static and stored in CSV format, which restricts real-time updates and scalability. Additionally, " +
                            "property data is limited primarily to residential information, and deeper property-level details " +
                            "are not yet included. Crime data, while geographically mapped, lacks direct linkage to specific " +
                            "neighbourhood boundaries, making certain comparisons more complex."),
                        new Details("p", "Future improvements could significantly enhance the application’s usefulness. " +
                            "Integrating live data through APIs would allow for real-time updates, while expanding datasets " +
                            "could provide more granular insights into properties and neighbourhood characteristics. " +
                            "Enhancements to the map—such as weighted crime indicators or integrated cultural data " +
                            "overlays—would improve visual clarity and analytical depth. There is also potential to connect " +
                            "with external services like mapping platforms to provide real-world context for individual " +
                            "properties."),
                        new Details("p", "Evaluation of the dashboard would focus heavily on user testing to refine usability " +
                            "and effectiveness. Feedback on interface design, navigation flow, and data presentation would " +
                            "guide iterative improvements. Performance optimization, including faster data processing and " +
                            "rendering, would also be a priority to ensure a smooth user experience."),
                        new Details("p", "In conclusion, this dashboard represents a practical application of data " +
                            "visualization techniques to address a real-world problem. By centralizing and simplifying access " +
                            "to important neighbourhood data, it empowers users to make better-informed decisions about where " +
                            "to live. With further development, expanded datasets, and improved interactivity, the application " +
                            "has the potential to become a highly valuable tool for urban exploration and relocation planning."),
                    },

                    Media = new() { },

                    GitHubUrl = "https://github.com/ripclaw52/pythonPandasAndNumpyTestProject.git",
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
                            Url="https://player.vimeo.com/video/1188533777?h=73c3758453",
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
                            Url="https://player.vimeo.com/video/1189181438?badge=0&amp;autopause=0&amp;player_id=0&amp;app_id=58479",
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
