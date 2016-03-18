using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter number ");

            int[] arr = new int[45];
            Console.WriteLine("arr[1] = 0");
            Console.WriteLine("arr[2]=13");
            Console.WriteLine("arr[3] = 2");
            Console.WriteLine("arr[4]=35");
            Console.WriteLine(" represent list of array ");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            if (usernumber == arr[45])

            {
                Console.WriteLine(" right   number ");

            }

            if (usernumber != arr[45])
            {
                Console.WriteLine(" wrong number ");
            }


            Console.ReadLine();

        }

    }
    
}
