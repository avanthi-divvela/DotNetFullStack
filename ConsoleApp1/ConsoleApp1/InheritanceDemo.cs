using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceDemo
    {
    }
    public class userData
    {
        public string name;
        public string fatherName;
        public string motherName;
        public userData()
        {
            Console.WriteLine("Base class constructor");
        }

        public void getUserInfo(string name)
        {
            this.name = name;
            Console.WriteLine("Name: " + name);
        }
    }
}
