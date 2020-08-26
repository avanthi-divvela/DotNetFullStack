using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserDetails:userData
    {
        public int age;
        public UserDetails()
        {
            Console.WriteLine("Child class constructor");
        }
        public void getAge()
        {
            
            Console.WriteLine("Age: " + age);
        }
    }
}
