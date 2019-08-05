using System;

namespace Builder
{
    public class ProductObject
    {
        private string _content = "no product";

        public void Add()
        {
            _content = "product was added";
        }

        public void Show()
        {
            Console.WriteLine(_content);
        }
    }
}