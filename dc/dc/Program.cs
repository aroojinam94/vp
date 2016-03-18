using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dc
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine(" enter number of siblings : ");
            x=Convert.ToInt32(Console.Read());
            DateTime[] dos  = new DateTime[x];
            Console.WriteLine("...........................................");
            DateTime today = DateTime.Today;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter Date Of " + (i + 1) + " Sibling");
                dos[i] = Convert.ToDateTime(Console.ReadLine().ToString());
            }
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine("B Day Of " + (j + 1) + " Sibling is " + dos[j].ToString());
            }

        }
    }
}
