using System;
using System.Collections.Generic;

namespace Polymorphism
{

        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console 
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

          
    class Program
    {
        static void Main(string[] args)
        {

            //base can call any function of deriving class
            Car Bmw = new BMW(800, "290i", "grey", "BMW");
           
            Bmw.showDetails();
            Bmw.showDetailz();

            //Create a list of cars
            var cars = new List<Car>
            {
                new BMW(2000, "Yellow","320i", "BMW"),
                new Audi(700, "Green","RS7", "Audi")
            };

            //loop through list to get showdetails() of each object
            foreach (var ride in cars)
            {
                //ride.showDetails();
            }


            Car Benz = new Car(300, "Purple");

            //Benz.CarDetails();



            BMW benz = new BMW(450,"Blue","C63","Merc");

            //benz.CarDetails();


            //to show content of base class on deriving member
            Car carb = (Car)benz;

            carb.CarDetails();


            //######## - SEALED - ######
            //Rs7_subclassAudi_.cs

            Rs7_subclassAudi_ Rs7 = new Rs7_subclassAudi_(890, "Indigo", "RS77", "S-Line");

            Rs7.showNews();


            //Works on oly new classes created here
            Bmw.SetCarID(32, "Mr. Amponsah");

            Bmw.GetCarIDinfo();


            Console.ReadKey();
        }
    }
}

























// a car can be a BMW, an Audi, a Porsche etc.
// Polymorphism at work #1: an Audi,  BMW, Porsche
// can all be used whereever a Car is expected. No cast is
// required because an implicit conversion exists from a derived 
// class to its base class.