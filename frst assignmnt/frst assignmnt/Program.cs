using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frst_assignmnt
{
    class Program
    {
        static void Main(string[] args)
        {
             int number_of_siblings;
            Console.WriteLine(" enter number of siblings ");
            number_of_siblings =  Convert.ToInt32(Console.ReadLine());
            DateTime todaydate = DateTime.Today;

            do
            {
               int x=0;
                Console.WriteLine(  "enter Date of birth  for each sibling " );
                x=x+number_of_siblings;
                 Console.WriteLine(  "enter Date of birth  for each sibling "+x);
              Console.ReadLine()  ;    

        }
    }
}
