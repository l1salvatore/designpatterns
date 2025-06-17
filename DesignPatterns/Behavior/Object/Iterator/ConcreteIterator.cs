using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Iterator
{
    class ConcreteIterator : IIterator<int>
    {
        int[] items_;
        int currentIndex = 0;
        public ConcreteIterator(int[] items) {
            items_ = items;
        }

        /// <summary>
        /// Resets the iterator to the first item.
        /// </summary>
        public int First()
        {
            currentIndex = 0;
            return items_[currentIndex];
        }

        /// <summary>
        /// Moves to the next item in the collection.
        /// </summary>
        /// <returns></returns>
        public int Next()
        {
            currentIndex++;
            if (currentIndex < items_.Length)
            {
                return items_[currentIndex];
            }
            else
            {
                throw new InvalidOperationException("No more items in the collection.");
            }
        }

        /// <summary>
        /// Returns true if the iterator has reached the end of the collection.
        /// </summary>  
        public bool ReachEnd()
        {
            return currentIndex >= items_.Length;
        }

        /// <summary>
        /// Returns the current item in the collection.
        /// </summary>
        public int CurrentItem()
        {
            return items_[currentIndex];

        }

    }
}
