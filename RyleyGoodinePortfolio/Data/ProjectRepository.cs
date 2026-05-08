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
                // Property Assessment Tool City of Edmonton
                new Project()
                {
                    Slug = "property-assessment-tool",
                    Title = "Property Assessment Tool City of Edmonton",
                    ThumbnailUrl = "",

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

                    // images and videos
                    Media = new() { },

                    GitHubUrl = "https://github.com/ripclaw52/pythonPandasAndNumpyTestProject.git",
                },

                // Pokémon Capstone Project
                new Project()
                {
                    Slug = "pokemon-capstone",
                    Title = "Pokémon Capstone Project",
                    ThumbnailUrl = "",

                    Summary = "Turn-based systems project emphasizing persistence and UX.",

                    Description = "Focused on gameplay architecture and user experience.",

                    Technologies = new()
                    {
                        "c#",
                        "unity",
                        "visual_studio",
                        "gimp",
                        "game_design",
                    },

                    ProjectContent = new()
                    {
                        new Details("style", "body {\r\nfont-family: Arial, sans-serif;\r\nline-height: 1.7;\r\nmargin: 0;\r\nbackground: #f4f6f8;\r\ncolor: #222;\r\n    \r\n}\r\n\r\nheader {\r\nbackground: #2d3748;\r\ncolor: white;\r\npadding: 3rem 2rem;\r\ntext-align: center;\r\n}\r\n\r\nmain {\r\nmax-width: 1100px;\r\nmargin: auto;\r\npadding: 2rem;\r\n    \r\n}\r\n\r\nsection {\r\nbackground: white;\r\nmargin-bottom: 2rem;\r\npadding: 2rem;\r\nborder-radius: 12px;\r\nbox-shadow: 0 2px 8px rgba(0,0,0,0.08);\r\n    \r\n}\r\n\r\nh1, h2, h3, h4 {\r\ncolor: #1a202c;\r\n    \r\n}\r\n\r\nh2 {\r\nborder-bottom: 2px solid #e2e8f0;\r\npadding-bottom: 0.5rem;\r\n    \r\n}\r\n\r\nul {\r\npadding-left: 1.5rem;\r\n    \r\n}\r\n\r\n.feature-card {\r\nbackground: #edf2f7;\r\npadding: 1rem;\r\nborder-radius: 8px;\r\nmargin-bottom: 1rem;\r\n    \r\n}\r\n\r\n.code-block {\r\nbackground: #1e1e1e;\r\ncolor: #f8f8f2;\r\npadding: 1rem;\r\nborder-radius: 8px;\r\noverflow-x: auto;\r\n    \r\n}\r\n\r\n.timeline-item {\r\nborder-left: 4px solid #4299e1;\r\npadding-left: 1rem;\r\nmargin-bottom: 1rem;\r\n    \r\n}\r\n\r\nfooter {\r\ntext-align: center;\r\npadding: 2rem;\r\ncolor: #666;\r\n    \r\n}"),

                        // introduction
                        new Details("div",
                            "<section>" +
                            "<h2>Introduction</h2>" +

                            "<p>This project is a recreation of Pokémon Emerald developed in Unity using the 2D engine and C# " +
                            "programming language. The game focuses on recreating the exploration, battle, and progression systems " +
                            "from the original Pokémon games while introducing additional quality-of-life improvements and new " +
                            "gameplay systems.</p>" +
                            "<p>The project also serves as a technical showcase for modular game development within Unity. Systems " +
                            "are designed with scalability in mind, allowing future gameplay mechanics, user interface improvements, " +
                            "and additional Pokémon content to be added without requiring complete rewrites of existing systems.</p>" +
                            "</section>"
                            ),

                        // game overview
                        new Details("div",
                            "<section>" +
                            "<h2>Game Overview</h2> " +

                            "<h3>Storyline</h3>" +
                            "<p>The game takes place in the Hoenn region, inspired directly by Pokémon Emerald. Players begin their " +
                            "adventure in Littleroot Town and progress toward becoming Pokémon Champion through exploration, battles, " +
                            "and story progression.</p>" +

                            "<h3>Target Audience</h3>" +
                            "<p>The intended audience is rated \"E for Everyone.\" The game primarily targets fans of classic Pokémon " +
                            "titles while remaining accessible to all players.</p>" +

                            "<h3>Platform</h3>" +
                            "<p>The game currently supports Windows PC through the Unity 2D engine.</p>" +
                            "<p>While inspired heavily by Pokémon Emerald, the project also introduces modernized interface systems " +
                            "and expanded gameplay mechanics that were not fully present in the original Game Boy Advance release. " +
                            "The goal is to preserve the feel of the original game while improving usability and system flexibility.</p>" +
                            "</section>"
                            ),

                        // game mechanics
                        new Details("div",
                            "<section>" +
                            "<h2>Game Mechanics</h2>" +

                            "<h3>Player Controls</h3>" +
                            "<ul>" +
                            "<li><strong>Arrow Keys:</strong> Move player and navigate menus</li>" +
                            "<li><strong>Z:</strong> Confirm selections and interact</li>" +
                            "<li><strong>X:</strong> Cancel or go back</li>" +
                            "<li><strong>Enter:</strong> Open menu in overworld</li>" +
                            "<li><strong>Shift:</strong> Run feature</li>" +
                            "</ul>" +

                            "<h3>Overworld Systems</h3>" +
                            "<ul>" +
                            "<li>Animated player movement</li>" +
                            "<li>NPC scripting and cutscenes</li>" +
                            "<li>Quest systems</li>" +
                            "<li>Wild Pokémon encounters</li>" +
                            "<li>Trainer field-of-view battles</li>" +
                            "<li>HM abilities such as Surf and Cut</li>" +
                            "</ul>" +

                            "<h3>Battle System</h3>" +
                            "<ul>" +
                            "<li>Turn-based combat</li>" +
                            "<li>Move selection system</li>" +
                            "<li>Status conditions</li>" +
                            "<li>Experience and leveling</li>" +
                            "<li>Bag and party management</li>" +
                            "<li>Trainer and wild battles</li>" +
                            "</ul>" +
                            "</section>"
                            ),

                        // game environment
                        new Details("div",
                            "<section>" +
                            "<h2>Game Environment</h2>" +

                            "<h3>Sprites</h3>" +
                            "<p>Sprite assets are sourced from Pokémon Emerald sprite " +
                            "resources and used for player characters, NPCs, Pokémon, " +
                            "menus, and battle scenes.</p>" +

                            "<h3>Audio</h3>" +
                            "<p>Sound effects and music are sourced from Pokémon " +
                            "Ruby/Sapphire collections, including move sounds, menu " +
                            "audio, and scene music.</p>" +

                            "<h3>Textures</h3>" +
                            "<p>Tile textures define environmental layers such as grass, " +
                            "water, solid objects,foreground, and background rendering.</p>" +
                            "</section>"
                            ),

                        // technical design
                        new Details("div",
                            "<section>" +
                            "<h2>Technical Design</h2>" +

                            "<div class=\"feature-card\">" +
                            "<h3>Engine</h3>" +
                            "<p>Unity 2021.3.11f1 (2D Engine)</p>" +
                            "</div>" +
                            
                            "<div class=\"feature-card\">" +
                            "<h3>Primary Language</h3>" +
                            "<p>C#</p>" +
                            "</div>" +

                            "<div class=\"feature-card\">" +
                            "<h3>Architecture</h3>" +
                            "<p>State Stack Architecture with Scriptable Objects</p>" +
                            "</div>" +
                            
                            "<p>The project uses a state-driven architecture to separate gameplay systems such as battles, menus, " +
                            "cutscenes, and overworld exploration into isolated game states. This approach improves organization and " +
                            "simplifies transitions between gameplay screens.</p>" +
                            "<p>Scriptable Objects are heavily utilized throughout development to store reusable data such as Pokémon " +
                            "species, move definitions, status conditions, type information, and UI references. This allows designers " +
                            "to modify gameplay data without directly changing core gameplay scripts.</p>" +
                            "</section>"
                            ),

                        // quality of life
                        new Details("div",
                            "<section>" +
                            "<h2>Quality of Life Features</h2>" +

                            "<article class=\"feature-card\">" +
                            "<h3>User Interface Refactor</h3>" +
                            "<p>Redesigned menus and HUD elements to better resemble " +
                            "Pokémon Emerald, including typography, menu borders, and" +
                            " updated health bars.</p>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Coloured Health Bars</h3>" +
                            "<p>Added gradient-based HP bars using Unity gradients. Health bar colours change dynamically " +
                            "based on remaining HP percentage.</p>" +
                            "<ul>" +
                            "<li>Green: 100–51%</li>" +
                            "<li>Yellow: 50–21%</li>" +
                            "<li>Red: 20–0%</li>" +
                            "</ul>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Animated Sprites</h3>" +
                            "<p>Added animated Pokémon sprites using custom sprite-map " +
                            "animation systems within Unity UI image components.</p>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Running System</h3>" +
                            "<p>Implemented running movement with increased movement " +
                            "speed and updatedanimation sets triggered by keyboard or controller input.</p>" +
                            "</article>" +
                            "</section>"
                            ),

                        // new features
                        new Details("div",
                            "<section>" +
                            "<h2>New Gameplay Features</h2>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Summary Screen</h3>" +
                            "<p>Added a modular Pokémon Summary Screen featuring:</p>" +
                            "<ul>" +
                            "<li>Pokémon stats</li>" +
                            "<li>Move details</li>" +
                            "<li>Experience tracking</li>" +
                            "<li>Nature information</li>" +
                            "<li>Radar graph stat visualization</li>" +
                            "</ul>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Pokédex System</h3>" +
                            "<p>Implemented a full Pokédex tracking system with encounter states:</p>" +
                            "<ul>" +
                            "<li>None</li>" +
                            "<li>Seen</li>" +
                            "<li>Owned</li>" +
                            "</ul>" +
                            "<p>Includes scrolling lists, Pokémon information pages, and save/load support.</p>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>PC Storage System</h3>" +
                            "<p>Added Pokémon storage boxes with drag-and-drop interaction, box customization, " +
                            "and binary save support.</p>" +
                            "<ul>" +
                            "<li>30 Pokémon per box</li>" +
                            "<li>Multiple box support</li>" +
                            "<li>Virtual mouse integration</li>" +
                            "<li>Summary screen access from PC</li>" +
                            "</ul>" +
                            "</article>" +
                            "</section>"
                            ),

                        // advanced features
                        new Details("div",
                            "<section>" +
                            "<h2>Advanced Battle Features</h2>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Critical Hits</h3>" +
                            "<p>Added move-specific critical hit behavior including:</p>" +
                            "<ul>" +
                            "<li>Always Critical</li>" +
                            "<li>High Critical Chance</li>" +
                            "<li>Never Critical</li>" +
                            "</ul>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Recoil Damage</h3>" +
                            "<p>Added multiple recoil damage systems:</p>" +
                            "<ul>" +
                            "<li>Damage-based recoil</li>" +
                            "<li>Max HP recoil</li>" +
                            "<li>Current HP recoil</li>" +
                            "</ul>" +
                            "</article>" +

                            "<article class=\"feature-card\">" +
                            "<h3>Natures, EVs, and IVs</h3>" +
                            "<p>Implemented Pokémon stat systems including:</p>" +
                            "<ul>" +
                            "<li>25 Pokémon Natures</li>" +
                            "<li>Effort Values (EVs)</li>" +
                            "<li>Individual Values (IVs)</li>" +
                            "<li>Level-up stat scaling</li>" +
                            "</ul>" +
                            "</article>" +
                            "<p>These advanced systems were implemented to more closely replicate competitive Pokémon mechanics found " +
                            "in official games. The combination of Natures, EVs, IVs, recoil systems, and critical-hit behavior " +
                            "creates greater variation between Pokémon and introduces more strategic depth during battles.</p>" +
                            "</section>"
                            ),

                        // bug fixes
                        new Details("div",
                            "<section>" +
                            "<h2>Bug Fixes & Challenges</h2>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>Health Bar Scaling Issue</h3>" +
                            "<p>Fixed incorrect HP bar scaling by adjusting battle camera size and resetting prefab " +
                            "sizing to native scale.</p>" +
                            "</div>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>Animation Array Crash</h3>" +
                            "<p>Resolved null animation array issues by validating arrays during Start and " +
                            "HandleUpdate methods.</p>" +
                            "</div>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>Pokédex Runtime Persistence Bug</h3>" +
                            "<p>Created custom PokedexObject classes to prevent runtime encounter data from persisting " +
                            "between Unity sessions.</p>" +
                            "</div>" +
                            "</section>"
                            ),

                        // timeline
                        new Details("div",
                            "<section>" +
                            "<h2>Implementation Timeline</h2>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>September 2023</h3>" +
                            "<p>Initial GDD completed.</p>" +
                            "</div>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>UI Refactor</h3>" +
                            "<p>Started September 19, 2023.</p>" +
                            "</div>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>Animated Sprites</h3>" +
                            "<p>Started September 20, 2023.</p>" +
                            "</div>" +

                            "<div class=\"timeline-item\">" +
                            "<h3>Health Bar Redesign</h3>" +
                            "<p>Completed September 13, 2023.</p>" +
                            "</div>" +
                            "</section>"
                            ),

                        // future plans
                        new Details("div",
                            "<section>" +
                            "<h2>Future Plans</h2>" +

                            "<ul>" +
                            "<li>Gym battles and Elite Four</li>" +
                            "<li>Abilities and held items</li>" +
                            "<li>Berry mechanics</li>" +
                            "<li>Breeding systems</li>" +
                            "<li>Weather and terrain mechanics</li>" +
                            "<li>Battle animations and particles</li>" +
                            "<li>Mega Evolution</li>" +
                            "<li>Contest system</li>" +
                            "<li>Full Pokémon Emerald story implementation</li>" +
                            "<li>Additional Pokémon generations</li>" +
                            "</ul>" +
                            "<p>Future development will continue focusing on modularity and scalability so additional Pokémon " +
                            "generations, battle mechanics, and story systems can be integrated into the project. Long-term goals " +
                            "include recreating the complete Pokémon Emerald experience while supporting expanded post-game and " +
                            "multiplayer-inspired systems.</p>" +
                            "</section>"
                            ),
                    },

                    Media = new()
                    {
                        // full gameplay video
                        new() {
                            Type=MediaType.Video,
                            Url="https://player.vimeo.com/video/1189895191?badge=0&amp;autopause=1&amp;player_id=0&amp;app_id=58479",
                            Caption="Gameplay Walkthrough",
                            Technologies = new()
                            {
                                "unity",
                                "gimp",
                            },
                        },
                        // pokedex
                        new() {
                            Type=MediaType.Video,
                            Url="https://player.vimeo.com/video/1189895485?badge=0&amp;autopause=1&amp;player_id=0&amp;app_id=58479",
                            Caption="Pokedex Screen Walkthrough",
                            Technologies = new()
                            {
                                "unity",
                                "gimp",
                            },
                        },
                        
                        // summary
                        new() {
                            Type=MediaType.Video,
                            Url="https://player.vimeo.com/video/1189895320?badge=0&amp;autopause=1&amp;player_id=0&amp;app_id=58479",
                            Caption="Summary Screen Walkthrough",
                            Technologies = new()
                            {
                                "unity",
                                "gimp",
                            },
                        },
                        
                        // pc box
                        new() {
                            Type=MediaType.Video,
                            Url="https://player.vimeo.com/video/1189895398?badge=0&amp;autopause=1&amp;player_id=0&amp;app_id=58479",
                            Caption="PC Box Screen Walkthrough",
                            Technologies = new()
                            {
                                "unity",
                                "gimp",
                            },
                        },
                    },
                    
                    GitHubUrl = "",
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

                    ProjectContent = new()
                    {
                        new Details("h1", "art"),
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
