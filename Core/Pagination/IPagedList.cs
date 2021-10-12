using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.Pagination
{
    public interface IPagedList<out T>:IPagedList,IEnumerable<T>
    {
        // Gets the element at the specified index.
        T this[int index] { get; }

        // Gets the number of elements contained on this page.
        int Count { get; }

        //Gets the items.
        IEnumerable<T> Items { get; }

        //Gets a nin-enumerable copy of this paged list.
        IPagedList GetMetaData();
    }

    public interface IPagedList
    {
        //Total number of subsets within the superset.
        int PageCount { get; }

        //Total number of objects contained within the superset.
        int TotalItemCount { get; }

        //one-based index of this subset within the superset.
        int PageNumber { get; }

        //Maximum size of any individual subset.
        int PageSize { get; }

        //Returns true if this is not the first subset within the superset.
        bool HasPreviousPage { get; }

        //Returns true if this is not the last subset within the superset.
        bool HasNextPage { get; }
    }
}
