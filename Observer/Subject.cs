using System.Collections.Generic;

namespace Publish
{
    public abstract class Subject
    {
        private IList<Observer> _observers = new List<Observer>();

        public void Attach(Observer obs)
        {
            _observers.Add(obs);
        }

        public void Detach(Observer obs)
        {
            _observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (Observer ob in _observers)
            {
                ob.Update();
            }
        }
    }
}