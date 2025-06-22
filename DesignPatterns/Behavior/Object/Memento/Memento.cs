using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Memento
{
    public class Memento
    {
        // The state of the object to be saved
        private string State;
        // Constructor to initialize the state
        public Memento(string state)
        {
            State = state;
        }
        // Method to retrieve the state
        public string GetState()
        {
            return State;
        }
    }
}
