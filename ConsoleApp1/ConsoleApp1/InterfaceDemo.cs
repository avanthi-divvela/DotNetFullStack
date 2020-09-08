using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface InterfaceDemo
    {
        void GetDetails(string uId);
        void Test();
    }
    interface IUser
    {
        void getUserId(int uId);
    }
    public class UserData : InterfaceDemo , IUser
    {
        //Need to implement all the methods of inherited interface
        public void GetDetails(string uId)
        {
            Console.WriteLine($"From InterfaceDemo interface with the string: {uId}---- GetDetails class");
        }
        public void Test()
        {
            Console.WriteLine("From InterfaceDemo interface --- Test class");
        }
        public void getUserId(int uId)
        {
            Console.WriteLine($"From IUser interface with integer: {uId}");
        }
    }
}
