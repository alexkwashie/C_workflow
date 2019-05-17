using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine("My Bday is {0}", dateTime);

            Console.WriteLine(DateTime.Today.DayOfYear);
            Console.Read();
        }
    }
}
