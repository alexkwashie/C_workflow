using System;

namespace Structs
{

    struct Game
    {
        public string name;
        public string developer;
        public int age;
        public string releaseDate;


        //Can use structs for defing constructors
        public Game(string name, string developer, int age, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.age = age;
            this.releaseDate = releaseDate;
        }


        public void Display()
        {
            Console.WriteLine("Game is called: {0}", name);
            Console.WriteLine("Game is titi: {0}", developer);
            Console.WriteLine("Game is years: {0}", age);
            Console.WriteLine("Game is date: {0}", releaseDate);

        }




    }


    class Program
    {
        static void Main(string[] args)
        {

            Game game1;

            game1.name = "Fornite";
            game1.developer = "Niaplo";
            game1.age = 42 ;
            //game1.Display(); //Error
            game1.releaseDate = "03 / 03 / 1928";

            //Use after all paramenters are valid
            // game1.Display();


            Console.WriteLine("Game is called: {0}", game1.name);
            Console.WriteLine("Game is called: {0}", game1.developer);
            Console.WriteLine("Game is called: {0}", game1.age);
           
            Console.WriteLine("Game is called: {0}", game1.releaseDate);


            Console.Read();
        }
    }
}
