using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
            //GetCount = getCount;
        }

        public int ButtonCapacity { get; set; }
        //        •	ButtonCapacity - int
        public List<Drink> Drinks { get; set; }
        //•	Drinks – List<Drink>
        public int GetCount => Drinks.Count();
        //•	GetCount  - int - returns the number of drinks, available in the Vending machine.

        //•	Method AddDrink(Drink drink) – adds an entity to the collection of Drinks, if the Capacity allows it.

        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity > Drinks.Count)
            {
                Drinks.Add(drink);
            }
        }
        //•	Method RemoveDrink(string name) – removes a drink by given name, if such exists, and returns boolean (true if it is removed, otherwise – false)
        public bool RemoveDrink(string name) => this.Drinks.Remove(this.Drinks.FirstOrDefault(n => n.Name == name));

        //•	Method GetLongest() – returns the Drink with the biggest value of Volume property.
        public Drink GetLongest()
        {
            Drink drink = this.Drinks.OrderByDescending(d => d.Volume).FirstOrDefault();
            return drink;
        }

        //•	Method GetCheapest() – returns the Drink with the lowest value of Price property.
        public Drink GetCheapest()
        {
            Drink drink = this.Drinks.OrderBy(d => d.Price).FirstOrDefault();
            return drink;
        }

        //•	Method BuyDrink(string name) - returns a string in the format of the overriden ToString() method.

        public string BuyDrink(string name)
        {
            Drink drink = this.Drinks.FirstOrDefault(d => d.Name == name);
            return drink.ToString().TrimEnd();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Drinks available:");

            foreach (Drink drink in Drinks) { sb.AppendLine(drink.ToString()); }
            return sb.ToString().TrimEnd();
        }
    }

}
