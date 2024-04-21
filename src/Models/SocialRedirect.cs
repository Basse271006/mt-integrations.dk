namespace JazperDK.Models
{
    public class SocialRedirect
    {
        public string Endpoint { get; set; }
        public string RedirectUrl { get; set; }

        public SocialRedirect(string endpoint, string redirectUrl)
        {
            Endpoint = endpoint;
            RedirectUrl = redirectUrl;
        }

        public static SocialRedirect[] GetSocialRedirects()
        {
            SocialRedirect[] socialRedirects = new SocialRedirect[]
            {
                new SocialRedirect("github", "https://github.com/basse271006"),
                new SocialRedirect("snapchat", "https://www.snapchat.com/add/basse271007"),
                new SocialRedirect("linkedin", "https://www.linkedin.com/in/magnus-tolstrup/"),
                new SocialRedirect("steam", "https://steamcommunity.com/id/Basse271006"),
                new SocialRedirect("xsploit", "https://xsplo.it/")
            };

            return socialRedirects;
        }
    }
}
