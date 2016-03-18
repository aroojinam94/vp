using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Arooj";
            string str2 = "Abbasi";
            int str3;
            str3 = String.Compare(str1, str2);
            Console.WriteLine(str3);
            Console.ReadLine();
            string str5 = "arooj";
            string str6= "inam";
            int str7;
            str7 = String.Compare(str5, str6);
            Console.WriteLine(str7);
            Console.ReadLine();

        }
       
    }
}
