using Microsoft.VisualBasic;
using RyleyGoodinePortfolio.Models;
using RyleyGoodinePortfolio.Pages;
using System.Buffers.Text;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Timers;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RyleyGoodinePortfolio.Data
{
    public static class ProjectRepository
    {
        public static List<Project> GetAll() =>
            new()
            {
                // Property Assessment Tool City of Edmonton (wip)
                new Project()
                {
                    Slug = "property-assessment-tool",
                    Title = "Property Assessment Tool for the City of Edmonton",
                    ThumbnailUrl = "",

                    // card description
                    Summary =
                    "<p>The Property Assessment Tool is an interactive dashboard that helps users " +
                    "evaluate Edmonton neighbourhoods using property values, crime statistics, " +
                    "and cultural demographic data.By combining maps, charts, and filtering " +
                    "systems, the application transforms complex civic datasets into clear and " +
                    "accessible insights for relocation and neighbourhood analysis.</p>"
                    ,

                    // paragraph
                    Description =
                    "<p>Moving to a new city or neighbourhood can be a difficult and time-consuming " +
                    "process, requiring individuals to evaluate factors such as housing affordability, " +
                    "safety, accessibility, and cultural fit. However, this information is often " +
                    "fragmented across multiple websites and presented in formats that are difficult " +
                    "to compare or interpret effectively. The Property Assessment Tool was developed " +
                    "to centralize and visualize important neighbourhood data for the City of Edmonton " +
                    "within a single interactive dashboard.</p><br>" +

                    "<p>The application integrates multiple datasets including property assessment values, " +
                    "recent crime reports, and census language distribution data. These datasets are " +
                    "presented through interactive maps, charts, comparison tools, and filtering systems " +
                    "that allow users to explore neighbourhood trends dynamically. Users can search for " +
                    "neighbourhoods, compare multiple areas side-by-side, and interact with geographic " +
                    "visualizations to better understand differences in affordability, safety, and " +
                    "community demographics.</p><br>" +

                    "<p>Built using <strong>Python</strong>, <strong>Pandas</strong>, " +
                    "<strong>Plotly</strong>, and<strong> Dash</strong>, the project emphasizes " +
                    "usability, readability, and responsive interaction design. Geographic mapping is " +
                    "supported through GeoJSON integration, enabling accurate neighbourhood visualization " +
                    "and spatial analysis throughout the dashboard.</p><br>" +

                    "<p>The project demonstrates how modern data visualization techniques can simplify " +
                    "complex civic information and improve decision-making for relocation and urban " +
                    "exploration. While the current implementation relies on static datasets, future " +
                    "improvements include real-time API integration, enhanced analytics, expanded " +
                    "demographic datasets, and advanced map visualization systems.</p><br><br>"
                    ,

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
                        new Details("style", "body {\r\nfont-family: Arial, sans-serif;\r\nline-height: 1.7;\r\nmargin: 0;\r\nbackground: #f4f6f8;\r\ncolor: #222;\r\n    \r\n}\r\n\r\nheader {\r\nbackground: #2d3748;\r\ncolor: white;\r\npadding: 3rem 2rem;\r\ntext-align: center;\r\n}\r\n\r\nmain {\r\nmax-width: 1100px;\r\nmargin: auto;\r\npadding: 2rem;\r\n    \r\n}\r\n\r\nsection {\r\nbackground: white;\r\nmargin-bottom: 2rem;\r\npadding: 2rem;\r\nborder-radius: 12px;\r\nbox-shadow: 0 2px 8px rgba(0,0,0,0.08);\r\n    \r\n}\r\n\r\nh1, h2, h3, h4 {\r\ncolor: #1a202c;\r\n    \r\n}\r\n\r\nh2 {\r\nborder-bottom: 2px solid #e2e8f0;\r\npadding-bottom: 0.5rem;\r\n    \r\n}\r\n\r\nul {\r\npadding-left: 1.5rem;\r\n    \r\n}\r\n\r\n.feature-card {\r\nbackground: #edf2f7;\r\npadding: 1rem;\r\nborder-radius: 8px;\r\nmargin-bottom: 1rem;\r\n    \r\n}\r\n\r\n.code-block {\r\nbackground: #1e1e1e;\r\ncolor: #f8f8f2;\r\npadding: 1rem;\r\nborder-radius: 8px;\r\noverflow-x: auto;\r\n    \r\n}\r\n\r\n.timeline-item {\r\nborder-left: 4px solid #4299e1;\r\npadding-left: 1rem;\r\nmargin-bottom: 1rem;\r\n    \r\n}\r\n\r\nfooter {\r\ntext-align: center;\r\npadding: 2rem;\r\ncolor: #666;\r\n    \r\n}"),

                        new Details("div",
                            "<section>" +
                            "<h1>Property Assessment Tool — City of Edmonton</h1>" +

                            "<p><strong>The Property Assessment Tool</strong> is an interactive " +
                            "neighbourhood analysis dashboard designed to help users evaluate " +
                            "communities within <em>Edmonton, Alberta</em> using multiple " +
                            "civic and demographic datasets.</p>" +
                            
                            "<p>The application combines:</p>" +
                            "<ul>" +
                            "<li><strong>Property assessment values</strong></li>" +
                            "<li><strong>Recent crime statistics</strong></li>" +
                            "<li><strong>Language distribution data</strong></li>" +
                            "<li><strong>Interactive geographic visualization</strong></li>" +
                            "</ul>" +

                            "<p>By consolidating this information into a centralized interface, " +
                            "the dashboard simplifies the process of comparing neighbourhoods " +
                            "and making informed relocation decisions.</p>" +

                            "<p>The project was designed as both a practical relocation tool and " +
                            "a demonstration of modern data visualization principles. Rather " +
                            "than presenting users with disconnected spreadsheets and raw data, " +
                            "the application transforms information into interactive visuals " +
                            "that are easier to understand and navigate.</p>" +

                            "<p>The dashboard emphasizes accessibility and usability for both " +
                            "technical and non-technical users. Interactive charts, geographic " +
                            "mapping, and filtering systems allow users to explore neighbourhood " +
                            "information naturally without requiring prior experience with " +
                            "analytical software.</p>" +
                            "</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Project Purpose</h2>\r\n\r\n    <h3>Problem Statement</h3>\r\n\r\n    <p>\r\n        Relocating to a new city or neighbourhood can be a stressful and\r\n        time-consuming process. Important information related to\r\n        <strong>housing affordability</strong>,\r\n        <strong>safety</strong>, and\r\n        <strong>community demographics</strong>\r\n        is often fragmented across different websites and difficult to interpret.\r\n    </p>\r\n\r\n    <p>\r\n        Many existing systems provide raw data without meaningful visual context,\r\n        forcing users to manually compare neighbourhood information across\r\n        multiple sources.\r\n    </p>\r\n\r\n    <h3>Project Goal</h3>\r\n\r\n    <p>\r\n        This dashboard was created to transform complex civic datasets into\r\n        <em>clear, interactive, and visually accessible insights</em>.\r\n        The goal is to allow users to quickly identify neighbourhood trends\r\n        without requiring specialized analytical or technical knowledge.\r\n    </p>\r\n\r\n    <p>\r\n        In addition to relocation planning, the application also supports\r\n        broader urban analysis by helping users identify patterns in property\r\n        value distribution, safety trends, and cultural composition across\r\n        Edmonton neighbourhoods.\r\n    </p>\r\n\r\n    <p>\r\n        The project demonstrates how data visualization can improve decision\r\n        making by presenting large datasets in a more approachable and\r\n        understandable format.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Core Datasets</h2>\r\n\r\n    <h3>Property Assessment Data</h3>\r\n\r\n    <p>\r\n        Property assessment values are used to provide insight into:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Housing affordability</li>\r\n        <li>Neighbourhood desirability</li>\r\n        <li>Relative property value distribution</li>\r\n        <li>Urban development trends</li>\r\n    </ul>\r\n\r\n    <h3>Crime Data</h3>\r\n\r\n    <p>\r\n        Recent crime reports collected over a\r\n        <strong>90-day period</strong>\r\n        are displayed geographically throughout the dashboard.\r\n    </p>\r\n\r\n    <p>\r\n        Crime information includes:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Crime categories</li>\r\n        <li>Subcategories</li>\r\n        <li>Mapped incident locations</li>\r\n        <li>Interactive filtering systems</li>\r\n    </ul>\r\n\r\n    <h3>Language Distribution Data</h3>\r\n\r\n    <p>\r\n        Census language distribution data from <strong>2016</strong>\r\n        helps visualize the cultural and linguistic composition\r\n        of Edmonton neighbourhoods.\r\n    </p>\r\n\r\n    <p>\r\n        This feature provides additional context for users seeking:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Cultural familiarity</li>\r\n        <li>Diverse communities</li>\r\n        <li>Language accessibility</li>\r\n        <li>Community identity insights</li>\r\n    </ul>\r\n\r\n    <p>\r\n        Combining these datasets creates a more holistic view of Edmonton\r\n        neighbourhoods than any single dataset could provide independently.\r\n        Users are able to analyze relationships between affordability,\r\n        safety, and demographics within the same environment.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Data Visualization & Design</h2>\r\n\r\n    <h3>Visualization Principles</h3>\r\n\r\n    <p>\r\n        The dashboard applies principles of\r\n        <strong>information visualization</strong>\r\n        to simplify large datasets into intuitive visuals.\r\n    </p>\r\n\r\n    <p>\r\n        The design takes inspiration from:\r\n    </p>\r\n\r\n    <ul>\r\n        <li><em>Financial market dashboards</em></li>\r\n        <li><em>COVID-19 tracking systems</em></li>\r\n        <li><em>Google Maps</em></li>\r\n        <li><em>Modern analytical reporting tools</em></li>\r\n    </ul>\r\n\r\n    <h3>Visual Hierarchy</h3>\r\n\r\n    <p>\r\n        The interface emphasizes:\r\n    </p>\r\n\r\n    <ul>\r\n        <li><strong>Clarity</strong></li>\r\n        <li><strong>Whitespace usage</strong></li>\r\n        <li><strong>Colour-coded indicators</strong></li>\r\n        <li><strong>Readable chart layouts</strong></li>\r\n        <li><strong>Accessible interaction patterns</strong></li>\r\n    </ul>\r\n\r\n    <p>\r\n        Geographic maps act as the central focus of the interface while\r\n        supporting charts and filters provide additional contextual analysis.\r\n    </p>\r\n\r\n    <p>\r\n        Colour coding and interactive highlighting are used strategically\r\n        throughout the dashboard to reduce cognitive overload and help users\r\n        quickly identify trends, comparisons, and anomalies between\r\n        neighbourhoods.\r\n    </p>\r\n\r\n    <p>\r\n        The overall design prioritizes readability and responsiveness,\r\n        ensuring that visual information remains understandable even when\r\n        large datasets are displayed simultaneously.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Interactive Features</h2>\r\n\r\n    <h3>Neighbourhood Exploration</h3>\r\n\r\n    <p>\r\n        Users can explore Edmonton neighbourhoods directly through\r\n        interactive maps and filtering systems.\r\n    </p>\r\n\r\n    <p>\r\n        Features include:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Neighbourhood search functionality</li>\r\n        <li>Dynamic chart updates</li>\r\n        <li>Property value filtering</li>\r\n        <li>Crime category filtering</li>\r\n        <li>Map-based interaction</li>\r\n    </ul>\r\n\r\n    <h3>Comparison Tools</h3>\r\n\r\n    <p>\r\n        A comparison interface allows users to evaluate multiple\r\n        neighbourhoods simultaneously.\r\n    </p>\r\n\r\n    <p>\r\n        Comparison metrics include:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Average property value</li>\r\n        <li>Crime distribution</li>\r\n        <li>Language demographics</li>\r\n        <li>Neighbourhood trends</li>\r\n    </ul>\r\n\r\n    <p>\r\n        User interaction dynamically updates multiple visual components\r\n        simultaneously, creating a more responsive and connected analytical\r\n        experience. Selecting a neighbourhood on the map immediately updates\r\n        charts, filters, and statistical summaries across the interface.\r\n    </p>\r\n\r\n    <p>\r\n        This interconnected system improves exploration efficiency and allows\r\n        users to compare neighbourhoods more naturally than traditional static\r\n        reporting methods.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Technical Implementation</h2>\r\n\r\n    <h3>Technologies Used</h3>\r\n\r\n    <ul>\r\n        <li><strong>Python</strong> — Core application logic</li>\r\n        <li><strong>Pandas</strong> — Data processing and analysis</li>\r\n        <li><strong>Plotly</strong> — Interactive charts and visualizations</li>\r\n        <li><strong>Dash</strong> — Web dashboard framework</li>\r\n        <li><strong>GeoJSON</strong> — Geographic boundary mapping</li>\r\n    </ul>\r\n\r\n    <h3>Application Architecture</h3>\r\n\r\n    <p>\r\n        The dashboard processes raw CSV datasets using pandas before\r\n        transforming the information into interactive visualizations\r\n        through Plotly and Dash components.\r\n    </p>\r\n\r\n    <p>\r\n        Geographic data is integrated using GeoJSON neighbourhood boundaries,\r\n        allowing accurate map rendering and spatial analysis throughout\r\n        the interface.\r\n    </p>\r\n\r\n    <p>\r\n        The modular structure of the application simplifies future expansion\r\n        and maintenance. Additional datasets and visualization systems can be\r\n        integrated without requiring significant architectural redesign.\r\n    </p>\r\n\r\n    <p>\r\n        Dash callback systems are used extensively to synchronize user input,\r\n        filtering systems, and chart updates in real time. This allows the\r\n        interface to behave more like a responsive analytical platform rather\r\n        than a traditional static webpage.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Current Limitations</h2>\r\n\r\n    <h3>Static Data Sources</h3>\r\n\r\n    <p>\r\n        The project currently relies on\r\n        <strong>static CSV datasets</strong>,\r\n        which limits scalability and prevents real-time updates.\r\n    </p>\r\n\r\n    <h3>Property Information Constraints</h3>\r\n\r\n    <p>\r\n        Current property data primarily focuses on assessment values and\r\n        does not yet include:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Real-time property listings</li>\r\n        <li>Historical sales data</li>\r\n        <li>Transit proximity</li>\r\n        <li>School information</li>\r\n        <li>Nearby amenities</li>\r\n    </ul>\r\n\r\n    <h3>Crime Data Challenges</h3>\r\n\r\n    <p>\r\n        Certain crime datasets are not directly linked to official\r\n        neighbourhood boundaries, which can make some statistical\r\n        comparisons less precise.\r\n    </p>\r\n\r\n    <p>\r\n        Performance can also become a concern when rendering large datasets\r\n        and multiple interactive charts simultaneously, especially on systems\r\n        with limited processing power.\r\n    </p>\r\n</section>\r\n"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Future Improvements</h2>\r\n\r\n    <h3>Planned Features</h3>\r\n\r\n    <ul>\r\n        <li>Real-time API integration</li>\r\n        <li>Expanded property datasets</li>\r\n        <li>Transit and amenity overlays</li>\r\n        <li>Crime heatmap visualization</li>\r\n        <li>Advanced demographic analytics</li>\r\n        <li>Improved map interaction systems</li>\r\n    </ul>\r\n\r\n    <h3>Scalability Goals</h3>\r\n\r\n    <p>\r\n        Future versions of the dashboard aim to improve both\r\n        <strong>performance</strong> and\r\n        <strong>analytical depth</strong>\r\n        while maintaining accessibility for general users.\r\n    </p>\r\n\r\n    <p>\r\n        Additional integrations with mapping platforms and municipal APIs\r\n        could significantly expand the usefulness of the application.\r\n    </p>\r\n\r\n    <p>\r\n        Potential future enhancements also include predictive analytics,\r\n        neighbourhood trend forecasting, and personalized recommendation\r\n        systems based on user preferences and priorities.\r\n    </p>\r\n\r\n    <p>\r\n        Expanding the application beyond Edmonton could transform the project\r\n        into a broader urban analysis platform capable of supporting multiple\r\n        cities and regional datasets.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Evaluation & Testing</h2>\r\n\r\n    <p>\r\n        User testing is an important component of future development.\r\n        Feedback related to usability, readability, and navigation flow\r\n        would guide iterative improvements to the interface.\r\n    </p>\r\n\r\n    <p>\r\n        Performance optimization would also be prioritized to improve:\r\n    </p>\r\n\r\n    <ul>\r\n        <li>Data processing speed</li>\r\n        <li>Chart rendering performance</li>\r\n        <li>Map responsiveness</li>\r\n        <li>Filtering efficiency</li>\r\n    </ul>\r\n\r\n    <p>\r\n        Accessibility testing would also help ensure the dashboard remains\r\n        usable for individuals with varying levels of technical experience\r\n        and visual accessibility requirements.\r\n    </p>\r\n</section>"
                            ),

                        new Details("div",
                            "<section>\r\n    <h2>Conclusion</h2>\r\n\r\n    <p>\r\n        The Property Assessment Tool demonstrates how\r\n        <strong>data visualization</strong>\r\n        and\r\n        <strong>interactive analytics</strong>\r\n        can be applied to solve real-world urban planning and relocation challenges.\r\n    </p>\r\n\r\n    <p>\r\n        By centralizing property assessments, crime statistics, and cultural\r\n        insights into a single interface, the dashboard improves accessibility\r\n        to civic information and empowers users to make more informed decisions\r\n        about where to live.\r\n    </p>\r\n\r\n    <p>\r\n        The project also highlights the importance of combining technical\r\n        implementation with thoughtful user experience design. Effective\r\n        visualization systems can make large datasets significantly more\r\n        understandable and approachable for everyday users.\r\n    </p>\r\n\r\n    <p>\r\n        With continued development, expanded datasets, and enhanced interactivity,\r\n        the project has strong potential to evolve into a comprehensive\r\n        neighbourhood exploration and property analysis platform.\r\n    </p>\r\n</section>"
                            ),
                    },

                    // images and videos
                    Media = new() { },

                    GitHubUrl = "https://github.com/ripclaw52/pythonPandasAndNumpyTestProject.git",
                },

                // ETS Bus Safety User Experience Redesign (wip)
                new Project()
                {
                    Slug = "ets-bus-safety-redesign",
                    Title = "ETS Bus Safety User Experience Redesign",
                    ThumbnailUrl = "",
                    Summary = "Redesigned user experience for Edmonton Transit bus safety reporting system.",
                    Description = "Focused on improving accessibility, clarity, and user engagement.",
                    Technologies = new()
                    {
                        "figma",
                        "adobe_xd",
                        "photoshop",
                        "illustrator",
                        "acrobat",
                        "word",
                    },
                    ProjectContent = new()
                    {
                        new Details("h1", "ets bus safety redesign"),
                    },
                    Media = new()
                    {
                        // full redesign video
                        new() {
                            Type=MediaType.Video,
                            Url="https://player.vimeo.com/video/1189895191?badge=0&amp;autopause=1&amp;player_id=0&amp;app_id=58479",
                            Caption="Full Redesign Walkthrough",
                            Technologies = new()
                            {
                                "figma",
                                "adobe_xd",
                                "photoshop",
                                "illustrator",
                            },
                        },
                    },
                    GitHubUrl = "",
                },

                // Pokémon Capstone Project (wip)
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

                // art Work (wip)
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
