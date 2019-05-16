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
                //Console.WriteLine(dicePlates);

            }


            Random guess = new Random();

            int ans;
            bool fol = true;
            while (fol)
            {
                Console.WriteLine("Ask me any Questions");
                Console.ReadLine();

                ans = guess.Next(1, 4);

                if (ans == 1)
                {
                    Console.WriteLine("Yes");
                }
                else if (ans == 2)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("MayBe");
                    fol = false;
                    Console.WriteLine("Thank you, Restart program");

                }
            }

            
                
            

            Console.Read();
        }
    }
}
