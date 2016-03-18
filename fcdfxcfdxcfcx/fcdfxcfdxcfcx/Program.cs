using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fcdfxcfdxcfcx
{
    class A
    {
        public int a;
        public int b;
        public  int choice;
        public int result;
         public void get_data()
        {
            Console.WriteLine(" enter first number ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter your choice",choice);
            Console.ReadLine();
            Console.WriteLine(" enter your second number");
            b = Convert.ToInt32(Console.ReadLine());
        }
         void show_data()
          {
              result = Convert.ToInt32(Console.ReadLine());

         
         
         }
    
    
       
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            choice = Convert.ToInt32( Console.ReadLine());
   
  
            if (choice == 1)
            { 
                Console.WriteLine("+");
            }
            if (choice ==2)
            {
                Console.WriteLine("-");
            }
            if (choice == 3)
            {
                Console.WriteLine("*");
            }
            if (choice == 4)
            {
                Console.WriteLine("/");
            }

            A obj1 = new A();
            obj1.get_data();
            

          

        }
    }
}
