using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.Pagination
{
    [Serializable]
    public abstract class BasePagedList<T>:PagedListMetaData,IPagedList<T>
    {
        //The subset of items xyz
        protected readonly List<T> Subset = new List<T>();

        protected BasePagedList()
        {

        }
        protected BasePagedList(int pageNumber, int pageSize, int totalItemCount)
        {
            // set source to blank list if superset is null to prevent exceptions
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            PageNumber = pageNumber;
            PageCount = TotalItemCount > 0
                ? (int)Math.Ceiling(TotalItemCount / (double)PageSize)
                : 0;
            HasPreviousPage = PageNumber > 1;
            HasNextPage = PageNumber < PageCount;
        }

        public abstract IEnumerable<T> Items { get; }

        public IEnumerator<T> GetEnumerator()
        {
            return Subset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Gets the element at the specified index.
        public T this[int index] => Subset[index];

        // Gets the number of elements contained on this page.
        public int Count => Subset.Count;

        //>A non-enumerable copy of this paged list.
        public IPagedList GetMetaData()
        {
            return new PagedListMetaData(this);
        }
    }
}
