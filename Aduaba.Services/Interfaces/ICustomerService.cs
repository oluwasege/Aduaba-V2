using Aduaba.Core.Pagination;
using Aduaba.Core.ViewModels;
using Aduaba.Entities.Models;
using Aduaba.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Services.Interfaces
{
    public interface ICustomerService
    {
        public Task<ResultModel<PagedList<CustomerVM>>> GetAll(SearchVM model);
        public Task<ResultModel<List<CustomerVM>>> GetAllNPG();
    }
}
