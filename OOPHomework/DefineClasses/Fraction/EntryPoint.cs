namespace Fraction
{
    using System;

    public class EntryPoint
    {
        static void Main()
        {
            Fraction fract1 = new Fraction();
            Fraction fract2 = new Fraction();
            Fraction result = new Fraction();

            fract1.Numerator = 5;
            fract1.Denominator = 3;

            fract2.Numerator = 5;
            fract2.Denominator = 4;

            Console.WriteLine("Fraction 1 Numerator: {0}", fract1.Numerator);
            Console.WriteLine("Fraction 1 Denominator: {0}", fract1.Denominator);
            Console.WriteLine("Fraction 2 Numerator: {0}", fract2.Numerator);
            Console.WriteLine("Fraction 2 Denominator: {0}", fract2.Denominator);
            Console.WriteLine();

            Console.WriteLine("Addition: ");
            result = fract1 + fract2;
            Console.WriteLine("Fractal value: {0}", result.FractValue);
            Console.WriteLine("Decimal value: {0}", result.DeciValue);
            Console.WriteLine();

            Console.WriteLine("Subtraction: ");
            result = fract1 - fract2;
            Console.WriteLine("Fractal value: {0}", result.FractValue);
            Console.WriteLine("Decimal value: {0}", result.DeciValue);
            Console.WriteLine();

            Console.WriteLine("Multiplication: ");
            result = fract1 * fract2;
            Console.WriteLine("Fractal value: {0}", result.FractValue);
            Console.WriteLine("Decimal value: {0}", result.DeciValue);
            Console.WriteLine();

            Console.WriteLine("Division: ");
            result = fract1 / fract2;
            Console.WriteLine("Fractal value: {0}", result.FractValue);
            Console.WriteLine("Decimal value: {0}", result.DeciValue);
        }
    }
}
