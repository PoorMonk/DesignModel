namespace Publish
{
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState { get => _subjectState; set => _subjectState = value; }
    }
}