using System;
using System.Collections.Generic;

using Business.Exceptions;

namespace Business.Logic
{
    public class Number : Count
    {
        public override int FindNumberOfRepetations<TypeItem>(IEnumerable<TypeItem> items, TypeItem item)
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
