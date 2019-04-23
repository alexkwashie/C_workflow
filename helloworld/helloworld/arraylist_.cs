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

            Console.WriteLine(myArraylist.Count);
        }
    }
}
