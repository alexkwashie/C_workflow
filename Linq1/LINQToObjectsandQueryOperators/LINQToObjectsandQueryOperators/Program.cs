using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsandQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
             

        }
    }

    class University
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine( "Universty: {0} with ID: {1}", Id, Name );
        }
    }
}
