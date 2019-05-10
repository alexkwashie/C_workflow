using System;
using System.IO;

namespace FileOc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read .txt on Mac
            var path = "/Users/alexkwashie/Desktop/C_workflow/Filehandling/cat.txt";

            StreamReader txt = new StreamReader(path);

            Console.WriteLine(txt.ReadToEnd());

            Console.ReadKey();


            /*
            //Read .txt on Windows

            string text = System.IO.File.ReadAllText(@"Users/alexkwashie/Desktop/C_workflow/Filehandling/cat.txt");

            Console.WriteLine(text);
            */



        }
    }
}
