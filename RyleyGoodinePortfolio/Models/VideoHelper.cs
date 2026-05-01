using System.Text.RegularExpressions;

namespace RyleyGoodinePortfolio.Models
{
    /// <summary>
    /// Provides helper methods for parsing video URLs from YouTube, Dailymotion, or Vimeo and extracting related
    /// information such as embed and thumbnail URLs.
    /// </summary>
    /// <remarks>Supports common URL formats for YouTube (including watch, embed, shorts, and youtu.be),
    /// Dailymotion (including video, embed, dai.ly, and geo.dailymotion.com), and Vimeo (including vimeo.com and
    /// player.vimeo.com). Returns null values if the URL does not match a supported provider or format.</remarks>
    public static class VideoHelper
    {
        /// <summary>
        /// Parses a video URL from YouTube, Dailymotion, or Vimeo and extracts the corresponding embed and thumbnail
        /// URLs.
        /// </summary>
        /// <remarks>Supports common URL formats for YouTube (including watch, embed, shorts, and
        /// youtu.be), Dailymotion (including video, embed, dai.ly, and geo.dailymotion.com), and Vimeo (including
        /// vimeo.com and player.vimeo.com). Returns null values if the URL does not match a supported provider or
        /// format.</remarks>
        /// <param name="url">The video URL to parse. Must be a valid YouTube, Dailymotion, or Vimeo URL format.</param>
        /// <returns>A tuple containing the embed URL and thumbnail URL if the input is recognized; otherwise, both values are
        /// null.</returns>
        public static (string? embedUrl, string? thumbnailUrl) Parse(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return (null, null);

            // --- YOUTUBE ---
            // Supports:
            // youtube.com/watch?v=
            // youtube.com/embed/
            // youtu.be/
            // youtube.com/shorts/
            var ytPattern = @"(?:youtube\.com/(?:watch\?v=|embed/|shorts/)|youtu\.be/)([a-zA-Z0-9_-]{11})";
            var ytMatch = Regex.Match(url, ytPattern);

            if (ytMatch.Success)
            {
                var id = ytMatch.Groups[1].Value;

                return (
                    $"https://www.youtube.com/embed/{id}",
                    $"https://img.youtube.com/vi/{id}/hqdefault.jpg"
                );
            }

            // --- DAILYMOTION ---
            // Supports:
            // dailymotion.com/video/
            // dailymotion.com/embed/video/
            // dai.ly/
            // geo.dailymotion.com/player.html?video=
            var dmPattern = @"(?:video=|dailymotion\.com/video/|dailymotion\.com/embed/video/|dai\.ly/)([a-zA-Z0-9]+)";
            var dmMatch = Regex.Match(url, dmPattern);

            if (dmMatch.Success)
            {
                var id = dmMatch.Groups[1].Value;

                return (
                    $"https://www.dailymotion.com/embed/video/{id}",
                    $"https://www.dailymotion.com/thumbnail/video/{id}"
                );
            }

            // --- VIMEO ---
            // Supports:
            // vimeo.com/
            // player.vimeo.com/video/
            var vimeoPattern = @"(?:vimeo\.com/|player\.vimeo\.com/video/)(\d+)";
            var vimeoMatch = Regex.Match(url, vimeoPattern);

            if (vimeoMatch.Success)
            {
                var id = vimeoMatch.Groups[1].Value;

                return (
                    $"https://player.vimeo.com/video/{id}",
                    $"https://vumbnail.com/{id}.jpg"
                );
            }

            // --- FALLBACK ---
            return (null, null);
        }
    }
}