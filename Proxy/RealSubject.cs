namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            System.Console.WriteLine("Real Request...");
        }
    }
}