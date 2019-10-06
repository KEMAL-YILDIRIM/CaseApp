using System;
using System.Collections.Generic;

using Business.Exceptions;

namespace Business.Logic
{
    /// <summary>
    /// The number class
    /// </summary>
    public class Number : Count
    {
        /// <summary>
        /// Calculate the number of repetations of a int within a int array.
        /// </summary>
        /// <typeparam name="TypeItem"></typeparam>
        /// <param name="items">Int32</param>
        /// <param name="item">Int32</param>
        /// <returns></returns>
        public override int FindNumberOfRepetations<TypeItem>(in IEnumerable<TypeItem> items, in TypeItem item)
        {
            if (item.GetType().Name != "Int32")
                throw new CountExceptions("Given item is not a number.");

            var givenNumbers = items as Int32[];

            if (givenNumbers.Length == 0)
                throw new CountExceptions("Given numbers are not valid.");

            return base.FindNumberOfRepetations(items, item);
        }
    }
}
