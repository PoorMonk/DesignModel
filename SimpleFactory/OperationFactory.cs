namespace SimpleFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string strOp)
        {
            Operation op;
            switch (strOp)
            {
                case "+":
                    op = new AddOperation();
                    break;
                case "-":
                    op = new SubOperation();
                    break;
                case "*":
                    op = new MulOperation();
                    break;
                case "/":
                    op = new DivOperation();
                    break;
                case "%":
                    op = new ModuloOperation();
                    break;
                default:
                    return null;
            }
            return op;
        }
    }
}