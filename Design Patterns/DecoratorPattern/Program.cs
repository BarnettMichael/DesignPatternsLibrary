using static System.Console;
using DecoratorPattern.Objects.ConcreteComponents;
using DecoratorPattern.Objects.Component;
using DecoratorPattern.Objects.ConcreteDecorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Pepper(largePizza);

            WriteLine(largePizza.GetDescription());
            WriteLine($"{largePizza.CalculateCost():C2}");

            ReadKey();
        }
    }
}
