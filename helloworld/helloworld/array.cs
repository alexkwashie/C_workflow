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



            //FOR EACH LOOPS
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i+10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Elements{0} = {1}", j, nums[j]);
            }


            Console.WriteLine(nums);
            Console.Read();

        }


        


    }
}
