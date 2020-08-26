using System;
//using System.Collections.Generic;
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
            //User ObjUser = new User();
            //Console.WriteLine(ObjUser.getUserName());
            //Console.Read();

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
            Polymorphism.BClass objBClass = new Polymorphism.BClass();
            Console.WriteLine("Function call from BClass object:");
            objBClass.GetInfo();

            Polymorphism.AClass objAclass = new Polymorphism.AClass();
            Console.WriteLine("\nFunction call from AClass object:");
            objAclass.GetInfo();
            Console.ReadKey();
        }
    }
}
