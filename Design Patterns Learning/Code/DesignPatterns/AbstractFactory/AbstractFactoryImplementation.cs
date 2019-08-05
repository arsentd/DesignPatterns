namespace AbstractFactory
{
    public class AbstractFactoryImplementation : AbstractFactory
    {
        public override AbstractProduct CreateProduct()
        {
            return new Product();
        }
    }
}