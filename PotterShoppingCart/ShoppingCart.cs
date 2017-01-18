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

            double calculate = 0;
            var container = _Items;

            while (container.Max(m => m.Quantity) > 0)
            {
                var temp = container.Distinct().ToList();
                int number = temp.Where(n => n.Quantity > 0).Select(n => n.Volume).Count();
                calculate += temp.Where(c => c.Quantity > 0).Sum(c => c.SellPrice) * discount[number];

                foreach (var v in container)  v.Quantity--;
            }

            int results1 = (int)calculate;
            return results1;
        }

        private Dictionary<int, double> Discount()
        {
            Dictionary<int, double> discount = new Dictionary<int, double>();
            discount.Add(1, 1);
            discount.Add(2, 0.95);
            discount.Add(3, 0.9);
            discount.Add(4, 0.8);
            discount.Add(5, 0.75);
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
