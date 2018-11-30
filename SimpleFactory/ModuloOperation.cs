namespace SimpleFactory
{
    public class ModuloOperation : Operation
    {
        public override double GetResult(double lhsNum, double rhsNum)
        {
            if (rhsNum == 0) {
                throw new System.Exception("参数不能为0");
            }
            return lhsNum % rhsNum;
        }
    }
}