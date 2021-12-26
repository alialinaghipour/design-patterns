namespace Decorator
{
    public class SmallSandwich : Sandwich
    {
        public override string GetName()
        {
            return "SmallSandwich";
        }

        public override int GetPrice()
        {
            return 100;
        }
    }
}
