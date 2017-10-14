using DecoratorPattern.Objects.Component;
using DecoratorPattern.Objects.Decorator;

namespace DecoratorPattern.Objects.ConcreteDecorators
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza) => Description = "Ham";

        public override string GetDescription()
        {
            return $"{pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return pizza.CalculateCost() + 1.00;
        }
    }
}
