﻿using System.Diagnostics;

string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"\nClearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}