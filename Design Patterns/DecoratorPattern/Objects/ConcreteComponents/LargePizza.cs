using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override double CalculateCost()
        {
            return 9.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
