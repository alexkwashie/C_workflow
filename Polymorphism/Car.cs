using System;
namespace Polymorphism


{


class Car
    {

        protected string HP { get; set; }
        protected string Color { get; set; }


        public void CarProp(string myHP, string myColor)
        {
            this.HP = myHP;
            this.Color = myColor;
        }


        public void showDetails()
        {
            Console.WriteLine("My car is {0} and color is {1}", HP, Color);
        }

        public void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
