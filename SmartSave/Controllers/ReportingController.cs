﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSave.Controllers
{
    public class ReportingController : BaseController<ReportingController>
    {
        public IActionResult Dashboard() => View();
    }
}
