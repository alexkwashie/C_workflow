using System;


namespace helloworld
{
    class Boss : Employee
    {
        public string CompCar { get; set; }


        public Boss(string CompCar,string firstName, string lastName, int salary):base(firstName, lastName, salary)
        { //base(firstName, lastName, salary) || Take the following from the base class i.e. Employee
            this.CompCar = CompCar;
        }


        public void Lead()
        {
            Console.WriteLine("I am the boss man");
        }

       

    }
}
