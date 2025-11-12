using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f.GetTop());
        Console.WriteLine(f.GetBottom());

        f.SetTop(5);
        f.SetBottom(9);

        Console.WriteLine(f.GetTop());
        Console.WriteLine(f.GetBottom());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}