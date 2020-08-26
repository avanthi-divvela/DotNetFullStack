using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiLevelInheritance
    {
        public class A
        {
            public string name;
            public void getName()
            {
                Console.WriteLine("Name:{0}", name);
            }
        }

        public class B : A
        {
            public string location;
            public void getLocation()
            {
                Console.WriteLine("Location: {0}", location);
            }
        }

        public class C : B
        {
            public int age;
            public void getAge()
            {
                Console.WriteLine("Age: {0}", age);
            }
        }
    }
}
