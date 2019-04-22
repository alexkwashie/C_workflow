using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class ArrayasParameters
    {

        public double Getaverage(int[] gradeArray)
        {
            int size = gradeArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradeArray[i];

            }

            average = (double)sum / size;
            return average;
        }


        
    

        public void Exercise(int[] arrade)
            {
                int[] Calc = new int[] { };

                for (int i = 0; i < arrade.Length; i++)
                {
                    arrade[i] += 2;
                }

                
            }

    }
}