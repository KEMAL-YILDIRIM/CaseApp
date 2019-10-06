using System.Collections.Generic;
using System.Linq;

using Business.Exceptions;
using Business.Interfaces;

namespace Business.Logic
{
    /// <summary>
    /// Base class for count behaviour.
    /// </summary>
    public abstract class Count<TypeItem> : ICount<TypeItem> where TypeItem : struct
    {
        /// <summary>
        /// Calculate the number of repetations of a type within an array of that type.
        /// </summary>
        /// <typeparam name="TypeItem"></typeparam>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual int FindNumberOfRepetations(in IEnumerable<TypeItem> items, in TypeItem item)
        {
            int repetation = 0;

            if (items == null && !items.Any())
                throw new CountExceptions("Given list of items is not valid to find the containing item.");

            int length = items.Count();
            for (int i = length - 1; i >= 0; i--)
            {
                if (EqualityComparer<TypeItem>.Default.Equals(item, items.ElementAt(i)))
                    repetation++;
            }

            return repetation;
        }
    }
}
