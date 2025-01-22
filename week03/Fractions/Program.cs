using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1,2);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(15, 27);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
    }
}