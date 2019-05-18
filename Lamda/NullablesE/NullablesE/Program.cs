using System;

namespace NullablesE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nulable are used to pass and (empty/not available) or occupied variable
            //Nullables are used in case a method needs to run regardless of there being a  value or not should run without errors,
            int? num1 = null;
            //int num2 = null; //Error

            double? num3 = new Double?();
            double? num4 = 3.15524;

            bool? num5 = new bool?();


            double? num6 = 19.32;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
                Console.WriteLine(num8);
            }
            else
            {
                num8 = (double)num6; //use casting her6 '(..)'
            }


            Console.WriteLine("Nums8 is {0}", num8);

            //#This is the NULL COALESCING OPERATOR#

            //num8 = if num6 is empty assign 8.44 to it
            num8 = num6 ?? 8.44; //19.32
            Console.WriteLine("Nums8 is {0}", num8);
            num8 = num7 ?? 8.44; //8.44
            Console.WriteLine("Nums8 is {0}", num8);
            Console.Read();




        }
    }
}
