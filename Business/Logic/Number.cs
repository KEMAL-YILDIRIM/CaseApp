using System.Collections.Generic;
using System.Linq;

using Business.Exceptions;

namespace Business.Logic
{
    /// <summary>
    /// The number class
    /// </summary>
    public class Number : Count<int>
    {
        /// <summary>
        /// Calculate the number of repetations of a int within a int array.
        /// </summary>
        /// <typeparam name="TypeItem"></typeparam>
        /// <param name="items">Int32</param>
        /// <param name="item">Int32</param>
        /// <returns></returns>
        public override int FindNumberOfRepetations(in IEnumerable<int> items, in int item)
        {
            if (items.Count() == 0)
                throw new CountException("Given numbers are not valid.");

            return base.FindNumberOfRepetations(items, item);
        }
    }
}
