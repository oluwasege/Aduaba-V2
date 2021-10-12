using Aduaba.Core.ViewModels;
using Aduaba.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba_V2.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery]SearchVM model)
        {
            var result = await _customerService.GetAll(model);
            return Ok(result);
        }

        [HttpGet("GetAllNPG")]
        public async Task<IActionResult> GetAllNPG()
        {
            var result = await _customerService.GetAllNPG();
            return Ok(result);
        }
    }
}
