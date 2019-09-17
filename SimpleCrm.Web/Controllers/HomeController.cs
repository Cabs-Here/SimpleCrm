using Microsoft.AspNetCore.Mvc;
using SimpleCrm.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CustomerModel
            {
                Id = 85,
                FirstName = "Ryan",
                LastName = "McKenzie",
                PhoneNumber = "314-780-3530"
            };
            return View(model);
        }
    }
}
