using System;

// ##################################### -Sealed Key Word- #####################################

    //A sealed class does not allow use in a deriving class
    //See use in Audi class (Audi.cs)

namespace Polymorphism
{
    class Rs7_subclassAudi_: Audi
    {

        public Rs7_subclassAudi_(int hp, string color, string Model, string brand) : base(hp, color,Model, brand)
        {
            this.Model = Model;
            this.Brand = brand;

        }

        public override void showNews()
        {
            Console.WriteLine("{3} - My car has {2} - {0} HP and color is {1} - from Audi class", HP, Color, Brand, Model);
        }
    }
}
