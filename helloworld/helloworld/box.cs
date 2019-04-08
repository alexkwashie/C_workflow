using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class box
    {
        //Exercise
        //Create a read only property to calculate Frontsurface area by lenght and height

        private int len;
        private int hight;

        public void fntsurf(int len1, int hight1)
        {
            this.len = len1;
            this.hight = hight1;
        }

        public int FrontSurface {
            get {

                return len * hight;

            }

        }



        public int lenght;
        public int width;
        public int volume;
        //You can use a string hidden or private
        private int size;

        //For private keys

        //easy whay of wrting code below
        // auto - implented property - type "prop" + press tab

        //#####Encupsulation is the process of using properties######
        // Properties are often read(get) and write only (set)/
        //But propertie can also be only read or write only
        //Example:

        //read(get) only
        public int Width1
        {
            get
            {
                return width;
            }
        }

        //Write(set) only
        public int Width2
        {
            set
            {
               width = value;
            }
        }


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
                //add (value = -value) to change negative number to positive
            }
        }


        //Another way of writing properties
        public int area
        {
            get => area;
                
            set => area = value;
            
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
