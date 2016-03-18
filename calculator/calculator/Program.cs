using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int choice;
            Console.WriteLine(" enter number1 ");
            Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(" enter number2 ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" press 1 for addition ");
            Console.WriteLine(" press 2 for subtraction ");
            Console.WriteLine(" press 3 for multiply ");
            Console.WriteLine(" press 4 for multiply ");

            if (choice == 1)
            {
                Console.WriteLine(Program.sum(num1,num2));
            };
            if (choice == 2)
            {
               Console.WriteLine(Program.sub(num1,num2));
            };
            if (choice == 3)
            {
                Console.WriteLine(Program.multiply(num1,num2));
            if (choice == 4)
            {
                Console.WriteLine(Program.divide(num1,num2));
            };
        }

          public static int sum (int a, int b )
          {
          return a+b;
          }
        public static int sub (int a, int b )
          {
          return a-b;
          }
        public static int multiply  (int a, int b )
          {
          return a*b;
          }
        public static int divide(int a, int b )
          {
          return a/b;
          }



        }
        
    }
}

