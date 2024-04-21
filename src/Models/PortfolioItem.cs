namespace JazperDK.Models
{
    public class PortfolioItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get { return $"media/images/{Name.ToLower().Replace(" ", "")}.png"; } }

        public PortfolioItem(string name, string description, string url)
        {
            Name = name;
            Description = description;
            Url = url;
        }

        public static PortfolioItem[] GetPortfolioItems()
        {
            PortfolioItem[] portfolioItems =
            [
                new PortfolioItem("Guildy", "Danmarks største discord chat bot, skrevet i Python.", "https://guildy.dk")
            ];

            return portfolioItems;
        }
    }
}
