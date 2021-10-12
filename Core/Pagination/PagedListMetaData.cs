using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.Pagination
{
    [Serializable]
    public class PagedListMetaData : IPagedList
    {
        protected PagedListMetaData()
        {

        }

        public PagedListMetaData(IPagedList pagedList)
        {
            PageCount = pagedList.PageCount;
            TotalItemCount = pagedList.TotalItemCount;
            PageNumber = pagedList.PageNumber;
            PageSize = pagedList.PageSize;
        }

        //Total number of subsets within the superset.
        public int PageCount { get; protected set; }

        //Total number of objects contained within the superset.
        public int TotalItemCount { get; protected set; }

        //one-based index of this subset within the superset.
        public int PageNumber { get; protected set; }

        //Maximum size any individual subset.
        public int PageSize { get; protected set; }

        //Returns true if this is NOT the first subset within the superset.
        public bool HasPreviousPage { get; protected set; }

        //<value>Returns true if this is NOT the last subset within the superset.
        public bool HasNextPage { get; protected set; }
    }
}
