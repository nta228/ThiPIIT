using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public string LastPrice { get; set; }
        public int Volumn24h { get; set; }
        public Market MarketId { get; set; }
        public int Status { get; set; }
    }
}