using System;
using System.Collections.Generic;

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

        public delegate bool Compare(int a, Number t);

        static void Main(string[] args)
        {

            DoSomething();

        }


        public static void DoSomething()
        {
            SomeMath calc = new SomeMath(Square);
            //(calc) becomes SomeMath(Square(int i))

            Console.WriteLine(calc(9));


            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
                // or for Oddnumbers = ( return (i % 2 == 1))

            }); 

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }


            //####Using Lamda functions

            List<int> oddNumbers = list.FindAll(i=>i % 2 == 1);
            oddNumbers.ForEach(i =>
            {
                Console.WriteLine("Odd number is: ");
                Console.WriteLine(i);
        });




            calc = new SomeMath(x => x * x * x);

            Console.WriteLine(calc(8));


            //####Using Lamda functions
            Compare Grades = (a, number ) => a == number.t;

            Console.WriteLine(Grades(6,new Number { t = 6 }));

        }




        public static int Add(int a, int b)
        {
            return a + b;
        }


        public static int Square(int i)
        {
            return i * i;
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
