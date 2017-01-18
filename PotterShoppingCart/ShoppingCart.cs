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
            int results1 = _Items.Sum(x => x.SellPrice * x.Quantity);
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
