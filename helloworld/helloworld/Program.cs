using System;



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


            /*
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
            
    */

            /*
            
            checkHighscore(300, "smith");
            checkHighscore(200, "joe");
            checkHighscore(310, "smith");

            Console.ReadLine();



            // #####################-VIDEO 9-#########################
        }


        //Exercise
        //Note: Varaibles are global

        public static void checkHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score; //update the highscore to the score
                highscorePlayer = playerName; //and update highscoreplayer

                Console.WriteLine("New highscore is " + score);
                  Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
            */




            // ternary();   //FOR AX1


            // loops();     //FOR AX2



            // DoWhile();     //FOR AX3


            // whiley();      //FOR AX4



            //####################-OOP-#########################  //AX5

            // -  Human Alex = new Human("Alexo",);

            /* Alex.introName();


             Human Joe = new Human("Joey", "Kishh", "Blue", 19);
             Joe.introName();



             Human kos = new Human("AKosua", "Bruwaa", "Green", 17);

             kos.introName();


             Human Ben = new Human("Ben", "Bra", "yellow");

             Ben.introName();


             Human kev = new Human();
             kev.introName();


             Human kiki = new Human("kiki", "johnson");
             kiki.introName();
             Console.Read();

             //####################-OOP-#########################

             


            //Encupluslation
            //####################-Properties-#########################
            box cube = new box();
            cube.Width = -2;
            cube.lenght = cube.Width;
            cube.width = 13;
            cube.volume = 5;

            cube.Setsize(1);

            cube.area = 3;

            cube.calcVolume();


            
            Console.Read();

            


            //Exersice
            box cube1 = new box();

            cube1.fntsurf(5, 3);

            Console.WriteLine(cube1.FrontSurface);
            Console.Read();

            

            //members.cs
            members jobby = new members();

            jobby.Introducing(false);

            Console.Read();
            */



            /*    
             *array.cs*    
            array arrayz = new array();

            arrayz.Arrats();
            */



            /*
             *  jagged_Arrays.cs*
            jagged_Arrays jaggd = new jagged_Arrays();

            jaggd.Jged();

            */





            // Array as a paramenter



            /*
             ArrayasParameters pramStu = new ArrayasParameters();
            int[] studentGrade = new int[] { 12, 14, 15, 20, 16 };

             double avgResult = pramStu.Getaverage(studentGrade);

            foreach (int grade in studentGrade)
            {
                Console.WriteLine("The grade is {0}", grade);
            }

            Console.WriteLine("The Average is {0}", avgResult);
            Console.Read();

            */

            /*
             * 

            ArrayasParameters para1 = new ArrayasParameters();
            int[] happiness = new int[] { 13, 11, 43, 26, 55 };

            int results = para1.Exercise(happiness);

            foreach (int grade in happiness)
            {
                Console.WriteLine("The grade is {0}", results);
            }

            Console.WriteLine(results);
            Console.Read();
            */


            Arraylist_ prambol = new Arraylist_();

            prambol.Arrayss();




//######################### - OPP Inheritance - ######################### 




        }







        //AX1 
        /* public static void ternary()
        {

            int temp = -5;
            string matter;

            if (temp < 0)
            {
                matter = "Frozen state";
            }
            else
            {
                matter = "liquid state";
            }

            //in short
            matter = temp < 0 ? "Frozen state" : "liquid state";

            temp = +20;

            //OR
            matter = temp > 100? "gas" : temp < 0 ? "Frozen state" : "liquid state";


            Console.WriteLine("The object is in a {0}",matter);
            Console.Read();
        }
        */


        /* AX2

         LOOPS

        public static void loops()
        {

            for(int num = 1; num < 20; num+=2)
            {
                Console.WriteLine(num);

            }

            Console.Read();
        }
        */


        /*
        //AX3
        public static void DoWhile()
        {

        ***Stage 1***
        int counter = 0;

         do
         {
             Console.WriteLine(counter);
             counter++;
         } while (counter < 5);

         Console.Read();


        ***Stage 2***
        int lenghtText = 0;
        string nameText = "";

        do
        {
            Console.WriteLine("Enter Friend Name: ");
            string frdName = Console.ReadLine();
            int namelenght = frdName.Length;
            lenghtText += namelenght;
            nameText += frdName;

        } while (lenghtText < 15);

        Console.WriteLine("Thats Enough " + nameText);

        Console.Read();
       //Thats Enough kevooSmitthpossy




        //***Stage 3***

        //Exercise 1 - Enter number of students, plus get grade of each student and calculate the average
        //grade of students

        int num = 0;

        string grade = "";

        int grade1 = 0;

        int grade2;
        Console.WriteLine("Number of students: ");
        string numberS = Console.ReadLine();

        do
        {
            Console.WriteLine("Enter Student Grade: ");
            grade = Console.ReadLine();
            grade1 += int.Parse(grade);
            grade2 = grade1 / int.Parse(numberS);
            num++;

        } while (num < int.Parse(numberS));

        Console.WriteLine("The Average grade is " + grade2);

        Console.Read();




    }



        // AX4
        public static void whiley()
        {

            string take = "";
            int counter = 0;

            while(take.Equals("") ){
                Console.WriteLine("Press Enter to add data.");
                take = Console.ReadLine();

                counter++;
                Console.WriteLine("People count is {0}",counter);

                if (take != "")
                {
                    Console.WriteLine("There are " + counter + " kids on the bus");
                    break;
                }
            }

            Console.Read();

        }
               
    */














    }

}




