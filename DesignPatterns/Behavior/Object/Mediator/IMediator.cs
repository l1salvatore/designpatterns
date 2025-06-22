using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{
    public interface IMediator
    {
        /// <summary>
        /// Registers a colleague with the mediator.
        /// </summary>
        /// <param name="colleague">The colleague to register.</param>
        void Register(Colleague colleague);
        /// <summary>
        /// Sends a message from one colleague to another.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The colleague sending the message.</param>
        void Send(string message, Colleague sender);
    }
}
