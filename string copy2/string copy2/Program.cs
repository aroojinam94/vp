using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_copy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="Arooj";
             Char[]arr=new char[5];
                str.CopyTo(3,arr,0,3);
                Console.WriteLine(arr);
                string  str1 = "another testing";
                Console.WriteLine("str1");
                Console.ReadLine();
        }
    }
}
