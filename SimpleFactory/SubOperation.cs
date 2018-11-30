namespace SimpleFactory
{
    public class SubOperation : Operation
    {
        public override double GetResult(double lhsNum, double rhsNum)
        {
            return lhsNum - rhsNum;
        }
    }
}