using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Observer
{
    public class ConcreteSubject : ISubject
    {
        public ConcreteSubject() { }
        private List<IObserver> observers = new List<IObserver>();
        private string _data;
        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }
        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
