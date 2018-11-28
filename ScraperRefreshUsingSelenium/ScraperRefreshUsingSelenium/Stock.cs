using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScraperRefreshUsingSelenium
{
    class Stock
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public string Currency { get; set; }
        public string AverageVolume { get; set; }
        public string MarketCap { get; set; }
        public decimal Price { get; set; }
        //public System.DateTime ScrapeTime { get; set; }
    }
}
