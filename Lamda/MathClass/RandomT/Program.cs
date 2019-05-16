using System;

namespace RandomT
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Dice = new Random();

            int dicePlates;


            for (int i = 0; i <10; i++)
            {
                //Next takes 2 numbers
                dicePlates = Dice.Next(1,8);
                Console.WriteLine(dicePlates);

            }
           
        }
    }
}
