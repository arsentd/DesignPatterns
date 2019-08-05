namespace Prototype
{
    public class PrototypeImplementation : PrototypeObject
    {
        public override PrototypeObject Clone()
        {
            return (PrototypeObject)MemberwiseClone();
        }
    }
}