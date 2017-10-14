using System.Collections.Generic;
using static System.Console;

namespace BuilderPattern
{
    public class Sandwich
    {
        public BreadType breadType { get; set; }
        public bool isToasted { get; set; }
        public CheeseType cheeseType { get; set; }
        public MeatType meatType { get; set; }
        public bool hasMustard { get; set; }
        public bool hasMayo { get; set; }
        public List<string> vegetables { get; set; }

        public void Display()
        {
            WriteLine($"Sandwich on {breadType} bread");
            if (isToasted)
            {
                WriteLine("Toasted");
            }
            if (hasMayo)
            {
                WriteLine("With Mayo");
            }
            if (hasMustard)
            {
                WriteLine("With Mustard");
            }
            WriteLine($"Meat: {meatType}");
            WriteLine($"Cheese: {cheeseType}");
            WriteLine("Veggies:");
            foreach (var vegetable in vegetables)
            {
                WriteLine($"    {vegetable}");
            }
        }
    }
}

public enum MeatType
{
    Turkey,
    Ham,
    Chicken,
    Salami
}
public enum CheeseType
{
    American,
    Swiss,
    Cheddar,
    Provolone
}
public enum BreadType
{
    White,
    Wheat
}
