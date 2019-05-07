using System;
namespace Polymorphism
{
        class Audi : Car
        {

            public string Model { get; set; }

            public string Brand = "Audi";


        //The (new) means this 'showDetails()' has priority over the 'Car.showDetails()'
        public new void showDetails()
            {
                Console.WriteLine("{3} - My car has {2} - {0} HP and color is {1}", HP, Color, Brand, Model);
            }


        public sealed override void showNews()
        {
            Console.WriteLine("{3} - My car has {2} - {0} HP and color is {1}", HP, Color, Brand, Model);
        }


        public Audi(int hp, string color, string Model, string brand) : base(hp, color)
            {
                this.Model = Model;
                this.Brand = brand;
           
            }

        //After the main the method in the base class is (virtual)
        //Use (override) to overwrite it
        public override void showDetailz()
            {
                Console.WriteLine("I have a {0}", Model);
            }

        }
    }

