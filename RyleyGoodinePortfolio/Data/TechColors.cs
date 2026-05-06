namespace RyleyGoodinePortfolio.Data
{
    public class TechColors
    {
        /// <summary>
        /// Provides a mapping of technology, tool, or language names to their associated background and foreground
        /// color codes.
        /// </summary>
        /// <remarks>This dictionary can be used to retrieve color schemes for various programming
        /// languages, frameworks, design tools, and related technologies. The color codes are represented as
        /// hexadecimal strings. The dictionary includes a 'Default' entry for cases where a specific technology is not
        /// listed.</remarks>
        public static readonly Dictionary<string, (string bg, string fg)> Colors = new()
        {
            // --- Adobe Applications ---
            ["adobe_photoshop"] = ("#001E36", "#31A8FF"),
            ["photoshop"] = ("#001E36", "#31A8FF"),
            ["adobe_illustrator"] = ("#330000", "#FF9A00"),
            ["illustrator"] = ("#330000", "#FF9A00"),
            ["adobe_after_effects"] = ("#1B1B3A", "#9999FF"),
            ["after_effects"] = ("#1B1B3A", "#9999FF"),
            ["adobe_premiere_pro"] = ("#2A0034", "#EA77FF"),
            ["premiere_pro"] = ("#2A0034", "#EA77FF"),
            ["adobe_lightroom"] = ("#001E36", "#31A8FF"),
            ["lightroom"] = ("#001E36", "#31A8FF"),
            ["adobe_lightroom_classic"] = ("#0C1F2A", "#31A8FF"),
            ["lightroom_classic"] = ("#0C1F2A", "#31A8FF"),
            ["adobe_indesign"] = ("#49021F", "#FF3366"),
            ["indesign"] = ("#49021F", "#FF3366"),
            ["adobe_xd"] = ("#2E001F", "#FF61F6"),
            ["xd"] = ("#2E001F", "#FF61F6"),
            ["adobe_dreamweaver"] = ("#072300", "#00FF99"),
            ["dreamweaver"] = ("#072300", "#00FF99"),
            ["adobe_audition"] = ("#00005B", "#00E4BB"),
            ["audition"] = ("#00005B", "#00E4BB"),
            ["adobe_animate"] = ("#1C1C1C", "#FF9A00"),
            ["animate"] = ("#1C1C1C", "#FF9A00"),
            ["adobe_dimension"] = ("#1B1B1B", "#8C8CFF"),
            ["dimension"] = ("#1B1B1B", "#8C8CFF"),
            ["adobe_substance_3d_painter"] = ("#1E1E1E", "#FF6F00"),
            ["substance_painter"] = ("#1E1E1E", "#FF6F00"),
            ["adobe_substance_3d_designer"] = ("#1E1E1E", "#00B3FF"),
            ["substance_designer"] = ("#1E1E1E", "#00B3FF"),
            ["adobe_substance_3d_sampler"] = ("#1E1E1E", "#66FFCC"),
            ["substance_sampler"] = ("#1E1E1E", "#66FFCC"),
            ["adobe_substance_3d_stager"] = ("#1E1E1E", "#FF66CC"),
            ["substance_stager"] = ("#1E1E1E", "#FF66CC"),
            ["adobe_bridge"] = ("#2C2C2C", "#9F9F9F"),
            ["bridge"] = ("#2C2C2C", "#9F9F9F"),
            ["adobe_acrobat"] = ("#EC1C24", "#FFFFFF"),
            ["acrobat"] = ("#EC1C24", "#FFFFFF"),
            ["adobe_express"] = ("#6A00FF", "#FFFFFF"),
            ["express"] = ("#6A00FF", "#FFFFFF"),

            // --- Design ---
            ["figma"] = ("#F24E1E", "#FFFFFF"),
            ["gimp"] = ("#5C5543", "#FFFFFF"),
            ["blender"] = ("#F5792A", "#FFFFFF"),

            // --- Game Development ---
            ["unity"] = ("#222C37", "#FFFFFF"),
            ["unity3d"] = ("#222C37", "#FFFFFF"),
            ["unreal_engine"] = ("#0E1128", "#FFFFFF"),
            ["godot"] = ("#478CBF", "#FFFFFF"),
            ["game_design"] = ("#8E44AD", "#FFFFFF"),

            // --- Programming Languages ---
            ["c"] = ("#A8B9CC", "#000000"),
            ["c++"] = ("#00599C", "#FFFFFF"),
            ["c#"] = ("#68217A", "#FFFFFF"),
            ["java"] = ("#F89820", "#1A1A1A"),
            ["python"] = ("#3776AB", "#FFD43B"),
            ["python3"] = ("#3776AB", "#FFD43B"),
            ["javascript"] = ("#F7DF1E", "#000000"),
            ["js"] = ("#F7DF1E", "#000000"),
            ["typescript"] = ("#3178C6", "#FFFFFF"),
            ["go"] = ("#00ADD8", "#000000"),
            ["rust"] = ("#DEA584", "#000000"),
            ["kotlin"] = ("#7F52FF", "#FFFFFF"),
            ["swift"] = ("#FA7343", "#FFFFFF"),
            ["dart"] = ("#0175C2", "#FFFFFF"),
            ["ruby"] = ("#CC342D", "#FFFFFF"),
            ["php"] = ("#777BB4", "#FFFFFF"),

            // --- Web Technologies ---
            ["html"] = ("#E34F26", "#FFFFFF"),
            ["css"] = ("#1572B6", "#FFFFFF"),
            ["sass"] = ("#CC6699", "#FFFFFF"),
            ["scss"] = ("#CC6699", "#FFFFFF"),
            ["tailwind"] = ("#38BDF8", "#000000"),
            ["bootstrap"] = ("#7952B3", "#FFFFFF"),

            // --- Frameworks / Libraries ---
            ["blazor"] = ("#512BD4", "#FFFFFF"),
            ["react"] = ("#61DAFB", "#000000"),
            ["angular"] = ("#DD0031", "#FFFFFF"),
            ["vue"] = ("#42B883", "#FFFFFF"),
            ["next.js"] = ("#000000", "#FFFFFF"),
            ["node.js"] = ("#339933", "#FFFFFF"),
            [".net"] = ("#512BD4", "#FFFFFF"),
            ["asp.net"] = ("#512BD4", "#FFFFFF"),

            // --- Microsoft Applications ---
            ["microsoft_word"] = ("#2B579A", "#FFFFFF"),
            ["word"] = ("#2B579A", "#FFFFFF"),
            ["microsoft_excel"] = ("#217346", "#FFFFFF"),
            ["excel"] = ("#217346", "#FFFFFF"),
            ["microsoft_powerpoint"] = ("#D24726", "#FFFFFF"),
            ["powerpoint"] = ("#D24726", "#FFFFFF"),
            ["microsoft_outlook"] = ("#0078D4", "#FFFFFF"),
            ["outlook"] = ("#0078D4", "#FFFFFF"),
            ["microsoft_teams"] = ("#6264A7", "#FFFFFF"),
            ["teams"] = ("#6264A7", "#FFFFFF"),
            ["onenote"] = ("#7719AA", "#FFFFFF"),
            ["microsoft_edge"] = ("#0C59A4", "#FFFFFF"),

            // --- Apple Applications ---
            ["final_cut_pro"] = ("#1E1E1E", "#FF3B30"),
            ["logic_pro"] = ("#1E1E1E", "#FF9500"),
            ["xcode"] = ("#147EFB", "#FFFFFF"),
            ["safari"] = ("#0FB5EE", "#FFFFFF"),
            ["apple_photos"] = ("#FA233B", "#FFFFFF"),
            ["apple_music"] = ("#FA233B", "#FFFFFF"),
            ["imovie"] = ("#1C1C1E", "#FFFFFF"),

            // --- IDEs / Editors ---
            ["visual_studio"] = ("#5C2D91", "#FFFFFF"),
            ["vs"] = ("#5C2D91", "#FFFFFF"),
            ["visual_studio_code"] = ("#007ACC", "#FFFFFF"),
            ["vscode"] = ("#007ACC", "#FFFFFF"),
            ["rider"] = ("#000000", "#FF4081"),
            ["intellij"] = ("#000000", "#FFFFFF"),
            ["intellij_idea"] = ("#000000", "#FFFFFF"),
            ["pycharm"] = ("#21D789", "#000000"),
            ["webstorm"] = ("#00CDD7", "#000000"),
            ["phpstorm"] = ("#8892BF", "#FFFFFF"),
            ["clion"] = ("#14C8FF", "#000000"),
            ["android_studio"] = ("#3DDC84", "#000000"),
            ["eclipse"] = ("#2C2255", "#FFFFFF"),
            ["netbeans"] = ("#1B6AC6", "#FFFFFF"),
            ["sublime_text"] = ("#FF9800", "#000000"),
            ["notepad++"] = ("#90E59A", "#000000"),
            ["atom"] = ("#66595C", "#FFFFFF"),

            // --- Databases ---
            ["sql"] = ("#336791", "#FFFFFF"),
            ["mysql"] = ("#4479A1", "#FFFFFF"),
            ["postgresql"] = ("#336791", "#FFFFFF"),
            ["sqlite"] = ("#003B57", "#FFFFFF"),
            ["mongodb"] = ("#47A248", "#FFFFFF"),
            ["firebase"] = ("#FFCA28", "#000000"),

            // --- DevOps / Tools ---
            ["git"] = ("#F05032", "#FFFFFF"),
            ["github"] = ("#181717", "#FFFFFF"),
            ["gitlab"] = ("#FC6D26", "#FFFFFF"),
            ["docker"] = ("#2496ED", "#FFFFFF"),
            ["kubernetes"] = ("#326CE5", "#FFFFFF"),
            ["linux"] = ("#FCC624", "#000000"),
            ["bash"] = ("#4EAA25", "#FFFFFF"),

            // --- Cloud ---
            ["aws"] = ("#232F3E", "#FF9900"),
            ["azure"] = ("#0078D4", "#FFFFFF"),
            ["google cloud"] = ("#4285F4", "#FFFFFF"),

            // --- Misc / Other ---
            ["json"] = ("#000000", "#FFFFFF"),
            ["xml"] = ("#E44D26", "#FFFFFF"),
            ["rest"] = ("#6DB33F", "#FFFFFF"),
            ["graphql"] = ("#E10098", "#FFFFFF"),
            // --- Fallback ---
            ["default"] = ("#E5E7EB", "#000000")
        };

        public static string GetStyle(string tech)
        {
            var key = tech.ToLower().Replace(" ", "_");

            if (Colors.TryGetValue(key, out var colors))
            {
                return $"background:{colors.bg};color:{colors.fg};";
            }

            return $"background:{Colors["default"].bg};color:{Colors["default"].fg};";
        }

        public static string GetShorthand(string tech)
        {
            if (string.IsNullOrWhiteSpace(tech))
                return "";

            var key = tech.ToLower().Replace(" ", "_");

            return key switch
            {
                // --- Adobe ---
                "photoshop" or "adobe_photoshop" => "PS",
                "illustrator" or "adobe_illustrator" => "AI",
                "after_effects" or "adobe_after_effects" => "AE",
                "premiere_pro" or "adobe_premiere_pro" => "PR",
                "lightroom" => "LR",
                "lightroom_classic" => "LRC",
                "indesign" => "ID",
                "xd" => "XD",

                // --- Languages ---
                "javascript" or "js" => "JS",
                "typescript" => "TS",
                "python" or "python3" => "PY",
                "c++" => "C++",
                "c#" => "C#",

                // --- Frameworks ---
                "react" => "RE",
                "angular" => "NG",
                "vue" => "VU",
                "node.js" => "ND",

                // --- IDEs ---
                "visual_studio" or "vs" => "VS",
                "visual_studio_code" or "vscode" => "VSCode",
                "intellij" or "intellij_idea" => "IJ",
                "pycharm" => "PC",

                // --- Default fallback ---
                _ => key.Length <= 4
                    ? key.ToUpper()
                    : string.Concat(key.Split('_').Select(w => char.ToUpper(w[0])))
            };
        }
    }
}
