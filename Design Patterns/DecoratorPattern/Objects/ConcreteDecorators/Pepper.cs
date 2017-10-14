using DecoratorPattern.Objects.Component;
using DecoratorPattern.Objects.Decorator;

namespace DecoratorPattern.Objects.ConcreteDecorators
{
    public class Pepper : PizzaDecorator
    {
        public Pepper(Pizza pizza) : base(pizza) => Description = "Peppers";

        public override string GetDescription()
        {
            return $"{pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return pizza.CalculateCost() + 2.00;
        }
    }
}
