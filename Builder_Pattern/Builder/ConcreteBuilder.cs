namespace Builder_Pattern.Builder
{
    public class ConcreteBuilder : IBuilder 
    {
        private Product.Product _product = new Product.Product();

        public void BuildPartA()
        {
            _product.AddPart("Part 1");
        }

        public void BuildPartB()
        {
            _product.AddPart("Part 2");
        }

        public void BuildPartC()
        {
            _product.AddPart("Part 3");
        }



        public void Reset()
        {
            _product = new Product.Product();
        }

        public Product.Product GetProduct()
        {
            Product.Product product = _product;

            Reset();

            return product;
        }
    }
}
