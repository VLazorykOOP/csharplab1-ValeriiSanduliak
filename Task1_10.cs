#nullable enable
using System;

static void task1_10()
{
    Console.Write("Input V : ");
    string? input = Console.ReadLine();
    if (double.TryParse(input, out double v))
    {
        double sideLength = Math.Pow(v, 1.0 / 3.0);
        Console.WriteLine(
            "The edge length of a cube with volume " + v + " is equal to: " + sideLength
        );
    }
    else
    {
        Console.WriteLine("Incorrect value. Input correct value.");
    }
}
Console.WriteLine("Task1_10: ");
task1_10();
