using System.Collections.Generic;

namespace Business.Interfaces
{
    /// <summary>
    /// The ICount interface.
    /// </summary>
    public interface ICount
    {
        /// <summary>
        /// Calculate the number of repetations of a type within an array of that type.
        /// </summary>
        /// <typeparam name="TypeItem"></typeparam>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        int FindNumberOfRepetations<TypeItem>(in IEnumerable<TypeItem> items, in TypeItem item)
            where TypeItem : struct;
    }
}