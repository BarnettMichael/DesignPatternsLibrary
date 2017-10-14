namespace BuilderPattern
{
    public class SandwichMaker
    {
        // Director - Uses the concrete builder, knows how to build an object, client code calls directly.
        private readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder builder) => this.builder = builder;

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwich() => builder.GetSandwich();        
    }
}
