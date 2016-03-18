using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arooj inam abbasi  ");
            string firstName = Console.ReadLine();
            firstName.Trim('a','j');
            Console.WriteLine(firstName);
            Console.ReadLine();

           
                
        }
    }
}
