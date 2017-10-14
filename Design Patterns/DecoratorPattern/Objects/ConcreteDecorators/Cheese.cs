using DecoratorPattern.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza) => Description = "Cheese";

        public override string GetDescription()
        {
            return $"{pizza.Description}, {Description}";
        }

        public override double CalculateCost()
        {
            return pizza.CalculateCost() + 1.25;
        }
    }
}
