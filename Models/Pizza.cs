using System.Collections.Generic;

namespace MachOneSoftware.PizzaBuddy.Models
{
    public class Pizza
    {
        public Pizza(string name,
                     PizzaType pizzaType,
                     List<Topping> toppings,
                     CrustType crustType = CrustType.Regular,
                     SauceType sauceType = SauceType.Regular)
        {
            Name = name;
            PizzaType = pizzaType;
            Toppings = toppings;
            CrustType = crustType;
            SauceType = sauceType;
        }

        public string Name { get; }
        public PizzaType PizzaType { get; }
        public List<Topping> Toppings { get; }
        public CrustType CrustType { get; set; }
        public SauceType SauceType { get; }
    }
}