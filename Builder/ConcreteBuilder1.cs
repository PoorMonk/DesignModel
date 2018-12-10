namespace Builder
{
    public class ConcreteBuilder1 : Builder
    {
        Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("部件A");
        }

        public override void BuildPartB()
        {
            _product.Add("部件B");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}