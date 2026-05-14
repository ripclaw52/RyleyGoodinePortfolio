namespace RyleyGoodinePortfolio.Models
{
    public enum BlockType
    {
        Html,
        Image,
        Video,
        Gallery
    }

    public class ProjectBlock
    {
        public BlockType Type { get; set; }

        // HTML/Text
        public string Content { get; set; } = "";

        // Media
        public string Url { get; set; } = "";
        public string Caption { get; set; } = "";
        public List<string>? Technologies { get; set; } = [];

        // Optional gallery support
        public List<ProjectMedia>? MediaItems { get; set; }
    }
}
