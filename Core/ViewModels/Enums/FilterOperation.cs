using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.ViewModels.Enums
{
    public enum FilterOperation
    {
        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        Contains = 1,
        /// <summary>
        /// The starts with
        /// </summary>
        StartsWith = 2,
        /// <summary>
        /// The ends with
        /// </summary>
        EndsWith = 3,
        /// <summary>
        /// The greater than
        /// </summary>
        GreaterThan = 4,
        /// <summary>
        /// The less than
        /// </summary>
        LessThan = 5,
        /// <summary>
        /// The equals
        /// </summary>
        Equals = 6,
        /// <summary>
        /// The not equals
        /// </summary>
        NotEquals = 7,
        /// <summary>
        /// The greater than or equals
        /// </summary>
        GreaterThanOrEquals = 8,
        /// <summary>
        /// The less thank or equals
        /// </summary>
        LessThankOrEquals = 9,
        /// <summary>
        /// The ascending
        /// </summary>
        Ascending = 10,
        /// <summary>
        /// The descending
        /// </summary>
        Descending = 11,
        /// <summary>
        /// The date before
        /// </summary>
        DateBefore = 12,
        /// <summary>
        /// The date after
        /// </summary>
        DateAfter = 13
    }
}
