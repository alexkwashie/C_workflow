using System;
using System.Text.RegularExpressions;

namespace RegexT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string pattern = @"\D"; //looking for digits

            Regex regex = new Regex(pattern);

            string text = "Hi there, My ID is 12928542";

            MatchCollection MtchCollect = regex.Matches(text);

            Console.WriteLine("{0} is my Code \n {1}", MtchCollect.Count, text ); //MtchCollect.Count- counts the number of numbers found

            foreach (Match hit in MtchCollect) //Match identifies each number found in the set
            {
                GroupCollection group = hit.Groups; //GroupCollection groups the number as one list

                Console.WriteLine("{0} found at: {1}", group[0].Value, group[0].Index);
            }

            Console.Read();
        }
    }
}
