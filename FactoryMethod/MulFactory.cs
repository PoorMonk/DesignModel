namespace FactoryMethod
{
    public class MulFactory : Factory
    {
        public override Operation CreateOperation()
        {
            return new MulOperation();
        }
    }
}