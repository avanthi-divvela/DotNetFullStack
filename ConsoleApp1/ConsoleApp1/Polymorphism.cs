using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polymorphism
    {
        //**********Compile Time Polymorphism***************
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a+b = {0}", a + b);
        }
        public void AddNumbers(int a, int b,int c)
        {
            Console.WriteLine("a+b+c = {0}", a + b+c);
        }
        public void AddNumbers(double a, double b)
        {
            Console.WriteLine("a+b = {0}", a + b);
        }

        //**********Run Time Polymorphism***************
        public class AClass
        {
            public virtual void GetInfo()
            {
                Console.WriteLine("This message is from virtual class");
            }
        }

        public class BClass:AClass
        {
            public override void GetInfo()
            {
                Console.WriteLine("This message is from Overriding class");
            }
        }
    }
}
