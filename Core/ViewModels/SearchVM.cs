using Aduaba.Core.Util;
using Aduaba.Core.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.ViewModels
{
    public class SearchVM
    {
        [Range(1, int.MaxValue, ErrorMessage = "PageIndex must be greater than 0")]
        public int PageIndex { get; set; } = Constants.PaginationConsts.PageIndex;
        public int? PageTotal { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "PageSize must be greater than 0")]
        public int PageSize { get; set; } = 10;

        public int PageSkip => (PageIndex - 1) * PageSize;
        public List<Filter> Filters { get; set; } = new List<Filter>();

        public class Filter
        {
            //The keyword.
            [Required] 
            public string Keyword { get; set; }

            //The filter column.
            [Required] 
            public string FilterColumn { get; set; }

            //The operation.
            [Required] public FilterOperation? Operation { get; set; }
        }

    }
}
