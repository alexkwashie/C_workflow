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





        public int Exercise(int[] arrade)
        {

              for (int i = 0; i < arrade.Length; i++)
                {
                  int six = arrade[i] += 2;
                }

            return six;


            }

    }
}