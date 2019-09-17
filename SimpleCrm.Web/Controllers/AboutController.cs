using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace SimpleCrm.Web.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
    {
        return "Phone: 314-780-3530";
    }

        [Route("/address")]
    public string Address()
    {
        return "USA";
    }

  }
}

