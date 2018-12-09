namespace Facade
{
    public class Facade
    {
        SubSystemOne _ssOne;
        SubSystemTwo _ssTwo;
        SubSystemThree _ssThree;
        SubSystemFour _ssFour;
        public Facade()
        {
            _ssOne = new SubSystemOne();
            _ssTwo = new SubSystemTwo();
            _ssThree = new SubSystemThree();
            _ssFour = new SubSystemFour();
        }

        public void MethodA()
        {
            System.Console.WriteLine("MethodA:");
            _ssOne.MethodOne();
            _ssThree.MethodThree();
        }

        public void MethodB()
        {
            System.Console.WriteLine("MethodB:");
            _ssTwo.MethodTwo();
            _ssFour.MethodFour();
        }
    }
}