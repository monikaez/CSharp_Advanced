﻿// See https://aka.ms/new-console-template for more information

using _04.Froggy;

List<int> stones = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Lake lake = new(stones);

Console.WriteLine(string.Join(", ",lake));
