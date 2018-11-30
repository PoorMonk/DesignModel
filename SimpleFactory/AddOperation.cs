namespace SimpleFactory
{
    public class AddOperation : Operation
    {
        public override double GetResult(double lhsNum, double rhsNum)
        {
            return lhsNum + rhsNum;
        }
    }
}