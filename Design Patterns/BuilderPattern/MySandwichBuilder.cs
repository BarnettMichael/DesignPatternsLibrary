using System.Collections.Generic;

namespace BuilderPattern
{
    public class MySandwichBuilder : SandwichBuilder
        //Concrete builder: Should have more than one concrete builder type. provides an implementation for the Builder interface/abstract class, is a set of ingredients just data.
    {
        public override void AddCondiments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = false;
        }
        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion" };
        }
        public override void ApplyMeatAndCheese()
        {
            sandwich.cheeseType = CheeseType.American;
            sandwich.meatType = MeatType.Turkey;
        }
        public override void PrepareBread()
        {
            sandwich.breadType = BreadType.Wheat;
            sandwich.isToasted = false;
        }
    }
}
