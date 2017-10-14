using System.Collections.Generic;

namespace BuilderPattern
{
    public class ClubSandwichBuilder : SandwichBuilder
    //Concrete builder: Should have more than one concrete builder type. provides an implementation for the Builder interface/abstract class, is a set of ingredients just data.
    {
        public override void AddCondiments()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = false;
        }
        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }
        public override void ApplyMeatAndCheese()
        {
            sandwich.cheeseType = CheeseType.Swiss;
            sandwich.meatType = MeatType.Turkey;
        }
        public override void PrepareBread()
        {
            sandwich.breadType = BreadType.White;
            sandwich.isToasted = false;
        }
    }
}
