using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class DrinkMenu
    {
        private string _name;
        private string _baseDescription;
        private string _picture;
        private decimal _basePrice;    
        public virtual string Name
        {
            get => _name; set => _name = value;
        }

        public virtual string BaseDescription
        {
            get => _baseDescription; set => _baseDescription = value;
        }

        public virtual string Picture
        {
            get => _picture; set => _picture = value; 
        }

        public virtual decimal BasePrice
        {
            get => _basePrice; set => _basePrice = value; 
        }

        public List<Customization> Customizations { get; set; }
    }
}
