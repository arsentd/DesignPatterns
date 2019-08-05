/*
Abstract Factory Design method falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net.
It is used to create a set of related objects, or dependent objects. Internally, Abstract Factory use Factory
design pattern for creating objects. It may also use Builder design pattern and prototype design pattern for
creating objects. It completely depends upon your implementation for creating objects.

What is Abstract Factory Pattern?
Abstract Factory patterns act a super-factory which creates other factories. This pattern is also called a
Factory of factories. In Abstract Factory pattern an interface is responsible for creating a set of related
objects, or dependent objects without specifying their concrete classes.
*/
namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new AbstractFactoryImplementation();
            var client = new Client(factory);
            client.Run();
        }
    }
}