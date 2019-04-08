using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class Human
    {
        // FOR //AX5

        //member varible
        public string firstName;

        public string lastName;

        private string eyeColor;

        private int age;

        private string yr;

        // Member Method
        public void introName()
        {
            if (age != 0)
            {
                Console.WriteLine("My Full name is {0} {1} and I am {3} years old with {2} eyes.", firstName, lastName, eyeColor, age);
            }
            else if(eyeColor == null)
            {
                Console.WriteLine("My Full name is {0} {1}.", firstName, lastName);
            }
            else
            {
                Console.WriteLine("My Full name is {0} {1} and I have {2} eyes.", firstName, lastName, eyeColor);
            }
        }





        //default constructor
        public Human()
        {
            Console.WriteLine("The is a default constructor");
        }

        //member constructor (parameterized contructor)
        public Human(String fName, string lName, string eColor, int Age)
        {
            firstName = fName;
            lastName = lName;
            this.eyeColor = eColor;
            this.age = Age;

            //or

            // -this.firstName == fName;
            // You can also assign the arguments in the method to the (this) keword.
            //this meaning the whole class
            // You can make th method variables private with the (this keyword)
        }


        public Human(String fName, string lName, string eColor)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.eyeColor = eColor;
         
        }



        public Human(String fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
           

        }


























    }

}