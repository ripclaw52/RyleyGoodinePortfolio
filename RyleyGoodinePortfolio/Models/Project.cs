using System.Collections.Generic;

namespace RyleyGoodinePortfolio.Models
{
    public class Details
    {
        public string E { get; set; }
        public string C { get; set; }

        public Details(string e, string c)
        {
            E = e ?? string.Empty;
            C = c ?? string.Empty;
        }
    }

    public class ProjectMedia
    {
        public string Url { get; set; } = string.Empty;
        public string? Caption { get; set; }
        public MediaType Type { get; set; }
        public List<string> Technologies { get; set; } = new();
    }

    public class Project
    {
        // Card Overview Data
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string[] Tags { get; set; } = Array.Empty<string>();
        public string ImageUrl { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        
        // Detailed Content
        public string ContentPath { get; set; } = string.Empty; // e.g., "data/content/my-project.md"
        public string[] MediaGallery { get; set; } = Array.Empty<string>();


        public string Summary { get; set; } = string.Empty;
        
        // if available
        

        // Always initialize collections to avoid null dereference (CS8602)
        public List<string>? Technologies { get; set; } = [];
        public List<Details>? ProjectContent { get; set; } = [];
        public List<ProjectBlock>? ProjectBlocks { get; set; } = [];
        public List<ProjectMedia>? Media { get; set; } = [];
    }
}