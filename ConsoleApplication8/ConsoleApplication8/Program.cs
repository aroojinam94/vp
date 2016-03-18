using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication8

{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            
        {
            int  no_of_sibs=0 ;
            Console.WriteLine(" Enter Number Of Siblings ");
            no_of_sibs  = Convert.ToInt32(Console.ReadLine());
           ArrayList list =new ArrayList();
            for (int i = 0; i <= no_of_sibs ; i++)
            {
                Console.WriteLine(" Enter Date Of  birth of sibling:{0} ",i+1);
                 list .Add( Console.ReadLine());
            }
            for (int i = 0; i < list.Count; i++)
            {
                int years = 0;
                int months = 0;
                int days = 0;
                int bal;
                DateTime datetime = Convert.ToDateTime(list[i]);
                TimeSpan  difference_of_age  = DateTime.Now.Subtract(datetime);
                Console.WriteLine("difference {0} ", difference_of_age.Days);
                Console.ReadLine();


                years = difference_of_age.Days / 365;
                bal = difference_of_age.Days - (years * 365);
                months = bal / 30;
                bal = bal - (months * 30);
                days = bal;
                Console.WriteLine("Age of sibling {0} is: {1} years {2} months {3} days. ", i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));


            }
              for (int i = 0; i < list.Count; i++)
                {
                    int years = 0, months = 0, days = 0, bal = 0;
                    DateTime dob = Convert.ToDateTime(list[i]);
                    TimeSpan diff;
                    if (i > 0)
                    {
                        DateTime pdob = Convert.ToDateTime(list[i - 1]);
                        diff = pdob.Subtract(dob);
                        years = diff.Days / 365;
                        bal = diff.Days - (years * 365);
                        months = bal / 30;
                        bal = bal - (months * 30);
                        days = bal;
                        Console.WriteLine("Difference between sibling {0} and {1} is {2} years {3} months {4} days. ", i, i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));
                    }
                }

                Console.ReadKey();
            }
          catch (FormatException e)
            {
                Console.WriteLine("Enter date in mentioned format", e);

            }

               

            


        }
    }
}

}
