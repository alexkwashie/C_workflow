using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class array
    {

        public void Arrats()
        {

            //declare and initialize arrays
            int[] grade = new int[5];

            grade[0] = 21;
            grade[1] = 42;
            grade[2] = 12;
            grade[3] = 18;
            grade[4] = 5;

            Console.WriteLine(grade[4]);

            //Assign a value to array grads at index 2
            //string input = Console.ReadLine();
            //grade[2] = int.Parse(input);
            Console.WriteLine("Grade 2 is: {0} ", grade[2]);


            //Another way of initialzing arrays
            int[] gradeOfStudents = { 12, 5, 63, 24, 58, 22 };

            //Another way of initialzing arrays
            int[] gradeOfStudents2 = new int[] { 11, 12, 5, 63, 24, 58, 22 };

            //get lenght 
            int getLenght = gradeOfStudents.Length;

            Console.WriteLine(getLenght);



            //FOR EACH LOOPS & LOOPS
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i+10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Elements{0} = {1}", j, nums[j]);
            }

            //OR use foreach loop
            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Elements{0} = {1}", counter, k); counter++;

            }
            Console.WriteLine(nums);

            string[] friends = { "kev", "jon", "roni", "uppa", "gop" };

            int count = 0;

            foreach (string name in friends)
            {
                Console.WriteLine("Goodmorning {0}", friends[count]);
                count++;
            }


            //declare 2D Array
            string[,] matrix;

            //3D Array
            int[,,] threeD;


            int[,] array2D = new int[,]
            {
                {9,5,3}, //row 0
                {4,5,2}, //row 1
                {3,3,1}  //row 2
            };


            //access 2D array
            Console.WriteLine(array2D[2, 1]);


            string[,,] pixel = new string[,,]
            {
                {
                    {"pew","mol","bon"},
                    {"waf","ler","neq"},
                    {"ewe","mdol","hen"}

                },

                {
                    {"745","654","489"},
                    {"213","222","512"},
                    {"845","862","541"}

                },
                {
                    {"542","456","584"},
                    {"846","838","874"},
                    {"545","895","524"}

                }
            };

            Console.WriteLine(pixel[1, 1,2]);

            //create a 2D Array
            string[,] pixel1 = new string[3, 2]
            {
                {"one","two"},
                { "four", "five"},
                { "seven", "six"}
            };

            pixel1[1, 1] = "ten";

            Console.WriteLine(pixel1[1,1]); //ten


            //Check dimesions of Array
            int dimensions = pixel.Rank;
            Console.WriteLine(dimensions);
            Console.Read();

        }


        


    }
}
