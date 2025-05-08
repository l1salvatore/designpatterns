using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.ChainOfResponsability
{
    public interface IHandler
    {
        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="handler">The next handler.</param>
        void SetNext(IHandler handler);
        /// <summary>
        /// Handles the request.
        /// </summary>
        /// <param name="request">The request.</param>
        void Handle(string request);
    }
}
