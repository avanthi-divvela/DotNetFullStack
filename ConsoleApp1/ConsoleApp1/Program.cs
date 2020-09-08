using System;
using System.Collections.Generic;
using System.Reflection;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using static ConsoleApp1.MultiLevelInheritance;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Datatypes
            //string firstName = "Avanthi";
            //int age = 34;
            //float exactAge = 34.2f;
            //char charValue = 'c';
            //bool isActive = true;

            ////conditional statements
            //if(age >35)
            //{
            //    Console.WriteLine(firstName + "'s age is greaterthan 35yrs");
            //}
            //else if(age == 34)
            //{
            //    Console.WriteLine(firstName + "'s age is 30");
            //}
            //else
            //{
            //    Console.WriteLine(firstName + "'s age is lessthan 35yrs");
            //}


            //**************Exception Handling ******************
            //try
            //{
            //    int i = 0;
            //    int j = 10;
            //    Console.WriteLine(j / i);              
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //}
            //Console.ReadLine();

            //*************Access Modifiers*****************

            //AccessModifiers obj_AccessModifiers = new AccessModifiers();
            //obj_AccessModifiers.GetEmpName();

            //*************Encapsulation Demo*****************
            //EncapsulationDemo ObjEncapsulation = new EncapsulationDemo();
            //ObjEncapsulation.setX(10);
            //Console.WriteLine(ObjEncapsulation.getX());
            //Console.Read();

            //*************Constructor*****************
            User ObjUser = new User();
            Console.WriteLine(ObjUser.getUserName());
            Console.Read();

            //************Inheritance Demo****************
            //UserDetails objUserDetails = new UserDetails();
            //objUserDetails.getUserInfo("Avanthi");

            //objUserDetails.name = "Varshith";
            //Console.WriteLine(objUserDetails.name);

            //objUserDetails.age = 34;
            //objUserDetails.getAge();
            //Console.ReadKey();

            //************Multi-level Inheritance Demo****************

            //Inculded the MultiLevelInheritance class as a static namespace
            //So the class 'C' is directly accessible else it need to be accessed with its parent class "MultiLevelInheritance.C"

            //C objC = new C();
            //objC.name = "Avanthi";
            //objC.location = "Illinois";
            //objC.age = 34;
            //objC.getName();
            //objC.getLocation();
            //objC.getAge();
            //Console.ReadKey();


            //************ Compile Time Polymorphism Demo****************
            //Polymorphism objPolymorphism = new Polymorphism();
            //objPolymorphism.AddNumbers(3, 4);
            //objPolymorphism.AddNumbers(3, 6, 7);
            //objPolymorphism.AddNumbers(3.4, 7.8);
            //Console.ReadKey();

            //************ Compile Time Polymorphism Demo****************
            //Polymorphism.BClass objBClass = new Polymorphism.BClass();
            //Console.WriteLine("Function call from BClass object:");
            //objBClass.GetInfo();

            //Polymorphism.AClass objAclass = new Polymorphism.AClass();
            //Console.WriteLine("\nFunction call from AClass object:");
            //objAclass.GetInfo();
            //Console.ReadKey();


            //************Testing****************
            //test.Car objcar = new test.Maruthi();
            //objcar.run();
            //Console.ReadKey();

            //test.Programmers objProgrammers = new test.Programmers();
            //objProgrammers.PhpProgrammer();
            //objProgrammers.CSharpProgrammer();
            //Console.ReadKey();


            //************String Datatype****************
            //string name = "Avanthi";
            //Console.WriteLine($"Hello {name}");

            //string songLyrics = "You say goodbye, and I say hello";
            //Console.WriteLine(songLyrics.StartsWith("You"));
            //Console.WriteLine(songLyrics.StartsWith("goodbye"));

            //Console.WriteLine(songLyrics.EndsWith("hello"));
            //Console.WriteLine(songLyrics.EndsWith("goodbye"));

            //string greeting = "      Hello World!       ";
            //Console.WriteLine($"[{greeting}]");

            //string trimmedGreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");
            //Console.ReadKey();


            //************Double Datatype****************
            //double a = 19;
            //double b = 23;
            //double c = 8;
            //double d = (a + b) / c;
            //Console.WriteLine(d);

            //double max = double.MaxValue;
            //double min = double.MinValue;
            //Console.WriteLine($"The range of double is {min} to {max}");

            //double third = 1.0 / 3.0;
            //Console.WriteLine(third);

            ////Console.ReadKey();

            //double e = 1.0;
            //double f = 3.0;
            //Console.WriteLine("Double: {0}", e / f);

            //decimal g = 1.0M;
            //decimal h = 3.0M;
            //Console.WriteLine("Decimal:{0}", g / h);

            //int sum = 0;
            //for (int number = 1; number < 21; number++)
            //{
            //    if (number % 3 == 0)
            //    {
            //        sum = sum + number;
            //        //Console.WriteLine(number);
            //    }
            //}
            //Console.WriteLine($"The sum is {sum}");
            //Console.ReadKey();


            //************Arrays****************

            //int[] multiNumbers = new int[2];
            //multiNumbers[0] = 123;
            //multiNumbers[1] = 456;
            //for(int i=0; i<multiNumbers.Length; i++)
            //{
            //    Console.WriteLine(multiNumbers[i]);
            //}
            //Console.WriteLine("****************For loop****************");
            ////string[] multiString = new string[3] { "Avanthi", "Narendra", "Varshith" };
            //string[] multiString = new string[] { "Avanthi", "Narendra", "Varshith" };
            //Console.WriteLine(multiString.Length);
            //for (int i = 0; i < multiString.Length; i++)
            //    Console.WriteLine(multiString[i]);
            //Console.WriteLine("****************Foreach****************");
            //foreach (var item in multiString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("****************While loop****************");
            //int j = 0;
            //while (j < multiString.Length)
            //{
            //    Console.WriteLine(multiString[j]);
            //    j++;
            //}

            //Console.ReadKey();


            //************Static Class Demo****************
            //string name = StaticClassDemo.FirstName;
            //string userId = StaticClassDemo.GetUserId();

            //Console.WriteLine($"Name: {name}, User Id: {userId}");
            //Console.ReadKey();

            //************Abstract Class Demo****************
            //AbstractClassDemo.User ObjUser = new AbstractClassDemo.User();
            //ObjUser.GetUserInfo("Avanthi");
            //ObjUser.ShowMessage();

            //Console.ReadKey();

            //************Interfaces Demo****************
            //UserData objUserData = new UserData();
            //objUserData.GetDetails("Avanthi");
            //objUserData.getUserId(4);
            //objUserData.Test();

            //Console.ReadKey();

            //************List Demo****************
            //List<int> intList = new List<int>();
            //intList.Add(5);
            //intList.Add(10);
            //intList.Add(15);
            //intList.Add(20);
            //foreach(int num in intList)
            //{
            //    Console.WriteLine(num);
            //}
            //List<string> strList = new List<string>();
            //strList.Add("Avanthi");
            //strList.Add("Narendra");
            //strList.Add("Varshith");

            //Console.WriteLine(strList.Count);
            //strList.Clear();
            //Console.WriteLine(strList.Count);

            //Console.WriteLine(intList); // gives info about the list
            //Console.ReadKey();


            //************Reflection Demo****************
            //List<CustomerDetails> items = new List<CustomerDetails>();
            //items.Add(new CustomerDetails { custId = 1, custName = "Avanthi" });
            //items.Add(new CustomerDetails { custId = 2, custName = "Narendra" });
            //foreach(CustomerDetails item in items)
            //{
            //    GetPropertyInfo(item); //Call a function
            //}

            //Console.ReadKey();

        }
        //Reflection
        private static void GetPropertyInfo(CustomerDetails customer)
        {
            Type type = customer.GetType();
            Console.WriteLine($"Type: {type}");
            PropertyInfo[] props = type.GetProperties();
            foreach(var item in props)
            {
                Console.WriteLine(item.Name + " : " + item.GetValue(customer) + " : " + item.PropertyType);
            }
        }
    }
}
