namespace SimpleFactory
{
    public class DivOperation : Operation
    {
        public override double GetResult(double lhsNum, double rhsNum)
        {
            if (rhsNum == 0) {
                throw new System.Exception("除数不能为零");
            }
            return lhsNum / rhsNum;
        }
    }
}