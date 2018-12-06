namespace FactoryMethod
{
    public class ModuloFactory : Factory
    {
        public override Operation CreateOperation()
        {
            return new ModuloOperation();
        }
    }
}