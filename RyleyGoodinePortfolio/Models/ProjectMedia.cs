namespace RyleyGoodinePortfolio.Models
{
    public class ProjectMedia
    {
        public MediaType Type { get; set; }
        public string Url { get; set; } = "";
        public string Caption { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
    }
}
