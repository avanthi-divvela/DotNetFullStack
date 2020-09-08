using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User      
    {
        //public int MyPropery { get;}

        readonly string name = "test";
        public User()
        {
            name = "Avanthi";
        }

        public string getUserName()
        {           
            return name;
        }
    }
}
