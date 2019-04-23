using System;
using System.Collections;

namespace helloworld
{
    class Arraylist_
    {
        public void Arrayss() { 
        
            //Declaring an array list
            //Remeber to use (using System.Collections;)

            ArrayList myArraylist = new ArrayList(); //unliminted amount of objects
            ArrayList myArraylist1 = new ArrayList(100); // definiate amount f objects (100 objects)


            myArraylist.Add(24);
            myArraylist.Add("hiya");
            myArraylist.Add(32.33);
           


            //delete element with specific valu from arraylist
            //myArraylist.Remove(32.33);

            //Delete element at specific position
            //myArraylist.RemoveAt(1);

            //Console.WriteLine(myArraylist.Count);

           double sum = 0;

            foreach( object obj in myArraylist)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj); //Convert a object to a double
                }
                else if (obj is double)
                {
                    sum += (double)obj; // using Casting 
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }


                Console.WriteLine( sum );
            }
        }
    }
}
