using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.CsvExtract
{
    public class CsvExtractLine
    {
        public string? CustomerId { get; set; }

        public string? CustomerPhoneNumber { get; set; }
        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public int? CustomerRewardsPoints { get; set; }

        public string? OrderDate { get; set; }

        public decimal? OrderTotal { get; set; }

        public decimal? OrderSubtotal { get; set; }

        public decimal? OrderTax { get; set; }



        public string? OrderDetail { get; set; }
    }
}

