using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models.ViewModels
{
    public class CoinViewmodels
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name coin.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter base asset.")]
        public string BaseAsset { get; set; }
        [Required(ErrorMessage = "Please enter quote asset.")]
        public string QuoteAsset { get; set; }
        [Required(ErrorMessage = "Please enter last price.")]
        public string LastPrice { get; set; }
        [Required(ErrorMessage = "Please enter volumn24h.")]
        public int Volumn24h { get; set; }
        public Market MarketId { get; set; }
        [Required(ErrorMessage = "Please choose coin.")]
        public int Status { get; set; }
    }
}