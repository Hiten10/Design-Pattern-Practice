using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PremiumPreorder : OrderDecorator
    {
        public PremiumPreorder(OrderBase order)
            : base(order)
        {
        }

        public override double CalculateTotalOrderPrice(List<Product> products)
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreorder)} class.");
            var preOrderPrice = base.CalculateTotalOrderPrice(products);

            Console.WriteLine("Adding additional discount to a preorder price");
            return preOrderPrice * 0.9;
        }
    }
}
