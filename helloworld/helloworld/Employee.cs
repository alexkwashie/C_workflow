
using System;
namespace helloworld
/*
Create a main class with a Main Method, then a base class Employee with the properties Name, FirstName, Salary and the methods Work() and Pause().

Create a deriving class boss with the propertie CompanyCar and the method Lead(). Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHourse and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

Don’t forget to create the constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.
Just print out the respective text, what the respective employees.

*/


{
    class Employee
    {

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }


        //Constructor
        public Employee()
        { //this acts as a default paramenter, if there is not para in the invoked method
            //this set conditions will appear
            FirstName = "John";
            LastName = "Sherren";
            Salary = 32555;
        }


        public Employee( string firstName , string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }


        public void work()
        {
            Console.WriteLine("I am working");
        }

        public void pause()
        {
            Console.WriteLine("Pausing is Life");
        }


        public override string ToString()
        {
            //return base.ToString()   //default
            return String.Format("My name is {0} {1} and I am paid {2}", this.FirstName, this.LastName, this.Salary);
        }
    }
}
