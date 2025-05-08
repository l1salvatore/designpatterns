using DesignPatterns.Behavior.Object.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Command
{
    public interface IOrder
    {
        /// <summary>
        /// Executes the order.
        /// </summary>
        void Execute();
    }
}
