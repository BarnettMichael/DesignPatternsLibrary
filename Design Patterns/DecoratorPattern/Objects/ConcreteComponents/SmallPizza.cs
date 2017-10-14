using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        public override double CalculateCost()
        {
            return 3.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
