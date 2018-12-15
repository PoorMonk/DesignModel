namespace Publish
{
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _name = name;
            Subject = subject;
        }

        public ConcreteSubject Subject { get => _subject; set => _subject = value; }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            System.Console.WriteLine("观察者{0}的新状态是{1}", _name, _observerState);
        }
    }
}