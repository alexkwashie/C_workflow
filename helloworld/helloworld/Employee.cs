using System;
namespace helloworld
{
    class Employee
    {

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }


        //Constructor
        public Employee()
        {
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
