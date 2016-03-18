using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignmnt
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number_of_siblings ;
            Console.WriteLine(" please enter the number of siblings ");
            number_of_siblings = Convert.ToInt32(Console.ReadLine());
            DateTime siblings;
            for (int i = 0; i <= number_of_siblings; i++)
            {
                Console.WriteLine("please enter date of birth of siblings, number_of_siblings[i]");
                siblings = DateTime.Parse(Console.ReadLine());
            }

            //Console.WriteLine( "please enter date of birth of first   sibling" );
            //sibling1 = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("  please enter date of birth of second  sibling ");
            //sibling2 = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("  please enter date of birth of third  sibling ");
            //sibling3 = DateTime.Parse(Console.ReadLine());

        }
    }
}
