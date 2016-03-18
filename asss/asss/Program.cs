using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asss
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                Console.WriteLine(" enter number of siblings : ");
                int number_of_siblings = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("...........................................");
                int  sibling1, sibling2, sibling3;
                DateTime birthday;
                Console.WriteLine("  enter date of birth of frst sibling   (dd/mm/yyyy): ");
                 sibling1=Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine(" enter  date of birth of second  sibling   (dd/mm/yyyy): ");
                 sibling2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter date of birth of third  sibling   (dd/mm/yyyy): ");
                sibling3=Convert.ToInt32(Console.ReadLine());
                DateTime datetime  = DateTime.Today;
                
                 int sib1 = datetime.Year - birthday.Year;

                DateTime dt = DateTime.Today;
                //        int userage = d.Year - user_birthday.Year;
                //        Console.WriteLine(" you are {0} years old ", userage);
                //        Console.ReadLine();




                //if (number_of_siblings == 3)
                //{
                //    Console.WriteLine("  display  date of birth of siblings  (dd/mm/yyyy): ");
                //    Console.ReadLine();
                // if (number_of_siblings == 1)
                //    {
                //        DateTime user_birthday;
                //        Console.WriteLine("  please enter date of birth of frst sibling (dd/mm/yyyy): ");
                //        user_birthday = DateTime.Parse(Console.ReadLine());
                //        Console.WriteLine("  please enter date of birth of second sibling (dd/mm/yyyy): ");
                //        user_birthday = DateTime.Parse(Console.ReadLine());
                //        Console.WriteLine("  please enter date of birth of third  sibling (dd/mm/yyyy): ");
                //        user_birthday = DateTime.Parse(Console.ReadLine());


                //        DateTime dt = DateTime.Today;
                //        int userage = dt.Year - user_birthday.Year;
                //        Console.WriteLine(" you are {0} years old ", userage);
                //        Console.ReadLine();
                //    }
                //}
                ////DateTime user_birthday1;
                ////if (number_of_siblings == 2)
                ////{
                ////    Console.WriteLine("  please enter date of birth of second  sibling (dd/mm/yyyy): ");
                ////    user_birthday1 = DateTime.Parse(Console.ReadLine());
                ////}
                ////DateTime user_birthday22;
                ////if (number_of_siblings == 3)
                ////{
                ////    Console.WriteLine("  please enter date of birth of third  sibling (dd/mm/yyyy): ");
                ////    user_birthday22 = DateTime.Parse(Console.ReadLine());
                ////}


            }
        }
    }
}
