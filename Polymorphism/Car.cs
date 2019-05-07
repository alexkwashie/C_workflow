using System;
namespace Polymorphism


{


    class Car
    {

        protected int HP { get; set; }
        protected string Color { get; set; }


        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Polymorphism - the (virual) keyword allows this method to be overwritten
        public virtual void showDetails()
        {
            Console.WriteLine("My car has  {0} HP and color is {1}", HP, Color);
        }

        public void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }

        //Polymorphism - the (virual) keyword allows this method to be overwritten
        public virtual void showDetailz()
        {
            Console.WriteLine("carry go");
        }

        public virtual void CarDetails()
        {
            Console.WriteLine("My car is a color {0} and it has {1} HP - from base class", Color, HP);
        }

        //Default Contructor - use when derving class has error
        public Car()
        {

        }

        public virtual void showNews()
        {
        }
    }


}