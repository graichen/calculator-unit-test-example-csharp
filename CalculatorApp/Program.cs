using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("5 + 12.3 = {0}", Calculator.sum(5, 12.3));
            System.Console.WriteLine("63 - 13.5 = {0}", Calculator.minus(63, 13.5));
            System.Console.WriteLine("13.2 / -2.35 = {0}", Calculator.divide(13.2, -2.35));
            System.Console.WriteLine("-4.32 * 11.875 = {0}", Calculator.multiply(-4.32, 11.875));

            System.Console.WriteLine("Thank you");
        }
    }
}
