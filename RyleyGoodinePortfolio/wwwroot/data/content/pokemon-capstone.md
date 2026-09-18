<!-- Pokémon Capstone Project -->

<!-- -->
<section>
<h2>Introduction</h2>

<p>This project is a recreation of Pokémon Emerald developed in Unity using the 2D engine and C#
programming language. The game focuses on recreating the exploration, battle, and progression systems
from the original Pokémon games while introducing additional quality-of-life improvements and new
gameplay systems.</p>
<p>The project also serves as a technical showcase for modular game development within Unity. Systems
are designed with scalability in mind, allowing future gameplay mechanics, user interface improvements,
and additional Pokémon content to be added without requiring complete rewrites of existing systems.</p>
</section>


<!-- -->
<section>
<h2>Game Overview</h2>

<h3>Storyline</h3>
<p>The game takes place in the Hoenn region, inspired directly by Pokémon Emerald. Players begin their
adventure in Littleroot Town and progress toward becoming Pokémon Champion through exploration, battles,
and story progression.</p>

<h3>Target Audience</h3>
<p>The intended audience is rated \"E for Everyone.\" The game primarily targets fans of classic Pokémon
titles while remaining accessible to all players.</p>

<h3>Platform</h3>
<p>The game currently supports Windows PC through the Unity 2D engine.</p>
<p>While inspired heavily by Pokémon Emerald, the project also introduces modernized interface systems
and expanded gameplay mechanics that were not fully present in the original Game Boy Advance release.
The goal is to preserve the feel of the original game while improving usability and system flexibility.</p>
</section>


<!-- -->
<section>
<h2>Game Mechanics</h2>
<h3>Player Controls</h3>
<ul>
<li><strong>Arrow Keys:</strong> Move player and navigate menus</li>
<li><strong>Z:</strong> Confirm selections and interact</li>
<li><strong>X:</strong> Cancel or go back</li>
<li><strong>Enter:</strong> Open menu in overworld</li>
<li><strong>Shift:</strong> Run feature</li>
</ul>

<h3>Overworld Systems</h3>
<ul>
<li>Animated player movement</li>
<li>NPC scripting and cutscenes</li>
<li>Quest systems</li>
<li>Wild Pokémon encounters</li>
<li>Trainer field-of-view battles</li>
<li>HM abilities such as Surf and Cut</li>
</ul>

<h3>Battle System</h3>
<ul>
<li>Turn-based combat</li>
<li>Move selection system</li>
<li>Status conditions</li>
<li>Experience and leveling</li>
<li>Bag and party management</li>
<li>Trainer and wild battles</li>
</ul>
</section>


<!-- -->
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


<!-- -->
<section>
<h2>Game Environment</h2>

<h3>Sprites</h3>
<p>Sprite assets are sourced from Pokémon Emerald sprite
resources and used for player characters, NPCs, Pokémon,
menus, and battle scenes.</p>

<h3>Audio</h3>
<p>Sound effects and music are sourced from Pokémon
Ruby/Sapphire collections, including move sounds, menu
audio, and scene music.</p>

<h3>Textures</h3>
<p>Tile textures define environmental layers such as grass,
water, solid objects,foreground, and background rendering.</p>
</section>


<!-- -->
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


<!-- -->
<section>
<h2>Technical Design</h2>

<div class=\"feature-card\">
<h3>Engine</h3>
<p>Unity 2021.3.11f1 (2D Engine)</p>
</div>

<div class=\"feature-card\">
<h3>Primary Language</h3>
<p>C#</p>
</div>

<div class=\"feature-card\">
<h3>Architecture</h3>
<p>State Stack Architecture with Scriptable Objects</p>
</div>

<p>The project uses a state-driven architecture to separate gameplay systems such as battles, menus,
cutscenes, and overworld exploration into isolated game states. This approach improves organization and
simplifies transitions between gameplay screens.</p>
<p>Scriptable Objects are heavily utilized throughout development to store reusable data such as Pokémon
species, move definitions, status conditions, type information, and UI references. This allows designers
to modify gameplay data without directly changing core gameplay scripts.</p>
</section>


<!-- -->
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


<!-- -->
<section>
<h2>Quality of Life Features</h2>

<article class=\"feature-card\">
<h3>User Interface Refactor</h3>
<p>Redesigned menus and HUD elements to better resemble
Pokémon Emerald, including typography, menu borders, and
updated health bars.</p>
</article>

<article class=\"feature-card\">
<h3>Coloured Health Bars</h3>
<p>Added gradient-based HP bars using Unity gradients. Health bar colours change dynamically
based on remaining HP percentage.</p>
<ul>
<li>Green: 100–51%</li>
<li>Yellow: 50–21%</li>
<li>Red: 20–0%</li>
</ul>
</article>

<article class=\"feature-card\">
<h3>Animated Sprites</h3>
<p>Added animated Pokémon sprites using custom sprite-map
animation systems within Unity UI image components.</p>
</article>

<article class=\"feature-card\">
<h3>Running System</h3>
<p>Implemented running movement with increased movement
speed and updatedanimation sets triggered by keyboard or controller input.</p>
</article>
</section>


<!-- -->
<section>
<h2>New Gameplay Features</h2>

<article class=\"feature-card\">
<h3>Summary Screen</h3>
<p>Added a modular Pokémon Summary Screen featuring:</p>
<ul>
<li>Pokémon stats</li>
<li>Move details</li>
<li>Experience tracking</li>
<li>Nature information</li>
<li>Radar graph stat visualization</li>
</ul>
</article>

<article class=\"feature-card\">
<h3>Pokédex System</h3>
<p>Implemented a full Pokédex tracking system with encounter states:</p>
<ul>
<li>None</li>
<li>Seen</li>
<li>Owned</li>
</ul>
<p>Includes scrolling lists, Pokémon information pages, and save/load support.</p>
</article>

<article class=\"feature-card\">
<h3>PC Storage System</h3>
<p>Added Pokémon storage boxes with drag-and-drop interaction, box customization,
and binary save support.</p>
<ul>
<li>30 Pokémon per box</li>
<li>Multiple box support</li>
<li>Virtual mouse integration</li>
<li>Summary screen access from PC</li>
</ul>
</article>
</section>


<!-- -->
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


<!-- -->
<section>
<h2>Advanced Battle Features</h2>

<article class=\"feature-card\">
<h3>Critical Hits</h3>
<p>Added move-specific critical hit behavior including:</p>
<ul>
<li>Always Critical</li>
<li>High Critical Chance</li>
<li>Never Critical</li>
</ul>
</article>

<article class=\"feature-card\">
<h3>Recoil Damage</h3>
<p>Added multiple recoil damage systems:</p>
<ul>
<li>Damage-based recoil</li>
<li>Max HP recoil</li>
<li>Current HP recoil</li>
</ul>
</article>

<article class=\"feature-card\">
<h3>Natures, EVs, and IVs</h3>
<p>Implemented Pokémon stat systems including:</p>
<ul>
<li>25 Pokémon Natures</li>
<li>Effort Values (EVs)</li>
<li>Individual Values (IVs)</li>
<li>Level-up stat scaling</li>
</ul>
</article>
<p>These advanced systems were implemented to more closely replicate competitive Pokémon mechanics found
in official games. The combination of Natures, EVs, IVs, recoil systems, and critical-hit behavior
creates greater variation between Pokémon and introduces more strategic depth during battles.</p>
</section>


<!-- -->
<section>
<h2>Bug Fixes & Challenges</h2>

<div class=\"timeline-item\">
<h3>Health Bar Scaling Issue</h3>
<p>Fixed incorrect HP bar scaling by adjusting battle camera size and resetting prefab
sizing to native scale.</p>
</div>

<div class=\"timeline-item\">
<h3>Animation Array Crash</h3>
<p>Resolved null animation array issues by validating arrays during Start and
HandleUpdate methods.</p>
</div>

<div class=\"timeline-item\">
<h3>Pokédex Runtime Persistence Bug</h3>
<p>Created custom PokedexObject classes to prevent runtime encounter data from persisting
between Unity sessions.</p>
</div>
</section>


<!-- need to work on this -->
<section>
<h2>Implementation Timeline</h2>

<div class=\"timeline-item\">
<h3>September 2023</h3>
<p>Initial GDD completed.</p>
</div>

<div class=\"timeline-item\">
<h3>UI Refactor</h3>
<p>Started September 19, 2023.</p>
</div>

<div class=\"timeline-item\">
<h3>Animated Sprites</h3>
<p>Started September 20, 2023.</p>
</div>

<div class=\"timeline-item\">
<h3>Health Bar Redesign</h3>
<p>Completed September 13, 2023.</p>
</div>
</section>


<!-- -->
<section>
<h2>Future Plans</h2>

<ul>
<li>Gym battles and Elite Four</li>
<li>Abilities and held items</li>
<li>Berry mechanics</li>
<li>Breeding systems</li>
<li>Weather and terrain mechanics</li>
<li>Battle animations and particles</li>
<li>Mega Evolution</li>
<li>Contest system</li>
<li>Full Pokémon Emerald story implementation</li>
<li>Additional Pokémon generations</li>
</ul>
<p>Future development will continue focusing on modularity and scalability so additional Pokémon
generations, battle mechanics, and story systems can be integrated into the project. Long-term goals
include recreating the complete Pokémon Emerald experience while supporting expanded post-game and
multiplayer-inspired systems.</p>
</section>