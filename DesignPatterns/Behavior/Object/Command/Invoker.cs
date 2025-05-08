using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Command
{
    public class Invoker
    {
        private List<IOrder> _orders = new List<IOrder>();
        public Invoker() { }
        public void AddOrder(IOrder order)
        {
            _orders.Add(order);

            // Execute the order
            order.Execute();
        }

        public void UndoOrder(IOrder order)
        {
            // Remove the order from the list
            _orders.Remove(order);
        }
    }
}
