namespace FactoryMethod
{
    public class AddFactory : Factory
    {
        public override Operation CreateOperation()
        {
            return new AddOperation();
        }
    }
}