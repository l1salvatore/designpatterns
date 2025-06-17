using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Iterator
{
    interface IIterator<T>
    {
        /// <summary>
        /// Resets the iterator to the first item.
        /// </summary>
        T First();

        /// <summary>
        /// Moves to the next item in the collection.
        /// </summary>
        /// <returns></returns>
        T Next();

        /// <summary>
        /// Returns true if the iterator has reached the end of the collection.
        /// </summary>  
        bool ReachEnd();

        /// <summary>
        /// Returns the current item in the collection.
        /// </summary>
        T CurrentItem();



    }
}
