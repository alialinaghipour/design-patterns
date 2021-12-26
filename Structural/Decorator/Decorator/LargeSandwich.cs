namespace Decorator
{
    public class LargeSandwich : Sandwich
    {
        public override string GetPrice()
        {
            return "LargeSandwich ==> 300";
        }
    }
}
