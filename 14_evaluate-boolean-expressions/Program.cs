﻿Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("\nInequality operator:\n");

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine("1" != "2");

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

Console.WriteLine("\nComparison Operators:\n");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);