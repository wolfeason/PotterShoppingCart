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
            Dictionary<int, double> discount = Discount();
            double calculate = _Items.Sum(x => x.SellPrice * x.Quantity);

            int number = _Items.Sum(x => x.Quantity);
            calculate = calculate * discount[number];

            int results1 = (int)calculate;
            return results1;
        }

        private Dictionary<int, double> Discount()
        {
            Dictionary<int, double> discount = new Dictionary<int, double>();
            discount.Add(1, 1);
            discount.Add(2, 0.95);
            discount.Add(3, 0.9);
            return discount;
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
