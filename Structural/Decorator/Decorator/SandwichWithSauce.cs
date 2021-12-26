using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SandwichWithSauce : SandwichDecorator
    {
        public SandwichWithSauce(Sandwich sandwich) : base(sandwich)
        {
        }

        public override string GetName()
        {
            return $"{base.GetName()} With Sauce";
        }

        public override int GetPrice()
        {
            return base.GetPrice() * 20;
        }
    }
}
