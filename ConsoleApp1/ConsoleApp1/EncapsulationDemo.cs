using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EncapsulationDemo
    {
        int x;
        public void setX(int x)
        {
            if (x > 0)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Please pass a positive value");
            }
        }
        public int getX()
        {
            return x;
        }
    }
}
