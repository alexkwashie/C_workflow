using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine("My Bday is {0}", dateTime);


            Console.WriteLine(DateTime.Today.DayOfYear); //today days of the year (int) 
            Console.WriteLine(DateTime.Today.DayOfWeek); //todays day of he week


            int days = DateTime.DaysInMonth(2019, 3);

            Console.WriteLine("March in 2019 has {0}", days);

            Console.WriteLine("You will be paid on {0}", GetTomorrow());



            int nextweekday = DateTime.DaysInMonth(GetTomorrow().Year,GetTomorrow().Month);

            Console.WriteLine(nextweekday);

            DateTime time = DateTime.Now;

            Console.WriteLine("The time is {0} O'clock and {1} minutes and {2} seconds", time.Hour, time.Minute, time.Second);


            //Find days between 2 dates:
            Console.WriteLine("Please Enter a date like so yyyy-mm-dd");
            string input = Console.ReadLine();

            //tryParse take the input and the dateTime module
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(time);
                TimeSpan daysPassed = time.Subtract(dateTime);
                Console.WriteLine("Its been {0} days since", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }


            Console.Read();
        }

        //Use a static Method in the same file as the (static void Main) but just outside it
        static DateTime GetTomorrow()
        {
            //takes todays date and adds one day
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetNextweek()
        {
            //takes todays date and adds one day
            return DateTime.Today.AddDays(7);
        }
    }
}
 