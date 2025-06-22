using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Observer
{
    public class ConcreteObserver1 : IObserver
    {
        private string _data;
        private ConcreteSubject _subject;
        public ConcreteObserver1(ConcreteSubject subject)
        {
            _subject = subject;
            _data = subject.Data;
        }

        public void Update()
        {
            _data = _subject.Data;
            Console.WriteLine($"Observer 1 notified and updated with new data: {_data}");
        }
    }
}
