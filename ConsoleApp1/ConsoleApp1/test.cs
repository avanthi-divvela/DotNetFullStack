using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class test
    {
        public class Car
        {
            int speed = 1000;
            public  void run()
            {
                Console.WriteLine("From car class, speed:{0}", speed);
            }
        }
        public class Maruthi : Car
        {
            int speed = 2000;
            public  void run()
            {
                Console.WriteLine("From Maruthi class, speed:{0}", speed);
            }
        }

        public class Php
        {
            public void PhpProgrammer()
            {
                Console.WriteLine("Php Programmers");
            }
        }
        public class CSharp
        {
            public void CSharpProgrammer()
            {
                Console.WriteLine("C# Programmers");
            }
        }
        public class Programmers : Php
        {

        }
    }
}
