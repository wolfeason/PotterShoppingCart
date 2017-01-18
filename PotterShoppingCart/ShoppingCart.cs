using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public int CalculateShoppingCart(IEnumerable<CarItem> _Items)
        {
            double discount = 0.95;
            double calculate = _Items.Sum(x => x.SellPrice * x.Quantity);

            int number = _Items.Sum(x => x.Quantity);
            if (number == 2) calculate = calculate * discount;

            int results1 = (int)calculate;
            return results1;
        }
    }

    public class CarItem
    {
        public int Volume { get; set; }
        public string Name { get; set; }
        public int SellPrice { get; set; }
        public int Quantity { get; set; }
    }
}
