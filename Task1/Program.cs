using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Operators class
        Operators op = new Operators();

        // Call all methods
        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);

        // Check Odd or Even
        op.OddEvenFinder(7);
        op.OddEvenFinder(12);
    }
}
