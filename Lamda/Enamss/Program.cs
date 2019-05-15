using System;

namespace Enamss
{


    enum Day { Mo, Tu, We, Th, Fr, Sa, Su}

    enum Month { Jan, Feb, Mar, Apr, May, Jun, Juy, Aug, Sept, Nov, Dec}

    class Program
    {

        static void Main(string[] args)
        {
            Day fr = Day.Fr;


            Day a = Day.Fr;
            Month jan = Month.Jan;


            Console.WriteLine(fr == a);
            Console.WriteLine((int)Day.Th);
            Console.WriteLine(jan);





            Console.Read();
        }
    }
}
