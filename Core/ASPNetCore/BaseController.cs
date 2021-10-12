using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.ASPNetCore
{
    public class BaseController:ControllerBase
    {
        private readonly ILog _logger;
        public BaseController()
        {
            _logger = LogManager.GetLogger(typeof(BaseController));
        }
    }
}
