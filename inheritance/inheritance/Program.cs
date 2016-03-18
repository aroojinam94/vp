using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
  
{
    public class parent
    {
        int a;
        int b;
        public  parent(int x, int y)
        {
           this. a = x;
             this.b = y;
        }
        public int add(int a, int b)
        {
          return (a+b);
        }
        public class child1 : parent
        {
           public int mult(int a, int b)
            {
                return (a * b);
           
           }
        }
        public class child2 : parent
        {
            public int minus(int a, int b)
            {
                return (a - b);

            }
        }
        public class child3 : parent
        {
            public int divide(int a, int b)
            {
                return (a / b);

            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            parent m = new parent(12,13);
            m.add(12,1);
               


        }
    }
   
}
