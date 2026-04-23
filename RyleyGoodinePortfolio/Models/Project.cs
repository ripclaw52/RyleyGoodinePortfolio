namespace RyleyGoodinePortfolio.Models
{
    public class Project
    {
        public string Slug { get; set; } = "";
        public string Title { get; set; } = "";
        public string ThumbnailUrl { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
        public string? GitHubUrl { get; set; }
        public string? DemoUrl { get; set; }
    }
}
