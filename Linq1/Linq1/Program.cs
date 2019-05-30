﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7,8,9};

            OddNumber(arr);

            Console.Read();
        }


        static void OddNumber(int[] ar)
        {
            Console.WriteLine("Odd numbers:");

            IEnumerable<int> oddNumber = from num in ar where num % 2 != 0 select num;


            foreach (int i in oddNumber)
            {
                Console.WriteLine(i);
            }
           
     
        }
    }
}
