using System;

/*
 Prototype pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to 
 used to create a duplicate object or clone of the current object. It provides an interface for creating parts 
 of a product.

What is Prototype Pattern?
Prototype pattern is used to create a duplicate object or clone of the current object to enhance performance.
This pattern is used when creation of object is costly or complex.

For Example: An object is to be created after a costly database operation. We can cache the object, returns its 
clone on next request and update the database as and when needed thus reducing database calls.
*/
namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myObj = new PrototypeImplementation();

            var myObj2 = myObj.Clone();

            var myObj3 = myObj.Clone();

            Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj2.Name);
            Console.WriteLine(myObj3.Name);
        }
    }
}