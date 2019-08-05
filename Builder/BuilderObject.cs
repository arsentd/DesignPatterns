namespace Builder
{
    public class BuilderObject : Builder
    {
        private ProductObject _product = new ProductObject();

        public override void Build()
        {
            _product.Add();
        }

        public override ProductObject GetResult()
        {
            return _product;
        }
    }
}
