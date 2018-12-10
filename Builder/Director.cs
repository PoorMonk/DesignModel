namespace Builder
{
    public class Director
    {
        /// <summary>
        /// 指挥建造过程
        /// </summary>
        /// <param name="builder">具体建造类</param>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}