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
                    Id = "property-assessment-tool",
                    Title = "Property Assessment Tool for the City of Edmonton",
                    ImageUrl = "",

                    // card description
                    Summary =
                    "<p>The Property Assessment Tool is an interactive dashboard that uses maps, charts, and civic data to help users evaluate and compare Edmonton neighbourhoods for relocation and urban analysis.</p>"
                    ,

                    // paragraph
                    Description = @"
                    <p>The Property Assessment Tool centralizes housing affordability, crime, and demographic 
                    data for the City of Edmonton into a single interactive dashboard, helping users compare 
                    neighbourhoods and make informed relocation decisions. Built with <strong>Python</strong>, 
                    <strong>Pandas</strong>, <strong>Plotly</strong>, and <strong>Dash</strong>, it combines 
                    interactive maps, charts, and filtering tools with GeoJSON-based visualizations to simplify
                    the exploration of complex civic data.</p><br/>",

                    /* OLD DESCRIPTION
                    "<p>Moving to a new city or neighbourhood can be a difficult and time-consuming " +
                    "process, requiring individuals to evaluate factors such as housing affordability, " +
                    "safety, accessibility, and cultural fit. However, this information is often " +
                    "fragmented across multiple websites and presented in formats that are difficult " +
                    "to compare or interpret effectively. The Property Assessment Tool was developed " +
                    "to centralize and visualize important neighbourhood data for the City of Edmonton " +
                    "within a single interactive dashboard.</p><br/>" +

                    "<p>The application integrates multiple datasets including property assessment values, " +
                    "recent crime reports, and census language distribution data. These datasets are " +
                    "presented through interactive maps, charts, comparison tools, and filtering systems " +
                    "that allow users to explore neighbourhood trends dynamically. Users can search for " +
                    "neighbourhoods, compare multiple areas side-by-side, and interact with geographic " +
                    "visualizations to better understand differences in affordability, safety, and " +
                    "community demographics.</p><br/>" +

                    "<p>Built using <strong>Python</strong>, <strong>Pandas</strong>, " +
                    "<strong>Plotly</strong>, and<strong> Dash</strong>, the project emphasizes " +
                    "usability, readability, and responsive interaction design. Geographic mapping is " +
                    "supported through GeoJSON integration, enabling accurate neighbourhood visualization " +
                    "and spatial analysis throughout the dashboard.</p><br/>" +

                    "<p>The project demonstrates how modern data visualization techniques can simplify " +
                    "complex civic information and improve decision-making for relocation and urban " +
                    "exploration. While the current implementation relies on static datasets, future " +
                    "improvements include real-time API integration, enhanced analytics, expanded " +
                    "demographic datasets, and advanced map visualization systems.</p><br/><br/>"
                    */

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

                    ProjectBlocks = new()
                    {
                        // style sheet
                        /**/
                        new ProjectBlock {
                            Type = BlockType.Html,
                            Content = @"<style>
body
{
font-family: Arial, sans-serif;
line-height: 1.7;
margin: 0;
background: #f4f6f8;
color: #222;
}

header
{
background: #2d3748;
color: white;
padding: 3rem 2rem;
text-align: center;
}

main
{
max-width: 1100px;
margin: auto;
padding: 2rem;
}

section
{
background: white;
margin-bottom: 2rem;
padding: 2rem;
border-radius: 12px;
box-shadow: 0 2px 8px rgba(0,0,0,0.08);
} 

h1, h2, h3, h4
{
color: #1a202c;
}

h2
{
border-bottom: 2px solid #e2e8f0;
padding-bottom: 0.5rem;
}

ul
{
padding-left: 1.5rem;
}

.feature-card
{
background: #edf2f7;
padding: 1rem;
border-radius: 8px;
margin-bottom: 1rem;
}

.code-block
{
background: #1e1e1e;
color: #f8f8f2;
padding: 1rem;
border-radius: 8px;
overflow-x: auto;
}

.timeline-item
{
border-left: 4px solid #4299e1;
padding-left: 1rem;
margin-bottom: 1rem;
}

footer
{
text-align: center;
padding: 2rem;
color: #666;
}
</style>"
                        },
                        /**/

                        // hero intro
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h1>Edmonton Property Assessment Visualization Tool</h1>

<p>An interactive data visualization platform developed to help
Edmonton residents explore residential property assessments,
neighborhood trends, and municipal housing data.</p>

<p>Built as part of CMPT 450 Information Visualization,
the project focused on transforming complex assessment data
into meaningful visual insights.</p>
</section>"
                        },

                        // hero video
                        /*
                        new ProjectBlock
                        {
                            Type = BlockType.Video,
                            Url = "https://dai.ly/xad0i18",
                            Caption = "Project Overview Demonstration"
                        },
                        */

                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h1>Property Assessment Tool — City of Edmonton</h1>
<p><strong>The Property Assessment Tool</strong> is an interactive
neighbourhood analysis dashboard designed to help users evaluate
communities within <em>Edmonton, Alberta</em> using multiple
civic and demographic datasets.</p>

<p>The application combines:</p>
<ul>
<li><strong>Property assessment values</strong></li>
<li><strong>Recent crime statistics</strong></li>
<li><strong>Language distribution data</strong></li>
<li><strong>Interactive geographic visualization</strong></li>
</ul>

<p>By consolidating this information into a centralized interface,
the dashboard simplifies the process of comparing neighbourhoods
and making informed relocation decisions.</p>

<p>The project was designed as both a practical relocation tool and
a demonstration of modern data visualization principles. Rather
than presenting users with disconnected spreadsheets and raw data,
the application transforms information into interactive visuals
that are easier to understand and navigate.</p>

<p>The dashboard emphasizes accessibility and usability for both
technical and non-technical users. Interactive charts, geographic
mapping, and filtering systems allow users to explore neighbourhood
information naturally without requiring prior experience with
analytical software.</p>
</section>"
                        },

                        // project purpose
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Project Purpose</h2>

<h3>Problem Statement</h3>
<p>Relocating to a new city or neighbourhood can be a stressful and
time-consuming process. Important information related to
<strong>housing affordability</strong>,
<strong>safety</strong>, and
<strong>community demographics</strong>
is often fragmented across different websites and difficult to interpret.</p>

<p>Many existing systems provide raw data without meaningful visual context,
forcing users to manually compare neighbourhood information across
multiple sources.</p>

<h3>Project Goal</h3>
<p>This dashboard was created to transform complex civic datasets into
<em>clear, interactive, and visually accessible insights</em>.
The goal is to allow users to quickly identify neighbourhood trends
without requiring specialized analytical or technical knowledge.</p>

<p>In addition to relocation planning, the application also supports
broader urban analysis by helping users identify patterns in property
value distribution, safety trends, and cultural composition across
Edmonton neighbourhoods.</p>

<p>The project demonstrates how data visualization can improve decision 
making by presenting large datasets in a more approachable and understandable format.</p>
</section>"
                        },

                        // core datasets
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Core Datasets</h2>
<h3>Property Assessment Data</h3>
<p>Property assessment values are used to provide insight into:</p>
<ul>
<li>Housing affordability</li>
<li>Neighbourhood desirability</li>
<li>Relative property value distribution</li>
<li>Urban development trends</li>
</ul>

<h3>Crime Data</h3>
<p>Recent crime reports collected over a <strong>90-day period</strong> 
are displayed geographically throughout the dashboard.</p>
<p>Crime information includes:</p>
<ul>
<li>Crime categories</li>
<li>Subcategories</li>
<li>Mapped incident locations</li>
<li>Interactive filtering systems</li>
</ul>

<h3>Language Distribution Data</h3>
<p>Census language distribution data from <strong>2016</strong> 
helps visualize the cultural and linguistic composition of Edmonton neighbourhoods.</p>
<p>This feature provides additional context for users seeking:</p>
<ul>
<li>Cultural familiarity</li>
<li>Diverse communities</li>
<li>Language accessibility</li>
<li>Community identity insights</li>
</ul>
<p>Combining these datasets creates a more holistic view of Edmonton 
neighbourhoods than any single dataset could provide independently. 
Users are able to analyze relationships between affordability, 
safety, and demographics within the same environment.</p>
</section>"
                        },

                        // data visualization and design principles
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Data Visualization & Design</h2>
<h3>Visualization Principles</h3>
<p>
The dashboard applies principles of <strong>information visualization</strong> 
to simplify large datasets into intuitive visuals.</p>
<p>The design takes inspiration from:</p>
<ul>
<li><em>Financial market dashboards</em></li>
<li><em>COVID-19 tracking systems</em></li>
<li><em>Google Maps</em></li>
<li><em>Modern analytical reporting tools</em></li>
</ul>

<h3>Visual Hierarchy</h3>
<p>The interface emphasizes:</p>
<ul>
<li><strong>Clarity</strong></li>
<li><strong>Whitespace usage</strong></li>
<li><strong>Colour-coded indicators</strong></li>
<li><strong>Readable chart layouts</strong></li>
<li><strong>Accessible interaction patterns</strong></li>
</ul>
<p>Geographic maps act as the central focus of the interface while 
supporting charts and filters provide additional contextual analysis.</p>
<p>Colour coding and interactive highlighting are used strategically 
throughout the dashboard to reduce cognitive overload and help users 
quickly identify trends, comparisons, and anomalies between neighbourhoods.</p>
<p>The overall design prioritizes readability and responsiveness, 
ensuring that visual information remains understandable even when 
large datasets are displayed simultaneously.</p>
</section>"
                        },

                        // graph and chart gallery
                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new List<ProjectMedia>
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/073a82d2fccf.png",
                                    Caption = "Neighbourhood Comparison by Language Bar Graph"
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/1a6b57c1f242.png",
                                    Caption = "Edmonton Crime Filter"
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/5585ebfac7dc.png",
                                    Caption = "Language Occurrence by Household within Neighbourhoods"
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://geo.dailymotion.com/player.html?video=xahbdem",
                                    Caption = "Property Assessment and Language Demographics by Neighbourhood"
                                },
                            }
                        },



                        // interactive features
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Interactive Features</h2>
<h3>Neighbourhood Exploration</h3>
<p>Users can explore Edmonton neighbourhoods directly through 
interactive maps and filtering systems.</p>
<p>Features include:</p>
<ul>
<li>Neighbourhood search functionality</li>
<li>Dynamic chart updates</li>
<li>Property value filtering</li>
<li>Crime category filtering</li>
<li>Map-based interaction</li>
</ul>

<h3>Comparison Tools</h3>
<p>A comparison interface allows users to evaluate multiple 
neighbourhoods simultaneously.</p>
<p>Comparison metrics include:</p>
<ul>
<li>Average property value</li>
<li>Crime distribution</li>
<li>Language demographics</li>
<li>Neighbourhood trends</li>
</ul>
<p>User interaction dynamically updates multiple visual components 
simultaneously, creating a more responsive and connected analytical 
experience. Selecting a neighbourhood on the map immediately updates 
charts, filters, and statistical summaries across the interface.</p>
<p>This interconnected system improves exploration efficiency and allows 
users to compare neighbourhoods more naturally than traditional static reporting methods.</p>
</section>"
                        },
                        
                        // interactive gallery images
                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new List<ProjectMedia>
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/3debbd0e646b.png",
                                    Caption = "Neighbourhood Assessment Map"
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/2ae5f7e87b6a.png",
                                    Caption = "Neighbourhood Assessment Map with Crime Occurences"
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://geo.dailymotion.com/player.html?video=xad0i1a",
                                    Caption = "Property Assessment Walkthrough Video"
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://geo.dailymotion.com/player.html?video=xad0i1e",
                                    Caption = "Property Assessment Walkthrough Video 2",
                                }
                            }
                        },


                        // technical implementation
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Technical Implementation</h2>
<h3>Technologies Used</h3>
<ul>
<li><strong>Python</strong> — Core application logic</li>
<li><strong>Pandas</strong> — Data processing and analysis</li>
<li><strong>Plotly</strong> — Interactive charts and visualizations</li>
<li><strong>Dash</strong> — Web dashboard framework</li>
<li><strong>GeoJSON</strong> — Geographic boundary mapping</li>
</ul>

<h3>Application Architecture</h3>
<p>The dashboard processes raw CSV datasets using pandas before 
transforming the information into interactive visualizations 
through Plotly and Dash components.</p>
<p>Geographic data is integrated using GeoJSON neighbourhood boundaries, 
allowing accurate map rendering and spatial analysis throughout the interface.</p>
<p>The modular structure of the application simplifies future expansion 
and maintenance. Additional datasets and visualization systems can be 
integrated without requiring significant architectural redesign.</p>
<p>Dash callback systems are used extensively to synchronize user input, 
filtering systems, and chart updates in real time. This allows the 
interface to behave more like a responsive analytical platform rather 
than a traditional static webpage.</p>
</section>"
                        },

                        // code snippets
                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new List<ProjectMedia>
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/1269d8da0d85.png",
                                    Caption = "Python Code Snippet 01"
                                },
                                
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/d0f57bd64a7d.png",
                                    Caption = "Python Code Snippet 02"
                                },
                                
                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://geo.dailymotion.com/player.html?video=xad0i1c",
                                    Caption = "Property Assessment Code behind"
                                },
                            }
                        },


                        // current limitations
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Current Limitations</h2>
<h3>Static Data Sources</h3>
<p>The project currently relies on <strong>static CSV datasets</strong>, 
which limits scalability and prevents real-time updates.</p>

<h3>Property Information Constraints</h3>
<p>Current property data primarily focuses on assessment values and does not yet include:</p>
<ul>
<li>Real-time property listings</li>
<li>Historical sales data</li>
<li>Transit proximity</li>
<li>School information</li>
<li>Nearby amenities</li>
</ul>

<h3>Crime Data Challenges</h3>
<p>Certain crime datasets are not directly linked to official 
neighbourhood boundaries, which can make some statistical 
comparisons less precise.</p>
<p>Performance can also become a concern when rendering large datasets 
and multiple interactive charts simultaneously, especially on systems 
with limited processing power.</p>
</section>"
                        },

                        // future improvements
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Future Improvements</h2>
<h3>Planned Features</h3>
<ul>
<li>Real-time API integration</li>
<li>Expanded property datasets</li>
<li>Transit and amenity overlays</li>
<li>Crime heatmap visualization</li>
<li>Advanced demographic analytics</li>
<li>Improved map interaction systems</li>
</ul>

<h3>Scalability Goals</h3>
<p>Future versions of the dashboard aim to improve both 
<strong>performance</strong> and 
<strong>analytical depth</strong> 
while maintaining accessibility for general users.</p>
<p>Additional integrations with mapping platforms and municipal APIs 
could significantly expand the usefulness of the application.</p>
<p>Potential future enhancements also include predictive analytics, 
neighbourhood trend forecasting, and personalized recommendation 
systems based on user preferences and priorities.</p>
<p>Expanding the application beyond Edmonton could transform the project 
into a broader urban analysis platform capable of supporting multiple 
cities and regional datasets.</p>
</section>"
                        },

                        // evaluation and testing
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Evaluation & Testing</h2>
<p>User testing is an important component of future development. 
Feedback related to usability, readability, and navigation flow 
would guide iterative improvements to the interface.</p>
<p>Performance optimization would also be prioritized to improve:</p>
<ul>
<li>Data processing speed</li>
<li>Chart rendering performance</li>
<li>Map responsiveness</li>
<li>Filtering efficiency</li>
</ul>
<p>Accessibility testing would also help ensure the dashboard remains 
usable for individuals with varying levels of technical experience 
and visual accessibility requirements.</p>
</section>"
                        },

                        // conclusion
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = @"
<section>
<h2>Conclusion</h2>
<p>The Property Assessment Tool demonstrates how <strong>data visualization</strong> 
and <strong>interactive analytics</strong> can be applied to solve real-world urban planning and relocation challenges.</p>
<p>By centralizing property assessments, crime statistics, and cultural 
insights into a single interface, the dashboard improves accessibility 
to civic information and empowers users to make more informed decisions about where to live.</p>
<p>The project also highlights the importance of combining technical 
implementation with thoughtful user experience design. Effective 
visualization systems can make large datasets significantly more 
understandable and approachable for everyday users.</p>
<p>With continued development, expanded datasets, and enhanced interactivity, 
the project has strong potential to evolve into a comprehensive 
neighbourhood exploration and property analysis platform.</p>
</section>"
                        },

                    },

                    // each string is a paragraph of content for the project page
                    ProjectContent = new()
                    {
                    },

                    // images and videos
                    Media = new() { },

                    GitHubUrl = "https://github.com/ripclaw52/pythonPandasAndNumpyTestProject.git",
                },

                // ETS Bus Safety User Experience Redesign (wip)
                new Project()
                {
                    Id = "ets-bus-safety-redesign",
                    Title = "ETS Bus Safety User Experience Redesign",
                    ImageUrl = "",
                    
                    //
                    Summary =
                    "<p>ReportIt is a conceptual ETS reporting platform that enables riders to quickly report non-emergency transit " +
                    "issues through an accessible web-based interface.</p>",

                    //
                    Description =
                    "<p>ReportIt is a user-focused service design project created to improve the " +
                    "reporting experience for non-emergency issues within the Edmonton Transit " +
                    "Service (ETS) system. The project addresses challenges related to rider " +
                    "safety, communication, and public engagement by providing a fast and " +
                    "accessible reporting platform that allows users to submit concerns related " +
                    "to cleanliness, damaged infrastructure, accessibility issues, and unsafe " +
                    "behaviour.</p><br/>" +

                    "<p>The system was developed through user research, ecosystem mapping, and " +
                    "journey analysis to better understand how riders interact with transit " +
                    "environments and existing communication systems. The project emphasizes " +
                    "accessibility, simplicity, and low-friction interaction by supporting " +
                    "browser-based reporting through QR codes and lightweight mobile interfaces " +
                    "rather than requiring dedicated applications.</p><br/>" +

                    "<p>ReportIt also explores how stronger rider participation and communication " +
                    "could improve public perception of ETS while encouraging a greater sense of " +
                    "ownership and accountability within transit spaces. Future opportunities " +
                    "include integration with official ETS systems, gamified engagement features, " +
                    "accessibility-focused reporting tools, and expanded community moderation " +
                    "systems.</p><br/><br/>",

                    //
                    Technologies = new()
                    {
                        "figma",
                        "adobe_xd",
                        "photoshop",
                        "illustrator",
                        "acrobat",
                        "word",
                    },

                    //
                    ProjectBlocks = new()
                    {
                        // intro
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h1>ReportIt — ETS Non-Emergency Reporting System</h1>" +

                            "<p><strong>ReportIt</strong> is a conceptual non-emergency reporting platform designed for the " +
                            "<strong>Edmonton Transit Service (ETS)</strong>. The project focuses on improving rider safety, " +
                            "communication, accountability, and public engagement through a fast and accessible reporting system.</p>" +

                            "<p>Developed as part of a <em>DESN445 design project</em>, the system encourages riders to participate in " +
                            "maintaining safer and cleaner transit environments while creating a stronger connection between transit " +
                            "users and ETS operations.</p>" +
                            "</section>",
                        },

                        // design challenge
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Design Challenge</h2>" +
                            "<blockquote><p>“How might we engage a sense of ownership of ETS facilities by riders, so that we can improve " +
                            "ETS ridership, safety, security, and accountability?”</p></blockquote>" +

                            "<p>The project addresses the lack of accessible communication channels for reporting <strong>non-emergency " +
                            "transit issues</strong>. Many riders either ignore problems or become frustrated when existing systems fail to " +
                            "clearly distinguish between emergency and non-emergency reporting. </p>" +

                            "<p>ReportIt was designed to bridge this gap by creating a simple, low-friction reporting experience that " +
                            "empowers riders to contribute directly to improving transit spaces.</p>" +
                            "</section>",
                        },

                        // project goals
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Project Goals</h2>" +

                            "<ul>" +
                            "<li>Improve rider safety and comfort</li>" +
                            "<li>Create a stronger sense of public ownership</li>" +
                            "<li>Increase communication between riders and ETS</li>" +
                            "<li>Provide fast and accessible non-emergency reporting</li>" +
                            "<li>Encourage rider participation in transit improvement</li>" +
                            "<li>Improve public perception of ETS services</li>" +
                            "</ul>" +

                            "<p>The system was designed with accessibility and simplicity as core priorities, ensuring that riders can " +
                            "quickly submit reports without complicated workflows or lengthy forms.</p>" +
                            "</section>",
                        },

                        // target audience
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Target Audience</h2>" +

                            "<h3>Primary Users</h3>" +
                            "<ul>" +
                            "<li>ETS riders aged 16+</li>" +
                            "<li>Daily commuters</li>" +
                            "<li>Transit-dependent users</li>" +
                            "<li>Riders interested in community engagement</li>" +
                            "</ul>" +

                            "<h3>User Needs</h3>" +
                            "<p>User research identified several consistent rider priorities:</p>" +
                            "<ul>" +
                            "<li>Safe transit environments</li>" +
                            "<li>Clean facilities and stations</li>" +
                            "<li>Reliable communication from ETS</li>" +
                            "<li>Fast issue resolution</li>" +
                            "<li>Clear distinction between emergency and non-emergency reporting</li>" +
                            "</ul>" +

                            "<p>Riders also expressed frustration when reporting systems lacked visible follow-up or confirmation that " +
                            "issues were being addressed.</p>" +
                            "</section>",
                        },

                        // user journey
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>User Journey</h2>" +

                            "<h3>Phase 1 — Outside the Transit Ecosystem</h3>" +
                            "<p>Riders evaluate transit spaces before entering stations or bus stops. Initial impressions are heavily " +
                            "influenced by environmental conditions and visible safety concerns.</p>" +
                            "<ul>" +
                            "<li>Facility accessibility</li>" +
                            "<li>Station cleanliness</li>" +
                            "<li>Crowding and rider density</li>" +
                            "<li>Perceived safety</li>" +
                            "</ul>" +

                            "<h3>Phase 2 — Entering the Transit System</h3>" +
                            "<p>Riders begin interacting with ETS systems including ticket kiosks, trip planning tools, and physical " +
                            "infrastructure.</p>" +

                            "<h3>Phase 3 — Application Awareness</h3>" +
                            "<p>Awareness of the reporting system is introduced through:</p>" +
                            "<ul>" +
                            "<li>QR codes</li>" +
                            "<li>Digital signage</li>" +
                            "<li>Transit advertisements</li>" +
                            "<li>ETS informational displays</li>" +
                            "</ul>" +

                            "<h3>Phase 4 — Onboard Experience</h3>" +
                            "<p>Riders continue interacting with transit services while potentially encountering new issues such as:</p>" +
                            "<ul>" +
                            "<li>Dirty facilities</li>" +
                            "<li>Broken accessibility systems</li>" +
                            "<li>Damaged infrastructure</li>" +
                            "<li>Unsafe rider behavior</li>" +
                            "</ul>" +

                            "<h3>Phase 5 — Reporting & Follow-Up</h3>" +
                            "<p>Riders can submit reports quickly at any point during their journey. Confirmation and follow-up notifications " +
                            "help reinforce trust and encourage continued engagement with the system.</p>" +
                            "</section>",
                        },

                        // ecosystem mapping
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Ecosystem Mapping</h2>" +
                            "<p>The project included a detailed ecosystem map identifying all major touchpoints within the ETS transit " +
                            "environment.</p>" +

                            "<h3>Physical Touchpoints</h3>" +
                            "<ul>" +
                            "<li>Bus stops</li>" +
                            "<li>LRT stations</li>" +
                            "<li>Bus shelters</li>" +
                            "<li>Security phones</li>" +
                            "<li>Ticket kiosks</li>" +
                            "<li>Transit vehicles</li>" +
                            "</ul>" +

                            "<h3>Digital Touchpoints</h3>" +
                            "<ul>" +
                            "<li>ETS mobile applications</li>" +
                            "<li>Trip planning systems</li>" +
                            "<li>Transit Watch communication tools</li>" +
                            "<li>Digital station displays</li>" +
                            "<li>QR code systems</li>" +
                            "</ul>" +

                            "<h3>Security Systems</h3>" +
                            "<ul>" +
                            "<li>CCTV monitoring</li>" +
                            "<li>Transit operators</li>" +
                            "<li>Peace officers</li>" +
                            "<li>Emergency communication systems</li>" +
                            "<li>Control centres</li>" +
                            "</ul>" +
                            "<p>Mapping these systems helped identify opportunities for integrating reporting features directly into " +
                            "existing rider workflows.</p>" +
                            "</section>",
                        },

                        // core features
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Core Features</h2>" +

                            "<h3>Fast Non-Emergency Reporting</h3>" +
                            "<p>The reporting process was intentionally designed to minimize friction and allow riders to quickly submit " +
                            "issues without requiring extensive input or account creation.</p>" +

                            "<h3>Accessible Web-Based System</h3>" +
                            "<p>Users emphasized the importance of avoiding mandatory app downloads. The concept therefore supports " +
                            "browser-based reporting through QR codes and lightweight mobile interfaces.</p>" +

                            "<h3>Communication & Feedback</h3>" +
                            "<p>Riders strongly preferred systems that provided:</p>" +
                            "<ul>" +
                            "<li>Report confirmation messages</li>" +
                            "<li>Status updates</li>" +
                            "<li>Visible action from ETS</li>" +
                            "<li>Responsive communication channels</li>" +
                            "</ul>" +
                            "<p>Without visible follow-up, many users indicated they would stop using the reporting service entirely.</p>" +
                            "</section>",
                        },

                        // user testing and research findings
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>User Testing & Research Findings</h2>" +

                            "<h3>Key Insights</h3>" +
                            "<ul>" +
                            "<li>Dirty facilities were a major rider concern</li>" +
                            "<li>Broken accessibility services were frequently prioritized</li>" +
                            "<li>Reporting must be extremely fast and simple</li>" +
                            "<li>Personal information requirements discouraged usage</li>" +
                            "<li>QR codes should be placed near high-problem areas</li>" +
                            "</ul>" +

                            "<h3>Recommended QR Code Locations</h3>" +
                            "<ul>" +
                            "<li>Elevators</li>" +
                            "<li>Bathrooms</li>" +
                            "<li>Ticket kiosks</li>" +
                            "<li>Transit shelters</li>" +
                            "<li>Damaged infrastructure areas</li>" +
                            "</ul>" +
                            "<p>Riders also expressed interest in reporting broader community and safety concerns beyond traditional transit " +
                            "maintenance issues.</p>" +
                            "</section>",
                        },

                        // benefits to riders and city
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Benefits to Riders & the City</h2>" +
                            "<ul>" +
                            "<li>Improved public perception of ETS</li>" +
                            "<li>Potential increase in transit ridership</li>" +
                            "<li>Greater rider engagement and accountability</li>" +
                            "<li>Improved communication between ETS and citizens</li>" +
                            "<li>Increased sense of ownership over public transit spaces</li>" +
                            "</ul>" +
                            "<p>By involving riders directly in identifying and reporting issues, the project aims to create safer and more " +
                            "community-oriented transit environments.</p>" +
                            "</section>",
                        },

                        // limitations and challenges
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Limitations & Challenges</h2>" +

                            "<h3>Project Limitations</h3>" +
                            "<ul>" +
                            "<li>Limited user testing scope</li>" +
                            "<li>Limited access to ETS operational systems</li>" +
                            "<li>Need for deeper ridership analysis</li>" +
                            "<li>Potential misuse of reporting systems</li>" +
                            "</ul>" +

                            "<h3>Security Concerns</h3>" +
                            "<p>One identified risk involved malicious replacement of QR codes, potentially redirecting users to fraudulent " +
                            "or unsafe websites.</p>" +
                            "<p>Additional concerns included abuse of future incentive systems or intentionally false reporting " +
                            "submissions.</p>" +
                            "</section>",
                        },

                        // future opportunities
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Future Opportunities</h2>" +
                            "<ul>" +
                            "<li>Integration directly into official ETS applications</li>" +
                            "<li>Gamified rider engagement systems</li>" +
                            "<li>Transit reward or fare discount incentives</li>" +
                            "<li>Expanded accessibility reporting tools</li>" +
                            "<li>Community moderation systems</li>" +
                            "<li>Enhanced rider accountability systems</li>" +
                            "</ul>" +
                            "<p>Future iterations could encourage stronger community responsibility and potentially reduce vandalism, " +
                            "littering, and misuse of public transit spaces.</p>" +
                            "</section>",
                        },

                        // conclusion
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Conclusion</h2>" +
                            "<p>ReportIt demonstrates how service design and user experience research can be applied to improve public " +
                            "transportation systems through better communication and community engagement.</p>" +
                            "<p>By creating an accessible and responsive reporting system, the project encourages riders to actively " +
                            "participate in maintaining safer, cleaner, and more accountable transit environments across Edmonton.</p>" +
                            "</section>",
                        },

                    },

                    //
                    ProjectContent = new()
                    {
                        new Details("style", "body { font-family: Arial, sans-serif; line-height: 1.7; margin: 0; background: #f4f6f8; color: #222;      }  header { background: #2d3748; color: white; padding: 3rem 2rem; text-align: center; }  main { max-width: 1100px; margin: auto; padding: 2rem;      }  section { background: white; margin-bottom: 2rem; padding: 2rem; border-radius: 12px; box-shadow: 0 2px 8px rgba(0,0,0,0.08);      }  h1, h2, h3, h4 { color: #1a202c;      }  h2 { border-bottom: 2px solid #e2e8f0; padding-bottom: 0.5rem;      }  ul { padding-left: 1.5rem;      }  .feature-card { background: #edf2f7; padding: 1rem; border-radius: 8px; margin-bottom: 1rem;      }  .code-block { background: #1e1e1e; color: #f8f8f2; padding: 1rem; border-radius: 8px; overflow-x: auto;      }  .timeline-item { border-left: 4px solid #4299e1; padding-left: 1rem; margin-bottom: 1rem;      }  footer { text-align: center; padding: 2rem; color: #666;      }"),

                    },

                    GitHubUrl = "",
                },

                // Pokémon Capstone Project (wip)
                new Project()
                {
                    Id = "pokemon-capstone",
                    Title = "Pokémon Capstone Project",
                    ImageUrl = "",

                    Summary = "Turn-based systems project emphasizing persistence and UX.",

                    Description = @"
The Pokémon Capstone Project is a large-scale recreation of Pokémon Emerald developed in Unity using C#. 
Designed as both a game development project and a technical showcase, the project recreates the core exploration, 
battle, progression, and collection systems of the original game while introducing modern quality-of-life 
improvements and expanded gameplay features.

Players journey through the Hoenn region, capturing and training Pokémon, battling wild encounters and trainers, 
and progressing through a fully interactive world featuring NPCs, quests, cutscenes, and environmental mechanics. 
The project includes a complete turn-based battle system with experience progression, status effects, party management, 
inventory systems, and advanced Pokémon mechanics such as Natures, EVs, IVs, critical hit calculations, and recoil damage.

A major focus of the project was software architecture and scalability. The game was built using a state-driven 
architecture and extensive use of Scriptable Objects, allowing gameplay systems such as battles, menus, cutscenes, 
and overworld exploration to remain modular and maintainable. This approach enables new content and mechanics to 
be added efficiently without requiring significant rewrites to existing systems.

Beyond recreating the original experience, the project introduces several custom features including a 
redesigned user interface, animated Pokémon sprites, dynamic health bars, a comprehensive Pokédex tracking 
system, an interactive Pokémon Summary Screen with radar chart stat visualization, and a PC storage system 
supporting drag-and-drop interactions and persistent save data.

The project demonstrates strong skills in object-oriented programming, game systems design, data persistence, 
user experience design, debugging, and large-scale software development. It serves as a culmination of both 
technical and creative disciplines, combining software engineering principles with game design to deliver a 
polished and extensible Pokémon-inspired experience.",

                    Technologies = new()
                    {
                        "c#",
                        "unity",
                        "visual_studio",
                        "gimp",
                        "game_design",
                    },

                    ProjectBlocks = new()
                    {
                        
                        // style sheet
                        /**/
                        new ProjectBlock {
                            Type = BlockType.Html,
                            Content = @"<style>
body
{
font-family: Arial, sans-serif;
line-height: 1.7;
margin: 0;
background: #f4f6f8;
color: #222;
}

header
{
background: #2d3748;
color: white;
padding: 3rem 2rem;
text-align: center;
}

main
{
max-width: 1100px;
margin: auto;
padding: 2rem;
}

section
{
background: white;
margin-bottom: 2rem;
padding: 2rem;
border-radius: 12px;
box-shadow: 0 2px 8px rgba(0,0,0,0.08);
} 

h1, h2, h3, h4
{
color: #1a202c;
}

h2
{
border-bottom: 2px solid #e2e8f0;
padding-bottom: 0.5rem;
}

ul
{
padding-left: 1.5rem;
}

.feature-card
{
background: #edf2f7;
padding: 1rem;
border-radius: 8px;
margin-bottom: 1rem;
}

.code-block
{
background: #1e1e1e;
color: #f8f8f2;
padding: 1rem;
border-radius: 8px;
overflow-x: auto;
}

.timeline-item
{
border-left: 4px solid #4299e1;
padding-left: 1rem;
margin-bottom: 1rem;
}

footer
{
text-align: center;
padding: 2rem;
color: #666;
}
</style>"
                        },
                        /**/


                        // introduction
                        new ProjectBlock()
                        {
                            Type = BlockType.Html,
                            Content =
                            "<section>" +
                            "<h2>Introduction</h2>" +

                            "<p>This project is a recreation of Pokémon Emerald developed in Unity using the 2D engine and C# " +
                            "programming language. The game focuses on recreating the exploration, battle, and progression systems " +
                            "from the original Pokémon games while introducing additional quality-of-life improvements and new " +
                            "gameplay systems.</p>" +
                            "<p>The project also serves as a technical showcase for modular game development within Unity. Systems " +
                            "are designed with scalability in mind, allowing future gameplay mechanics, user interface improvements, " +
                            "and additional Pokémon content to be added without requiring complete rewrites of existing systems.</p>" +
                            "</section>",
                        },

                        // game overview
                        new ProjectBlock()
                        {
                            Type = BlockType.Html,
                            Content =
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
                            "</section>",
                        },

                        // game mechanics
                        new ProjectBlock()
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new()
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/190d65368124.png",
                                    Caption = "Move Selection Script",
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url ="https://cdn.imgchest.com/files/38322135d261.png",
                                    Caption = "Audio Script",
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/999e8687bc73.png",
                                    Caption = "Battle System Script",
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/b18610f57826.png",
                                    Caption = "Cutscene Script",
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/f48d763a8856.png",
                                    Caption = "Pokemon Base Script",
                                }
                            }
                        },

                        // game environment
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new()
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/49a5cb194503.png",
                                    Caption = "unity game gameplay",
                                },

                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/718207af2f02.png",
                                    Caption = "unity game menu",
                                },
                                
                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/f370c19aacf8.png",
                                Caption = "unity game pokedex",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/f0af92b06b68.png",
                                Caption = "unity game party",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/914166d0dc50.png",
                                Caption = "unity game pokemon summary cover",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/e5333bddb3e1.png",
                                Caption = "unity game pokemon summary stats",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/51f713c23d66.png",
                                Caption = "unity game pokemon summary moves",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/2f967b4c5a43.png",
                                Caption = "unity game pc box",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/7d01e621ff07.png",
                                Caption = "unity game bag items",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/c7a854961f4b.png",
                                Caption = "unity game pokemon battle choice",
                                },

                                new ProjectMedia
                                {
                                Type = MediaType.Image,
                                Url = "https://cdn.imgchest.com/files/1625c6feafdc.png",
                                Caption = "unity game pokemon battle move",
                                },
                            }
                        },

                        // technical design
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },
                        
                        new ProjectBlock {
                            Type = BlockType.Gallery,
                            MediaItems = new()
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/b63e5dcbd27c.png",
                                    Caption = "unity editor hometown scene with view of objects",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/5248da753e07.png",
                                    Caption = "unity editor gameplay scene",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/774330230ca0.png",
                                    Caption = "unity editor pokemon sprite art folder",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/7244ad274725.png",
                                    Caption = "unity editor pokemon sprite art 001 bulbasaur",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Image,
                                    Url = "https://cdn.imgchest.com/files/d9ad7ac83717.png",
                                    Caption = "unity editor pokemon scriptable object",
                                }
                            }
                        },

                        // quality of life
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        // new features
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        // summary, dex, box videos
                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new()
                            {
                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://vimeo.com/1189895320?fl=tl&fe=ec",
                                    Caption = "Summary Screen Walkthrough",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://vimeo.com/1189895485?fl=tl&fe=ec",
                                    Caption = "Pokedex Screen Walkthrough",
                                },
                                new ProjectMedia
                                {
                                    Type = MediaType.Video,
                                    Url = "https://vimeo.com/1189895398?fl=tl&fe=ec",
                                    Caption = "PC Box Screen Walkthrough",
                                },
                            },
                        },

                        // advanced features
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        // bug fixes
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        // timeline
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                        // future plans
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content =
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
                        },

                    },

                    
                    GitHubUrl = "",
                },

                // Art Work
                new Project()
                {
                    Id = "art-work",
                    Title = "Art Work",
                    ImageUrl = "https://cdn.imgchest.com/files/6ca130d0df7f.png",

                    Summary = "Personal artwork of images and videos",

                    Description = "Personal artwork of images and videos.",

                    Technologies = new()
                    {
                        "Illustrator",
                        "Photoshop",
                        "After Effects",
                        "Premiere Pro"
                    },

                    ProjectBlocks = new()
                    {
                        // beginning content
                        new ProjectBlock
                        {
                            Type = BlockType.Html,
                            Content = "<section>" +
                                      "<h2>Personal Art Portfolio</h2>" +
                                      "<p>This collection showcases a variety of personal art projects, including digital illustrations, " +
                                      "kinetic typography videos, and abstract designs. The works explore themes of pop culture, " +
                                      "science fiction, and graphic design principles.</p>" +
                                      "</section>"
                        },

                        // gallery of media items (image and video)
                        new ProjectBlock
                        {
                            Type = BlockType.Gallery,
                            MediaItems = new()
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
                    },
                },
            };
    }
}
