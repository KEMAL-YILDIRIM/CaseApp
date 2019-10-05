using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICount
    {
        int FindNumberOfRepetations<TypeItem>(IEnumerable<TypeItem> items, TypeItem item)
            where TypeItem : struct;
    }
}