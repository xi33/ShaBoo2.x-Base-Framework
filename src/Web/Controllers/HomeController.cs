﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShaBoo.Domain.Services;
using ShaBoo.Web.Infrastructure;

namespace ShaBoo.Web.Controllers
{
    public class HomeController : BaseController
    {
        private IBLLService _service;
        public HomeController(IBLLService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            ViewBag.Hello = "Hello World";
            ViewBag.Roles = _service.RoleService.GetAllRoles();
            return View();
        }

    }
}
