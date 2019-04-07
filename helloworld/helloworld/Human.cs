using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class Human
    {

        //member varible
       public string firstName;

        public string lastName;


        // Member Method
        public void introName()
        {

        Console.WriteLine("My Full name is {0} {1}", firstName, lastName);

        }


        //member constructor
        public Human(String fName, string lName)
        {
            firstName = fName;
            lastName = lName;

            //or

            // -this.firstName = fName;
            // You can also assign the arguments in the method to the (this) keword.
            //this meaning the whole class

            
        }

         




    }

}
