using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SandwichDecorator:Sandwich
    {
        private readonly Sandwich _sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public override string GetName()
        {
            return _sandwich.GetName();
        }

        public override int GetPrice()
        {
            return _sandwich.GetPrice();
        }
    }
}
