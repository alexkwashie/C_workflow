using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class jagged_Arrays
    {
        //Jagged arrays are arrays within an array or multiple array within one array


        public void Jged()
        {

            int[][] jaggedAray = new int[3][]; //define number of arrays

            jaggedAray[0] = new int[5];
            jaggedAray[1] = new int[4];
            jaggedAray[2] = new int[2];


            jaggedAray[0] = new int[] { 3, 4, 2, 7, 6 };
            jaggedAray[1] = new int[] { 2, 7, 6, 9 };
            jaggedAray[2] = new int[] {13, 26 };


            //Alternative way to declare jagged variables

            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 3, 4, 2, 7, 6 },
                new int[] {5, 7, 12, 45}
            };


          


            Console.WriteLine(jaggedArray1[0]);
       
            // List all the content of the JaggedArray1
            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                Console.WriteLine(i);

                for (int j = 0; j < jaggedArray1[i].Length; j++)
                    Console.WriteLine("{0}", jaggedArray1[i][j]);
            }

            //Cann create an array outside and place it in another array
            string[] joesFamily = new string[] { "Moda", "Jolly"};

            string[][] Family = new string[][]
           {
                new string[] { "kev", "joan"},
                new string[] {"calo", "pomo"},
                new string[] { "polo", "smith" },
                joesFamily
           };


            Console.WriteLine("{0} says 'good morning' to {1}", Family[0][0], Family[2][1]);
            Console.WriteLine(Family[3][0]); //Moda

          Console.Read();
        }

    }
}
