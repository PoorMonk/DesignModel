namespace SimpleFactory
{
    public class MulOperation : Operation
    {
        public override double GetResult(double lhsNum, double rhsNum)
        {
            return lhsNum * rhsNum;
        }
    }
}