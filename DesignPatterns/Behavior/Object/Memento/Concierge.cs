using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Memento
{
    public class Concierge
    {
        public Concierge() { }

        private List<Memento> _mementos = new List<Memento>();


        // Method to create a memento from the creator's state
        public Memento CreateMemento(Creator creator)
        {
            Memento m = creator.CreateMemento();
            _mementos.Add(m);
            return m;
        }

        // Method to restore the creator's state from a memento
        public void RestoreMemento(Creator creator, Memento memento)
        {
            if (_mementos.Contains(memento))
            {
                creator.RestoreMemento(memento);
                // Optionally, you can remove the memento from the collection after restoring
                _mementos.Remove(memento);
            }
            else
            {
                throw new InvalidOperationException("Memento not found in the concierge's collection.");
            }
        }
    }
}
