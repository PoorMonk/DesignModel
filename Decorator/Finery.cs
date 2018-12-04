namespace Decorator
{
    public class Finery : Person
    {
        private Person _person;
        public void Decorate(Person person)
        {
            _person = person;
        }

        public override void Show()
        {
            if (_person != null)
            {
                _person.Show();
            }
        }
    }
}