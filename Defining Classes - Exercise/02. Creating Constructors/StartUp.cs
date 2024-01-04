
using DefiningClasses;
using System;

public class StartUp
{
    static void Main(string[] args)
    {

        Person monika = new("Monika", 30);

        Console.WriteLine($"{monika.Name}:{monika.Age}");
    }
        
}