using System;
using DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {

        Person stefan = new();
        stefan.Name = "GoShoW";
        stefan.Age = 30;

        Person monika = new()
        {
            Age = 30,
            Name = "Monika"

        };

        Console.WriteLine($"{monika.Name}: {monika.Age}");
    }
}