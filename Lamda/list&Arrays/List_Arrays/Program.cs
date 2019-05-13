using System;
using System.Collections.Generic;

namespace List_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays are immutable - i.e. limited to on type

            int[] scores= new int[] { 34, 45, 56, 78, 89 };

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            list.Add(75);
            list.Add(109);
            list.Sort();

            //RemoveRange(index, remove how many after the starting index)
            list.RemoveRange(2,3);

            foreach (int i in list)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine(list.Contains(2)); //True

            //create x and make x == to 3; i.e. index = 3
            int index = list.FindIndex(x => x == 75);

            //this find the index value
            Console.WriteLine(list[index]);

            //Remove at the index
            list.RemoveAt(index);

        }
    }
}
