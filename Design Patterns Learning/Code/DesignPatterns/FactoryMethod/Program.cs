using System;

/*
The factory method design pattern abstract the process of object creation and allows the object to be created 
at run-time when it is required. Factory method pattern falls under Creational Pattern of Gang of Four (GOF) 
Design Patterns in .Net. It is used to create objects. People usually use this pattern as the standard way to 
create objects.

What is Factory Method Pattern?
In Factory pattern, we create the object without exposing the creation logic. In this pattern, an interface is 
used for creating an object, but let subclass decide which class to instantiate. The creation of object is done 
when it is required. The Factory method allows a class later instantiation to subclasses.

In short, factory method design pattern abstract the process of object creation and allows the object to be 
created at run-time when it is required.
*/
namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            var creators = new CreatorObject[1];
            creators[0] = new CreatorImplementation();

            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("Created " + product.GetType().Name);
            }
        }
    }
}