using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        Dictionary<string, Stock> Portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
            this.Portfolio = new Dictionary<string, Stock>();
        }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int Count { get { return Portfolio.Count; } }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock.CompanyName, stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal price)
        {
            if (!Portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";
            }

            if (price < Portfolio[companyName].PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            Portfolio.Remove(companyName);
            MoneyToInvest += price;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {
            if (Portfolio.ContainsKey(companyName))
            {
                return Portfolio[companyName];
            }

            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (Count == 0)
                return null;

            string biggestCompany = default;
            decimal biggestCapitalization = 0;
            foreach (var company in Portfolio)
            {
                if (company.Value.MarketCapitalization > biggestCapitalization)
                {
                    biggestCompany = company.Key;
                    biggestCapitalization = company.Value.MarketCapitalization;
                }
            }

            return Portfolio[biggestCompany];
        }

        public string InvestorInformation()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");

            foreach (var stock in Portfolio)
            {
                text.Append(stock.Value.ToString());
            }

            return string.Join("", text);
        }
    }
}
