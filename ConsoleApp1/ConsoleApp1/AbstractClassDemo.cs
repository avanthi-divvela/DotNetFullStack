using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AbstractClassDemo
    {
        public abstract class UserInfo
        {
            public int classCount = 2;

            abstract public void GetUserInfo(string userName);
            public void ShowMessage()
            {
                Console.WriteLine("Message from AbstractClassDemo -- UserInfo class -- ShowMessage method");
                Console.WriteLine($"Class Count : {classCount}");
            }
        }
        public class User : UserInfo
        {
            public override void GetUserInfo(string userName)
            {
                //throw new NotImplementedException();
                Console.WriteLine(userName);
                Console.WriteLine($"Class Count : {classCount}");
            }
        }
    }
}
