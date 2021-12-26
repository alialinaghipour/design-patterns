namespace Decorator
{
    public class SmallSandwich : Sandwich
    {
        public override string GetPrice()
        {
            return "SmallSandwich ==> 100";
        }
    }

    public class SmallSandwichWithSauce : Sandwich
    {
        public override string GetPrice()
        {
            return "SmallSandwichWithSauce ==> 120";
        }
    }
}
