using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_clone_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 ="Testing";
             string str2 = (string)str1.Clone();
            string str3=(string )str1.Clone();
            Console.WriteLine(str1);
            Console. WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
