using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Sandwich
    {
        public abstract string GetPrice();
    }

    public class LargeSandwich : Sandwich
    {
        public override string GetPrice()
        {
            return "LargeSandwich ==> 300";
        }
    }

    public class MediumSandwich : Sandwich
    {
        public override string GetPrice()
        {
            return "MediumSandwich ==> 200";
        }
    }

    public class SmallSandwich : Sandwich
    {
        public override string GetPrice()
        {
            return "SmallSandwich ==> 100";
        }
    }
}
