using System;

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

            Console.WriteLine("Hello World!");
        }
    }
}

























// a car can be a BMW, an Audi, a Porsche etc.
// Polymorphism at work #1: an Audi,  BMW, Porsche
// can all be used whereever a Car is expected. No cast is
// required because an implicit conversion exists from a derived 
// class to its base class.