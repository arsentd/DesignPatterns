namespace Prototype
{
    public abstract class PrototypeObject
    {
        public abstract PrototypeObject Clone();

        // additional
        public string Name = "Some Name";
    }
}