namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
