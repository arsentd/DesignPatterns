namespace FactoryMethod
{
    public class CreatorImplementation : CreatorObject
    {
        public override ProductObject FactoryMethod()
        {
            return new ProductImplementation();
        }
    }
}