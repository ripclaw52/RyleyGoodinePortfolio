namespace RyleyGoodinePortfolio.Data
{
    public class TechColors
    {
        // convert to lowercase in data repository for easier matching, but keep original casing here for display purposes
        public static readonly Dictionary<string, (string bg, string fg)> Colors = new()
        {
            // --- Adobe / Design ---
            ["Illustrator"] = ("#FF9A00", "#1A1A1A"),
            ["Photoshop"] = ("#001E36", "#31A8FF"),
            ["After Effects"] = ("#2E2A5E", "#D291FF"),
            ["Premiere Pro"] = ("#2A0034", "#EA77FF"),
            ["Figma"] = ("#F24E1E", "#FFFFFF"),
            ["GIMP"] = ("#5C5543", "#FFFFFF"),
            ["Blender"] = ("#F5792A", "#FFFFFF"),

            // --- Game Development ---
            ["Unity"] = ("#222C37", "#FFFFFF"),
            ["Unity3D"] = ("#222C37", "#FFFFFF"),
            ["Unreal Engine"] = ("#0E1128", "#FFFFFF"),
            ["Godot"] = ("#478CBF", "#FFFFFF"),
            ["Game Design"] = ("#8E44AD", "#FFFFFF"),

            // --- Programming Languages ---
            ["C"] = ("#A8B9CC", "#000000"),
            ["C++"] = ("#00599C", "#FFFFFF"),
            ["C#"] = ("#68217A", "#FFFFFF"),
            ["Java"] = ("#F89820", "#1A1A1A"),
            ["Python"] = ("#3776AB", "#FFD43B"),
            ["Python3"] = ("#3776AB", "#FFD43B"),
            ["JavaScript"] = ("#F7DF1E", "#000000"),
            ["JS"] = ("#F7DF1E", "#000000"),
            ["TypeScript"] = ("#3178C6", "#FFFFFF"),
            ["Go"] = ("#00ADD8", "#000000"),
            ["Rust"] = ("#DEA584", "#000000"),
            ["Kotlin"] = ("#7F52FF", "#FFFFFF"),
            ["Swift"] = ("#FA7343", "#FFFFFF"),
            ["Dart"] = ("#0175C2", "#FFFFFF"),
            ["Ruby"] = ("#CC342D", "#FFFFFF"),
            ["PHP"] = ("#777BB4", "#FFFFFF"),

            // --- Web Technologies ---
            ["HTML"] = ("#E34F26", "#FFFFFF"),
            ["CSS"] = ("#1572B6", "#FFFFFF"),
            ["SASS"] = ("#CC6699", "#FFFFFF"),
            ["SCSS"] = ("#CC6699", "#FFFFFF"),
            ["Tailwind"] = ("#38BDF8", "#000000"),
            ["Bootstrap"] = ("#7952B3", "#FFFFFF"),

            // --- Frameworks / Libraries ---
            ["Blazor"] = ("#512BD4", "#FFFFFF"),
            ["React"] = ("#61DAFB", "#000000"),
            ["Angular"] = ("#DD0031", "#FFFFFF"),
            ["Vue"] = ("#42B883", "#FFFFFF"),
            ["Next.js"] = ("#000000", "#FFFFFF"),
            ["Node.js"] = ("#339933", "#FFFFFF"),
            [".NET"] = ("#512BD4", "#FFFFFF"),
            ["ASP.NET"] = ("#512BD4", "#FFFFFF"),

            // --- Databases ---
            ["SQL"] = ("#336791", "#FFFFFF"),
            ["MySQL"] = ("#4479A1", "#FFFFFF"),
            ["PostgreSQL"] = ("#336791", "#FFFFFF"),
            ["SQLite"] = ("#003B57", "#FFFFFF"),
            ["MongoDB"] = ("#47A248", "#FFFFFF"),
            ["Firebase"] = ("#FFCA28", "#000000"),

            // --- DevOps / Tools ---
            ["Git"] = ("#F05032", "#FFFFFF"),
            ["GitHub"] = ("#181717", "#FFFFFF"),
            ["GitLab"] = ("#FC6D26", "#FFFFFF"),
            ["Docker"] = ("#2496ED", "#FFFFFF"),
            ["Kubernetes"] = ("#326CE5", "#FFFFFF"),
            ["Linux"] = ("#FCC624", "#000000"),
            ["Bash"] = ("#4EAA25", "#FFFFFF"),

            // --- Cloud ---
            ["AWS"] = ("#232F3E", "#FF9900"),
            ["Azure"] = ("#0078D4", "#FFFFFF"),
            ["Google Cloud"] = ("#4285F4", "#FFFFFF"),

            // --- Misc / Other ---
            ["JSON"] = ("#000000", "#FFFFFF"),
            ["XML"] = ("#E44D26", "#FFFFFF"),
            ["REST"] = ("#6DB33F", "#FFFFFF"),
            ["GraphQL"] = ("#E10098", "#FFFFFF"),

            // --- Fallback ---
            ["Default"] = ("#E5E7EB", "#000000")
        };
    }
}
