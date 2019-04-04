﻿using System;



namespace helloworld
{
    //Constants are immutable values which are known
    //at complie time and do not change for the life time of the program

    //They must be created outside the static method

    class Program

    {
        //Declearing variables ouside the method make sin global, so you can use it in any method

        //Constant as Fields
        const double PI = 36.15485475588;
        const int week = 52, month = 12;
        const int days = 356;

        const string birthday = "15.11.1998";
        const string day = "Tuesday";


        static int highscore = 300;
         static string highscorePlayer = "denis";




        static void Main(string[] args)

        {

            /*
            int num1 = 13;
            int num2 = 2;

            double id = 3.5;
            double id1 = 50.8;

            double sum1 = id + id1;

            float dec = 5.45f;

            double fsum = num2 + dec;

            string myName = "aleXanDer";

            string convert = myName.ToLower();
            //ALEXANDER


            //explicit conversion
            double myDouble = 37.83;
            int newnum;
            newnum = (int)myDouble; //37

            //implicit conversion
            //Converting int to long & float to double
            int num = 1523544845;
            long newNum = num;

            float num1new = 45.64f;
            double myDoublenum = num1new;



            //String to integer
            string myString = "19";

            string nuMob = "14";

            int uoop = Int32.Parse(myString);
            int rrr = Int32.Parse(nuMob);


           
            
            Console.WriteLine("My birthday will be {0}", birthday, "on {0}", day);
            Console.Read();
        
        //A method to return an integer (OUTPUT)

            WriteSomething();

            Writeer("Chicka");

            string Friend1 = "Dave";
            string Friend2 = "Smith";
            string Friend3 = "Ato";


            Console.WriteLine(Greet(Friend3));
            Console.Read();


            */


            /*
            //Taking input
            Console.WriteLine("What is your name?");

            string get = Console.ReadLine();
            string get1 = Console.ReadLine();


            //Try block is used to validate an Error to do otherwise when it occurs
            try
            {
                int res = int.Parse(get) + int.Parse(get1);
                //eg. if input is not an 'int'
            }
            catch (FormatException) //can also use - Execption - FormatException - OverFLowExecption - ArgumentNullExecption
            {
                //If thers is an error the code below will run
                Console.WriteLine("Please  enter valid input");

                //Use keyword 'throw;' to show exact error details
            }
            catch (ArgumentNullException) //can also use - FormatException - OverFLowExecption - ArgumentNullExecption
            {
                Console.WriteLine("Please  enter valid input");
                
            }

            finally  //Final output: this is call regardless of the outcome from the try statement
            {
                Console.WriteLine("Will be alled any ways");
            }

            //Example to when to use the finaly block is when u make a connection to a database 
            //and want to close the connection after
            
             


            Console.WriteLine("Enter numbers?");
            string input = Console.ReadLine();

            int num1 = 6;

            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Read More");
                Console.Read();
            }
      
            

            // #####################-UNARY OPERATORS-#########################

            int num1 = 6;

            int num2 = 3;

            int num3;


            //unary operators
            num3 = -num1;  // -6

            Console.WriteLine("num3 is now {0}", num3);

            bool isRain = true;

            Console.WriteLine("Is is Raining? {0}", !isRain);


            // INCREMENT OPERATORS

            int num = 0;

            num++;

            Console.WriteLine("New num is {0}", num);
            Console.WriteLine("New num is {0}", num++); //1 (it does take effect immediatley, bu its 2 when (num) is called)

            //Pre Increment
            Console.WriteLine("New num is {0}", ++num); //3 (Takes effect immediately)



            // Relational and type Operator

            bool reso;

            reso = num1 < num2;

            Console.WriteLine("Num1 is lesser than num2? {0}", reso);

            bool reso1;

            reso1 = num1 == num2;
            Console.WriteLine("Num1 is equal to num2? {0}", reso1);

    */


            /*
        // #####################-METHODS-#########################

        // Access modifier (static) return type method name (parameter 1, pararmeter 2)
        // When ever you want to call a method in a static object, you have to make the method static as well
        public static void WriteSomething()
            {
                Console.WriteLine("I am ME!");
                
            }

        public static void Writeer(string args)
        {
            Console.WriteLine("I am the main " + args);
            
        }


        //A method to return an integer

        public static int Add(int para1, int para2)
        {
             return para1 + para2;
        }


        //Use a double (return type) for divisions etc.
        public static double Divide( double para1, double para2)
        {
            return para1 / para2;

        }


        public static string Greet(string args)
        {
          
            return "Goodmorning " + args;
        }


    }
}
*/



            /*

                       // #####################-If-Statement-#########################

                       Console.WriteLine("What si the Temp");
                       string Temp = Console.ReadLine();

                       //int numTemp = int.Parse(Temp);

                       //Whenever any other input is received by a (int) input and error occurs 
                       //and breaks the program, so use the (Tryparse) to fix that 

                       //(Tryparse) can also be used as booleon:
                       // bool tempreture = int.TryParse(Temp, out num)) ei. True
                       //Then if(tempreture){...}

                       int numTemp;

                       int num;

                       if (int.TryParse(Temp, out num)) // if its an (Temp) is a (int) return it as (num)
                       {
                           numTemp = num;
                       }
                       else
                       {
                           numTemp = 0;
                           Console.WriteLine("Please enter valid input, you input is defaulted to 0");
                       }


                       if (numTemp <= 10)
                       {
                           Console.WriteLine("You can where your Jacket");
                       }

                       else if (numTemp < 20)
                       {
                           Console.WriteLine("You can where your Jacket, But not too cold...");
                       }

                       else
                       {
                           Console.WriteLine("Just stay home!");
                       }


               */


            // #####################-Adv. Nested-If-Statement-etc-#########################

            /*
            bool isRegistered = true;

            bool Admin = false;

           
            if (isRegistered)
            {
                Console.WriteLine("Hello Today, Enter username: ");

                string userName = Console.ReadLine();

                if (userName != "")
                {
                    Console.WriteLine("Welcome," + userName);
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hey, Welcome " + userName + " we have bee waiting for you");
                    }
                }
            }

            */



            // #####################-Login-Example-etc-#########################
            bool isReg = false;

            if (!isReg)
            {

            Console.WriteLine("Create username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Create Password: ");
            string Password = Console.ReadLine();



            if (username !="" && Password != "")
            {
                bool isRegi = true;

                    isReg = isRegi;

                    if (isReg)
                    {
                        Console.WriteLine("Please Login Enter username: ");
                        string username1 = Console.ReadLine();

                        Console.WriteLine("Enter Password: ");
                        string Password1 = Console.ReadLine();

                        if (username.Equals(username1) && Password.Equals(Password1))
                        {
                            Console.WriteLine("Welcome, " + username + ", how you been?");
                        }
                        else
                        {
                            Console.WriteLine("Your username or password is incorrect, please restart the program.");
                        }
                    }
            }
            else
            {
                Console.WriteLine("Please Register again");
            }

            }


            // Swith- Case Statments
            int age = 15;

            switch (age)
            {
                case 10:
                    Console.WriteLine("Very young");
                    break;
                case 20:
                    Console.WriteLine("Very Old man");
                    break;
                default:
                    Console.WriteLine("What is your age man?");
                    break;

            }





            Console.ReadLine();


            // #####################-VIDEO 9-#########################
        }




        public static void checkHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                Console.WriteLine("New highscore is " + score);
                  Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.);
            }
        }


    } 

}




