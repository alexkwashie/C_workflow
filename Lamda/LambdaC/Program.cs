using System;

namespace LambdaC
{
    class Program
    {
        // A Lambda expression is an anonymous function that you can use to create delegates
        // or expression tree type. By using lambda expression, you can write local function 
        // that can be passed as an arguments or retuen as the value of function calls. 
        // Lambda expressions are particularly helpful for writing LINQ query expressions.


        // Paramenters => expression/ statement block

        public delegate int SomeMath(int i);

        static void Main(string[] args)
        {

            DoSomething();

        }


        public static void DoSomething()
        {
            SomeMath calc = new SomeMath(Square);

            Console.WriteLine(calc(9));

        }




        public static int Add(int a, int b)
        {
            return a + b;
        }


        public static int Square(int i)
        {
            return i + 1;
        }


        public static int TimesTen(int i)
        {
            return i * 10;
        }

    }


    public class Number
    {
        public int t { get; set; }
    }
}
