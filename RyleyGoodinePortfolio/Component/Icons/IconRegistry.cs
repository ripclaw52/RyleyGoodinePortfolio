namespace RyleyGoodinePortfolio.Component.Icons
{
    public static class IconRegistry
    {
        public static (string Path, string ViewBox, string Label, string Url) Get(SocialPlatform platform)
        {
            return platform switch
            {
                // github
                SocialPlatform.GitHub => (
                "",
                "0 0 24 24",
                "GitHub",
                "https://github.com/ripclaw52"
                ),

                // linkedin
                SocialPlatform.LinkedIn => (
                "",
                "0 0 24 24",
                "LinkedIn",
                "https://www.linkedin.com/in/ryley-goodine-cannedend89-96-3425egam"
                ),

                // twitter
                SocialPlatform.Twitter => (
                "",
                "0 0 24 24",
                "Twitter",
                "https://x.com/Ripclaw89"
                ),

                // facebook
                SocialPlatform.Facebook => (
                "",
                "0 0 24 24",
                "Facebook",
                "https://www.facebook.com/ryley.goodine.1/"
                ),

                // instagram
                SocialPlatform.Instagram => (
                "Icons/instagram.svg",
                "0 0 24 24",
                "Instagram",
                "https://www.instagram.com/ryley.goodine/"
                ),

                // youtube
                SocialPlatform.YouTube => (
                "Icons/youtube.svg",
                "0 0 24 24",
                "YouTube",
                "https://www.youtube.com/@cannedend8915"
                ),

                // dailymotion
                SocialPlatform.DailyMotion => (
                "",
                "0 0 24 24",
                "DailyMotion",
                "https://www.dailymotion.com/user/ryley.bxs228"
                ),

                // reddit
                SocialPlatform.Reddit => (
                "",
                "0 0 24 24",
                "Reddit",
                "https://www.reddit.com/user/ElectronicAlgae5541/"
                ),

                // twitch
                SocialPlatform.Twitch => (
                "",
                "0 0 24 24",
                "Twitch",
                "https://www.twitch.tv/ripclaw52"
                ),

                _ => throw new NotImplementedException()
            };
        }
    }
}