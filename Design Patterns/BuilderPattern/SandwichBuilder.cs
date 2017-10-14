namespace BuilderPattern
{
    public abstract class SandwichBuilder
    // Builder: Abstract interface or class, Defines the steps used by the director, holds an instance of the Product that is going to be created.
    {
        protected Sandwich sandwich;
        public Sandwich GetSandwich() => sandwich;
        public void CreateNewSandwich() => sandwich = new Sandwich();

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}
