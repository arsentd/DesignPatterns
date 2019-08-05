namespace AbstractFactory
{
    public class Client
    {
        private AbstractProduct _abstractProduct;

        public Client(AbstractFactory factory)
        {
            _abstractProduct = factory.CreateProduct();
        }

        public void Run()
        {
            //_abstractProduct.Interact(_abstractProduct);
        }
    }
}