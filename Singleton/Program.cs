using System;

/*
Singleton pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is a pattern 
is one of the simplest design patterns. This pattern ensures that a class has only one instance.

What is Singleton Pattern?
Singleton Design pattern is one of the simplest design patterns. This pattern ensures that a class has only one 
instance and provides a global point of access to it.
*/
namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myObj = SingletonObject.GetInstance();
            myObj.Name = "My Singleton Object";

            var myObj2 = SingletonObject.GetInstance();

            var myObj3 = SingletonObject.GetInstance();

            Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj2.Name);
            Console.WriteLine(myObj3.Name);
        }
    }
}