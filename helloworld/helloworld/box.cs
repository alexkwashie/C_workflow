using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class box
    {
        public int lenght;
        public int width;
        public int volume;
        //You can a string hidden or private
        private int size;

        //For private keys

        //easy whay of wrting code below
        // auto - implented property - type "prop" + press tab
        public int Width
        {
            get
            {
                return width;
            }
            set
            {

                if (value < 0) throw new Exception("Please enter a positive number");
                width = value;
                //add (value = -value) to change negative numbe to positive
            }
        }


        public int area
        {
            get
            {
                return area;
                
            }
            set
            {
                area = value;
            }
        }
         
        
        public void Setsize(int sizes)
        {
            this.size = sizes; 
        }

        public void calcVolume()
        {
            Console.WriteLine("The height of this object is {0} and the width is {1} which gives a volume of {2}", lenght, width, volume= lenght* width*size);
        }

    }
}
