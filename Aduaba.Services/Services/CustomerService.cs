using Aduaba.Core.EFCore;
using Aduaba.Core.Pagination;
using Aduaba.Core.ViewModels;
using Aduaba.Entities.Models;
using Aduaba.Services.Interfaces;
using Aduaba.Services.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
      public async Task<ResultModel<PagedList<CustomerVM>>>GetAll(SearchVM model)
        {
            var resultModel = new ResultModel<PagedList<CustomerVM>>();

            try
            {
                var nameToSearch = model.Filters.FirstOrDefault()?.Keyword.ToLower().Trim();
                IQueryable<Customer> query;
                if(!String.IsNullOrWhiteSpace(nameToSearch))
                {
                    query = _context.Customers.Where(x=> x.FirstName.ToLower().Contains(nameToSearch) || x.LastName.ToLower().Contains(nameToSearch));
                }
                else
                {
                    query = _context.Customers.Where(x => x.IsDeleted == false);
                }
                var customers = await query.ToPagedListAsync(model.PageIndex, model.PageSize);
                var customerVMs = customers.Select(x => (CustomerVM)x).ToList();
                var data = new PagedList<CustomerVM>(customerVMs, model.PageIndex, model.PageSize, customers.TotalItemCount);
                resultModel.Data = data;
                resultModel.Message = $"Found {customers.Count} Customers";
            }
            catch (Exception ex)
            {
                resultModel.AddError(ex.Message);
            }
            return resultModel;
        }

        public async Task<ResultModel<List<CustomerVM>>> GetAllNPG()
        {
            var resultModel = new ResultModel<List<CustomerVM>>();
            try
            {
                var customers = await _context.Customers.Where(x => x.IsDeleted==false).ToListAsync();
                var customersVMs = customers.Select(x => (CustomerVM)x).ToList();
                resultModel.Data = customersVMs;
                resultModel.Message = $"Found {customers.Count} Customers";
            }
            catch (Exception ex)
            {
                resultModel.AddError(ex.Message);
            }
            return resultModel;
        }
    }
}
