namespace FactoryMethod
{
    public class CreatorObject : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductObject();
        }
    }
}