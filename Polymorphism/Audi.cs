﻿using System;
namespace Polymorphism
{
        class Audi : Car
        {

            public string Model { get; set; }

            private string Brand = "Audi";


            public void showDetails()
            {
                Console.WriteLine("{3} - My car has {2} - {0} HP and color is {1}", HP, Color, Brand, Model);
            }

            public Audi(int hp, string color, string Model, string brand) : base(hp, color)
            {
                this.Model = Model;
                this.Brand = brand;
           
            }

        //After th main tmethod in the base clas is (virtual)
        //Use (override) to overwrite it
        public override void showDetailz()
            {
                Console.WriteLine("I have a {0}", Model);
            }

        }
    }
