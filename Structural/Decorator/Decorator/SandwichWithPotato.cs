using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SandwichWithPotato : SandwichDecorator
    {
        public SandwichWithPotato(Sandwich sandwich) : base(sandwich)
        {
        }

        public override string GetName()
        {
            return $"{base.GetName()} With Potato";
        }

        public override int GetPrice()
        {
            return base.GetPrice() * 50;
        }
    }
}
