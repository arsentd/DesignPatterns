/*
Builder Design pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used 
to builds a complex object by using a step by step approach. It provides an interface for creating parts of a 
product.

What is Builder Pattern?
Builder pattern builds a complex object by using a step by step approach. Builder interface defines the steps 
to build the final object. This builder is independent of the objects creation process. A class that is known 
as Director, controls the object creation process.

Moreover, builder pattern describes a way to separate an object from its construction. The same construction 
method can create a different representation of the object.
*/
namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new DirectorObject();

            var builder = new BuilderObject();

            director.Construct(builder);

            var product = builder.GetResult();
            product.Show();
        }
    }
}