using System;
using System.Collections.Generic;
using System.Linq;

using Business.Interfaces;

namespace Business.Logic
{
    public abstract class Count : ICount
    {
        public virtual int FindNumberOfRepetations<TypeItem>(IEnumerable<TypeItem> items, TypeItem item) where TypeItem : struct
        {
            int repetation = 0;

            if (items == null && !items.Any())
                throw new Exception("Given list of items is not valid to find the containing item.");

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
