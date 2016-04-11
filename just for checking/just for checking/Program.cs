using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_for_checking
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "ABCD";
            String str2 = "abcd";
            String str;
            int result;

            Console.WriteLine();
            Console.WriteLine("Compare the numeric values of the corresponding Char objects in each string.");
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = String.CompareOrdinal(str1, str2);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("String '{0}' is ", str1);
            Console.Write("{0} ", str);
            Console.WriteLine("String '{0}'.", str2);

            Console.ReadLine();
        }
    }
}
