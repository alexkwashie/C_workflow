using System;
namespace Polymorphism
{

    class BMW: Car
    {
        public string Model { get; set; }

        private string Brand = "BMW";

        //After th main tmethod in the base clas is (virtual)
        //Use (override) to overwrite it
        public override void showDetails()
        {
            Console.WriteLine("{3}-M car has {2} - {0} HP and color is {1}", HP, Color, Brand, Model);
        }

        public BMW(int hp, string color, string Model, string brand) : base (hp, color)
        { 
            this.Model = Model;
            this.Brand = brand;
        }


        //After the main method in the base class is (virtual)
        //Use (override) to overwrite it
        public override void showDetailz()
        {
            Console.WriteLine("I have a {0}", Model);
        }


        public new void CarDetails()
        {
            Console.WriteLine("From BMW class -My car is a color {0} and it has {1} HP - Model: {2} - Brand: {3}", Color, HP, Model, Brand);
        }



    }
}
