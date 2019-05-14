using System;
using System.Collections.Generic;

namespace List_Arrays
{

    //Lists can contain only specific objects eg: <int> or <String>
    // ArrayList can contain a mixture of objects

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


            //Using Lambda in lists
            list.ForEach(i => Console.WriteLine(i));


            //Using array list
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add(1);
            arrayList.Add("Six");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 9});

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.Read();

        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }


}
