namespace Decorator
{
    public class MediumSandwich : Sandwich
    {
        public override string GetName()
        {
            return "MediumSandwich";
        }

        public override int GetPrice()
        {
            return 200;
        }
    }
}
