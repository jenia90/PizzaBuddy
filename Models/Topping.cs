namespace MachOneSoftware.PizzaBuddy.Models
{
    public class Topping
    {
        public Topping(string name, ToppingType toppingType)
        {
            Name = name;
            ToppingType = toppingType;
        }

        public string Name { get; }
        public ToppingType ToppingType { get; }
    }
}
