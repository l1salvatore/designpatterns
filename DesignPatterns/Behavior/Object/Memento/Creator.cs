using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Memento
{
    public class Creator
    {
        private string _state;
        // Method to set the state
        public void SetState(string state)
        {
            _state = state;
        }
        // Method to create a memento with the current state
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }
        // Method to restore the state from a memento
        public void RestoreMemento(Memento memento)
        {
            _state = memento.GetState();
        }
        // Method to get the current state
        public string GetState()
        {
            return _state;
        }
    }
}
