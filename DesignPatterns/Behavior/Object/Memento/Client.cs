using DesignPatterns.Behavior.Object.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Memento
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            // Create a creator and set its state
            Creator creator = new Creator();
            creator.SetState("Initial State");
            // Create a concierge to manage mementos
            Concierge concierge = new Concierge();
            // Create a memento from the creator's state
            Memento memento1 = concierge.CreateMemento(creator);
            Console.WriteLine("Created Memento 1 with state: " + creator.GetState());
            // Change the creator's state
            creator.SetState("Changed State");
            Console.WriteLine("Changed Creator's state to: " + creator.GetState());
            // Restore the creator's state from the first memento
            concierge.RestoreMemento(creator, memento1);
            Console.WriteLine("Restored Creator's state to: " + creator.GetState());


        }
    }
}
