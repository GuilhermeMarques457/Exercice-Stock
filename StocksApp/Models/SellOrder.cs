﻿using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class SellOrder
    {
        public Guid SellOrderID { get; set; }

        [Required()]
        public string StockSymbol { get; set; }
        [Required()]
        public string StockName { get; set; }
        public DateTime? DateAndTimeOfOrder { get; set; }

        [Range(0, 100000)]
        public uint? Quantity { get; set; }

        [Range(0, 10000)]
        public double? Price { get; set; }
    }
}
