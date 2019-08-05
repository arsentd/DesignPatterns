namespace Prototype
{
    public class PrototypeObject : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}