namespace AbstractFactory
{
    public class AbstractFactoryObject : AbstractFactory
    {
        public override Product CreateProduct()
        {
            return new ProductObject();
        }
    }
}