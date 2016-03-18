using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dxd
{
    class Program
    {
        static void Main(string[] args)
        {
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;
            int choice;

            Console.WriteLine("FIRST NUMBER");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SECOND NUMBER");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");
           

            Console.WriteLine("ENTER CHOICE NUMBER");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine(Program.sum(num1, num2));
            
            }
            else if (choice == 2)
            {
                Console.WriteLine(Program.sub(num1, num2));
            }
            else if (choice == 3)
            {
                Console.WriteLine(Program.mult(num1, num2));

                    
            }
            else if (choice == 4)
            {
                Console.WriteLine(Program.div(num1, num2));

            }
            else
            {
                Console.WriteLine("Enter Valid Choice");
            }
            Console.ReadKey();
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
        public static int mult(int a, int b)
        {
            return a * b;
        }
        public static int div(int a, int b)
        {
            return a / b;
        }


    }
}
        }
    }
}
