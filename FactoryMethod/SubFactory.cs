namespace FactoryMethod
{
    public class SubFactory : Factory
    {
        public override Operation CreateOperation()
        {
            return new SubOperation();
        }
    }
}