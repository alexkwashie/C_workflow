using System;

namespace helloworld
{
    class Trainee: Employee
    {
       public string WorkingHours { get; set; }
        public string SchoolHours { get; set; }
        public int workHours { get; set; }

        public void Learn()
        {
            Console.WriteLine("...Still learning");
        }

        public Trainee(string WorkingHours, string firstName, string lastName, int salary, int workHours) : base(firstName, lastName, salary)
        { //base(firstName, lastName, salary) || Take the following from the base class i.e. Employee
            this.WorkingHours = WorkingHours;
            this.workHours = workHours;
        }

         
        public new void work() //using the same method name from Employee.cs overights it somw what so use the new keyword to fix
        {
            Console.WriteLine("I work for {0} hours", this.workHours);
        }


        public override string ToString()
        {
            return string.Format("My name is {0} {1} and I am paid {2}, my hours are {3}", this.FirstName, this.LastName, this.Salary, this.WorkingHours);
        }
    }
}
