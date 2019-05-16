using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(14.34)); //Rounds up - 15
            Console.WriteLine("Ceiling: " + Math.Floor(14.34)); //Rounds downwards - 14


            int num1 = 13;
            int num2 = 5;

            Console.WriteLine("The lower of {0} and {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("The higher of {0} and {1} is {2}", num1, num2, Math.Max(num1, num2));
            Console.WriteLine("Raised to the power of {0} and {1} is {2}", num1, num2, Math.Pow(num1, num2));
            Console.WriteLine("Squar root of {0} is {1} ", num2, Math.Sqrt(num2));
            Console.WriteLine("PI is: {0}", Math.PI);

            Console.WriteLine("Always Positive is {0}", Math.Abs(-45));

            Console.Read();
        }
    }
}
