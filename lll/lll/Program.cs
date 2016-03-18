

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpAssignmentkashif
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
            ////string sentence   = "This sentence has five words.";
            //// Extract the second word.
            ////int start = sentence.IndexOf(" ") + 1;
            ////string word2 = sentence.Substring(start,sentence.IndexOf(" ", start) - start);
            ////Console.WriteLine("Second word: " + word2);
            ////Console.ReadLine();
            //DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            //double temperature = 68.3;
            //string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
            //                              dateAndTime, temperature);
            //Console.WriteLine(result);
            //Console.ReadLine();


        }
    }
}
