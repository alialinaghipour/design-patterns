namespace Decorator
{
    public class LargeSandwich : Sandwich
    {
        public override string GetName()
        {
            return "LargeSandwich";
        }

        public override int GetPrice()
        {
            return 300;
        }
    }
}
