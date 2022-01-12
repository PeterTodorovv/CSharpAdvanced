using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
            this.MarketCapitalization = totalNumberOfShares * pricePerShare;
        }
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get; set; }

        public override string ToString()
        {
            StringBuilder textToReturn = new StringBuilder();
            textToReturn.AppendLine($"Company: {CompanyName}");
            textToReturn.AppendLine($"Director: {Director}");
            textToReturn.AppendLine($"Price per share: ${PricePerShare}");
            textToReturn.AppendLine($"Market capitalization: ${MarketCapitalization}");

            return string.Join("", textToReturn);
        }
    }
}
