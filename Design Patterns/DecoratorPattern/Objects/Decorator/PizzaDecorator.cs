using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(Pizza pizza) => this.pizza = pizza;
        public override double CalculateCost()
        {
            return pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return pizza.Description;
        }
    }
}
