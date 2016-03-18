using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_vp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" plese enter number of siblings  :");
            int number_siblings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(".........................................................");
            if (number_siblings == 3)
            {
                
                DateTime DT = DateTime.Today;
                DateTime UserBirthDate;
                Console.WriteLine(" please enter date of birth for first sibling : dd/mm/yyyy");
                UserBirthDate = DateTime.Parse(Console.ReadLine());
            }
            if (number_siblings == 2)
            {
                DateTime DT = DateTime.Today;
                DateTime UserBirthDate1;
                Console.WriteLine(" please enter date of birth for second sibling : dd/mm/yyyy");
                UserBirthDate1 = DateTime.Parse(Console.ReadLine());
            }

            if (number_siblings == 3)
            {
                DateTime DT = DateTime.Today;
                DateTime UserBirthDate2;
                Console.WriteLine(" please enter date of birth for third  sibling : dd/mm/yyyy");
                UserBirthDate2 = DateTime.Parse(Console.ReadLine());
            }





        }
    }
}
