using CoffeePointOfSale.Services.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class Drinks
    {
        /// <summary>
        /// Private dictionary containing all of the customers. Lookup via phone.
        /// </summary>
        [JsonProperty("DrinkMenu")]
        private readonly Dictionary<string, DrinkMenu> _drinkDict = new();
        [JsonIgnore]//not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
        public IReadOnlyList<DrinkMenu> List =>
            _drinkDict.Select(drink => drink.Value)
                .ToList();

        
    }
}
