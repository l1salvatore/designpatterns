using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Observer
{
    public interface IObserver
    {
        /// <summary>
        /// Updates the observer with the latest data from the subject.
        /// </summary>
        public void Update();
    }
}
