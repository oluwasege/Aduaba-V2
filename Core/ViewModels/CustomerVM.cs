using Aduaba.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.ViewModels
{
    public class CustomerVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        
        public static implicit operator CustomerVM(Customer model)
        {
            return model == null
                ? null
                : new CustomerVM()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Contact = model.Contact,
                    Email = model.Email
                };
        }
    }
}
