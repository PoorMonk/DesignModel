namespace FactoryMethod
{
    public class DivFactory : Factory
    {
        public override Operation CreateOperation()
        {
            return new DivOperation();
        }
    }
}