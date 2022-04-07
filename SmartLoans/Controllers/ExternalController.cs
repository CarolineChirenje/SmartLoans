using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoan.Controllers
{
    public class ExternalController : BaseController<ExternalController>
    {
        public IActionResult Dashboard() => View();
    }
}
