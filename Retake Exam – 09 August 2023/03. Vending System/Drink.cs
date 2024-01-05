using System;
using System.Collections.Generic;
using System.Text;

namespace VendingSystem;

public class Drink
{
    public Drink(string name, decimal price, int volume)
    {
        Name = name;
        Price = price;
        Volume = volume;
    }

    public string Name { get; set; }
    //•	Name – string
    public decimal Price { get; set; }
    //•	Price - decimal
    public int Volume { get; set; }
    //•	Volume - int


    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Name: {Name}, Price: ${Price}, Volume: {Volume} ml");

        return sb.ToString().TrimEnd();
    }

}
