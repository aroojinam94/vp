using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sibling_date_of__birth
{

    class Program
    {
        static void Main(string[] args)
        {
            getbday();

        }
        public static void getbday()
        {
            int siblings;
            Console.Out.WriteLine("Enter siblings");
            siblings = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= siblings; i++)
            {
                Console.Out.WriteLine("Enter birth day of sibling" + i);
                DateTime date = DateTime.Parse(Console.ReadLine());
                TimeSpan difference = DateTime.Now.Date - date;
                double totalDays = difference.TotalDays;
                int year = (int)totalDays / 365;
                int months = (int)totalDays % 365;
                months = months / 30;
                int monthsMod = months;
                int days = months % 30;
                Console.Out.WriteLine("Time span days : " + totalDays);
                Console.Out.WriteLine("Year : " + year);
                Console.Out.WriteLine("months : " + months);
                Console.Out.WriteLine("Days: " + days);

            }

            Console.ReadLine();
        }
    }

}

   
